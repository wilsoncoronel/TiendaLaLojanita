using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Utilidad
{
    public interface IProcesarExcel
    {
        (string sheetXml, List<string> sharedStrings) LeerExcel(string rutaArchivo);
        List<ArticuloCreacionDTO> LeerShetArticulo(string sheetXml, List<string> sharedStrings, int idUsuario);
        List<DetalleCompraCreacionDTO> LeerShetDetallesCompra(string sheetXml, List<string> sharedStrings);
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
                                IdImpuesto = ParseInt(Get("IdImpuesto")),
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
    }
}