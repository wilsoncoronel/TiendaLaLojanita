using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Utilidad
{
    public interface IProcesarExcel
    {
        (string sheetXml, List<string> sharedStrings) LeerExcel(string rutaArchivo);
        List<ArticuloCreacionDTO> LeerShetArticulo(string sheetXml, List<string> sharedStrings, int idUsuario);
        List<DetalleCompraCreacionDTO> LeerShetDetallesCompra(string sheetXml, List<string> sharedStrings);
        void ExportarDataGridView(DataGridView tabla, string rutaArchivo, string nombreHoja = "Hoja1");
    }

    public class ProcesarExcel : IProcesarExcel
    {
        public (string sheetXml, List<string> sharedStrings) LeerExcel(string rutaArchivo)
        {
            using (ZipArchive zip = ZipFile.OpenRead(rutaArchivo))
            {
                List<string> sharedStrings = new List<string>();
                  
                var sharedEntry = zip.GetEntry("xl/sharedStrings.xml");
                if (sharedEntry != null)
                {
                    using (var reader = XmlReader.Create(sharedEntry.Open()))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "t")
                                sharedStrings.Add(reader.ReadElementContentAsString());
                        }
                    }
                }
                // 2️⃣ Leer solo la hoja1
                var sheetEntry = zip.GetEntry("xl/worksheets/sheet1.xml");
                string sheetXml = "";

                using (var stream = sheetEntry.Open())
                using (var reader = new StreamReader(stream))
                {
                    sheetXml = reader.ReadToEnd();
                }
                // 3️⃣ Procesar hoja
                return (sheetXml, sharedStrings);
            }
        }

        public List<ArticuloCreacionDTO> LeerShetArticulo(string sheetXml, List<string> sharedStrings, int idUsuario)
        {
            List<ArticuloCreacionDTO> listaArticulos = new List<ArticuloCreacionDTO>();
            List<string> encabezados = new List<string>();
            bool esEncabezado = true;

            using (var reader = XmlReader.Create(new StringReader(sheetXml)))
            {
                List<string> fila = new List<string>();
                int filaNumero = 0;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "row")
                    {
                        // Intentar leer el atributo 'r' que indica el número de fila en el XML de la hoja
                        var rAttr = reader.GetAttribute("r");
                        if (!int.TryParse(rAttr, out filaNumero)) filaNumero = 0;
                        fila = new List<string>();
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "c")
                    {
                        string tipo = reader.GetAttribute("t");
                        string valor = "";

                        if (reader.ReadToDescendant("v"))
                        {
                            valor = reader.ReadElementContentAsString();
                            if (tipo == "s" && int.TryParse(valor, out int idx) && idx < sharedStrings.Count)
                                valor = sharedStrings[idx];
                        }

                        fila.Add(valor.Trim());
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "row")
                    {
                        // La primera fila: encabezados
                        if (esEncabezado)
                        {
                            encabezados = fila;
                            esEncabezado = false;
                            continue;
                        }

                        // Si la fila está vacía, se ignora
                        if (fila.Count == 0 || string.IsNullOrWhiteSpace(fila.First()))
                            continue;

                        try
                        {
                            // Busca el índice dinámicamente según el encabezado
                            string Get(string nombreCol) =>
                                fila.ElementAtOrDefault(encabezados.FindIndex(e => 
                                    e.Equals(nombreCol, StringComparison.OrdinalIgnoreCase))) ?? "";

                            var art = new TiendaLaLojanita.Models.DTO.ArticuloCreacionExcelDTO
                            {
                                Nombre = Get("Nombre"),
                                FechaCreacion = DateTime.Now,
                                FechaCaducidad = DateTime.Now,
                                IdUsuarioCreador = idUsuario,
                                EstadoVisual = true,
                                Estado = true,
                                ValorCompra = ParseDecimal(Get("ValorCompra")),
                                UnidadValor = ParseDecimal(Get("ValorUnidad")),
                                Descripcion = "INGRESO POR ARCHIVO",
                                IdUnidad = ParseInt(Get("IdUnidad")),
                                IdMarca = ParseInt(Get("IdMarca")),
                                IdTipoArticulo = ParseInt(Get("IdTipoArticulo")),
                                //IdImpuesto = ParseInt(Get("IdImpuesto")),
                                IdPorcentajeGanancia = ParseInt(Get("IdPorcentajeGanancia")),
                                Papeleria = false
                            };

                            // Asignar número de fila leída en el Excel para facilitar el reporte de errores
                            art.FilaExcel = filaNumero;

                            listaArticulos.Add(art);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al procesar fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            return listaArticulos;
        }

        // Conversores seguros
        private static int ParseInt(string value) =>
            int.TryParse(value, out int result) ? result : 0;

        private static decimal ParseDecimal(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 0;

            if (decimal.TryParse(value, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal result))
                return result;

            return 0;
        }

        private static bool ParseBool(string value) =>
            value == "1" || value.Equals("true", StringComparison.OrdinalIgnoreCase);

        private static bool? ParseBoolNullable(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;
            return value == "1" || value.Equals("true", StringComparison.OrdinalIgnoreCase);
        }

        private static DateTime ParseFecha(string value)
        {
            if (double.TryParse(value, out double oaDate))
                return DateTime.FromOADate(oaDate);
            return DateTime.Now;
        }

        public List<DetalleCompraCreacionDTO> LeerShetDetallesCompra(string sheetXml, List<string> sharedStrings)
        {
            List<DetalleCompraCreacionDTO> listaDetallesInventario = new List<DetalleCompraCreacionDTO>();
            List<string> encabezados = new List<string>();
            bool esEncabezado = true;

            using (var reader = XmlReader.Create(new StringReader(sheetXml)))
            {
                List<string> fila = new List<string>();

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "row")
                    {
                        fila = new List<string>();
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "c")
                    {
                        string tipo = reader.GetAttribute("t");
                        string valor = "";

                        if (reader.ReadToDescendant("v"))
                        {
                            valor = reader.ReadElementContentAsString();
                            if (tipo == "s" && int.TryParse(valor, out int idx) && idx < sharedStrings.Count)
                                valor = sharedStrings[idx];
                        }

                        fila.Add(valor.Trim());
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "row")
                    {
                        // La primera fila: encabezados
                        if (esEncabezado)
                        {
                            encabezados = fila;
                            esEncabezado = false;
                            continue;
                        }

                        // Si la fila está vacía, se ignora
                        if (fila.Count == 0 || string.IsNullOrWhiteSpace(fila.First()))
                            continue;

                        try
                        {
                            // Busca el índice dinámicamente según el encabezado
                            string Get(string nombreCol) =>
                                fila.ElementAtOrDefault(encabezados.FindIndex(e =>
                                    e.Equals(nombreCol, StringComparison.OrdinalIgnoreCase))) ?? "";

                            var det = new DetalleCompraCreacionDTO
                            {
                                IdArticulo = ParseInt(Get("IdArticulo")),
                                Descripcion = Get("Descripcion"),
                                Cantidad = ParseInt(Get("Cantidad")),
                                ValorCompra = ParseDecimal(Get("ValorCompra")),
                                ValorVenta = ParseDecimal(Get("ValorVenta")),
                                ValorTotal = ParseDecimal(Get("ValorTotal")),
                                ImpuestoValor = ParseDecimal(Get("ImpuestoValor"))
                            };

                            listaDetallesInventario.Add(det);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al procesar fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            return listaDetallesInventario;
        }

        public void ExportarDataGridView(DataGridView tabla, string rutaArchivo, string nombreHoja = "Hoja1")
        {
            ArgumentNullException.ThrowIfNull(tabla);

            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("La ruta del archivo es obligatoria.", nameof(rutaArchivo));
            }

            string hoja = NormalizarNombreHoja(nombreHoja);
            var columnas = tabla.Columns
                .Cast<DataGridViewColumn>()
                .Where(columna => columna.Visible)
                .OrderBy(columna => columna.DisplayIndex)
                .ToList();

            using var archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
            using var zip = new ZipArchive(archivo, ZipArchiveMode.Create);

            EscribirEntrada(zip, "[Content_Types].xml", $"""
                <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
                <Types xmlns="http://schemas.openxmlformats.org/package/2006/content-types">
                  <Default Extension="rels" ContentType="application/vnd.openxmlformats-package.relationships+xml"/>
                  <Default Extension="xml" ContentType="application/xml"/>
                  <Override PartName="/xl/workbook.xml" ContentType="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml"/>
                  <Override PartName="/xl/worksheets/sheet1.xml" ContentType="application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml"/>
                </Types>
                """);

            EscribirEntrada(zip, "_rels/.rels", """
                <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
                <Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
                  <Relationship Id="rId1" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument" Target="xl/workbook.xml"/>
                </Relationships>
                """);

            EscribirEntrada(zip, "xl/_rels/workbook.xml.rels", """
                <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
                <Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
                  <Relationship Id="rId1" Type="http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet" Target="worksheets/sheet1.xml"/>
                </Relationships>
                """);

            EscribirEntrada(zip, "xl/workbook.xml", $"""
                <?xml version="1.0" encoding="UTF-8" standalone="yes"?>
                <workbook xmlns="http://schemas.openxmlformats.org/spreadsheetml/2006/main" xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships">
                  <sheets>
                    <sheet name="{EscaparXml(hoja)}" sheetId="1" r:id="rId1"/>
                  </sheets>
                </workbook>
                """);

            var hojaXml = new StringBuilder();
            hojaXml.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            hojaXml.AppendLine("<worksheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">");
            hojaXml.AppendLine("  <sheetData>");
            hojaXml.AppendLine("    <row r=\"1\">");

            for (int indiceColumna = 0; indiceColumna < columnas.Count; indiceColumna++)
            {
                AgregarCeldaTexto(hojaXml, indiceColumna, 1, columnas[indiceColumna].HeaderText);
            }

            hojaXml.AppendLine("    </row>");

            int numeroFila = 2;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                if (fila.IsNewRow || !fila.Visible)
                {
                    continue;
                }

                hojaXml.AppendLine($"    <row r=\"{numeroFila}\">");

                for (int indiceColumna = 0; indiceColumna < columnas.Count; indiceColumna++)
                {
                    object? valor = fila.Cells[columnas[indiceColumna].Index].FormattedValue;
                    AgregarCeldaTexto(hojaXml, indiceColumna, numeroFila, valor?.ToString() ?? string.Empty);
                }

                hojaXml.AppendLine("    </row>");
                numeroFila++;
            }

            hojaXml.AppendLine("  </sheetData>");
            hojaXml.AppendLine("</worksheet>");

            EscribirEntrada(zip, "xl/worksheets/sheet1.xml", hojaXml.ToString());
        }

        private static void AgregarCeldaTexto(StringBuilder hojaXml, int indiceColumna, int numeroFila, string valor)
        {
            string referencia = $"{ObtenerLetraColumna(indiceColumna)}{numeroFila}";
            hojaXml.AppendLine($"      <c r=\"{referencia}\" t=\"inlineStr\"><is><t xml:space=\"preserve\">{EscaparXml(valor)}</t></is></c>");
        }

        private static string ObtenerLetraColumna(int indice)
        {
            var resultado = new StringBuilder();
            int valor = indice + 1;

            while (valor > 0)
            {
                valor--;
                resultado.Insert(0, (char)('A' + valor % 26));
                valor /= 26;
            }

            return resultado.ToString();
        }

        private static string NormalizarNombreHoja(string? nombreHoja)
        {
            string nombre = string.IsNullOrWhiteSpace(nombreHoja) ? "Hoja1" : nombreHoja.Trim();
            char[] caracteresInvalidos = { ':', '\\', '/', '?', '*', '[', ']' };

            foreach (char caracter in caracteresInvalidos)
            {
                nombre = nombre.Replace(caracter, '_');
            }

            return nombre.Length > 31 ? nombre[..31] : nombre;
        }

        private static string EscaparXml(string valor) =>
            System.Security.SecurityElement.Escape(valor) ?? string.Empty;

        private static void EscribirEntrada(ZipArchive zip, string nombre, string contenido)
        {
            var entrada = zip.CreateEntry(nombre, CompressionLevel.Fastest);
            using var stream = entrada.Open();
            using var writer = new StreamWriter(stream, new UTF8Encoding(false));
            writer.Write(contenido.Trim());
        }
    }
}