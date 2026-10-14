using iText.Barcodes;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using PdfImage = iText.Layout.Element.Image;

namespace TiendaLaLojanita.Utilidad
{
    public class Impresiones
    {
        private const float MargenPagina = 28.35f;

        private const float AnchoEtiqueta = 180f;
        private const float AltoEtiqueta = 108f;
        private const int ColumnasPorPagina = 3;
        private const int FilasPorPagina = 7;

        public bool ImpresionCodigoArticulo(
            string codigo,
            string nombreArticulo,
            string lote,
            int cantidad)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código del artículo es obligatorio.", nameof(codigo));

            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad debe ser mayor que cero.");

            using var guardar = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true,
                FileName = $"Codigos_{codigo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf",
                Title = "Guardar códigos de artículos"
            };

            if (guardar.ShowDialog() != DialogResult.OK)
                return false;

            using var stream = new FileStream(guardar.FileName, FileMode.Create, FileAccess.Write);
            using var writer = new PdfWriter(stream);
            using var pdf = new PdfDocument(writer);
            using var documento = new Document(pdf, PageSize.A4);

            documento.SetMargins(MargenPagina, MargenPagina, MargenPagina, MargenPagina);

            var tabla = new Table(UnitValue.CreatePercentArray(ColumnasPorPagina))
                .UseAllAvailableWidth()
                .SetBorder(Border.NO_BORDER);

            for (int indice = 0; indice < cantidad; indice++)
            {
                tabla.AddCell(CrearEtiqueta(pdf, codigo, nombreArticulo, lote));
            }

            int celdasRestantes = (ColumnasPorPagina * FilasPorPagina) - (cantidad % (ColumnasPorPagina * FilasPorPagina));
            if (cantidad % (ColumnasPorPagina * FilasPorPagina) != 0)
            {
                for (int indice = 0; indice < celdasRestantes; indice++)
                {
                    tabla.AddCell(new Cell().SetHeight(AltoEtiqueta).SetBorder(Border.NO_BORDER));
                }
            }

            documento.Add(tabla);
            return true;
        }

        private static Cell CrearEtiqueta(
            PdfDocument pdf,
            string codigo,
            string nombreArticulo,
            string lote)
        {
            var barcode = new Barcode128(pdf);
            barcode.SetCode(codigo);
            barcode.SetCodeType(Barcode128.CODE128);
            barcode.SetBarHeight(32f);
            barcode.SetX(0.8f);

            var imagenCodigo = new PdfImage(
                    barcode.CreateFormXObject(
                        ColorConstants.BLACK,
                        ColorConstants.BLACK,
                        pdf))
                .ScaleToFit(160f, 42f)
                .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            var celda = new Cell()
                .SetHeight(AltoEtiqueta)
                .SetPadding(5f)
                .SetBorder(new SolidBorder(0.5f));

            celda.Add(new Paragraph(nombreArticulo ?? string.Empty)
                .SetFontSize(8f)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMargin(0f));

            if (!string.IsNullOrWhiteSpace(lote))
            {
                celda.Add(new Paragraph($"Lote: {lote}")
                    .SetFontSize(7f)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMargin(1f));
            }

            celda.Add(imagenCodigo
                .SetMarginTop(2f)
                .SetMarginBottom(1f));

            celda.Add(new Paragraph(codigo)
                .SetFontSize(7f)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMargin(0f));

            return celda;
        }
    }
}
