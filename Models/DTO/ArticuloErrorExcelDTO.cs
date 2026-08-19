using System.Collections.Generic;

namespace TiendaLaLojanita.Models.DTO
{
    public class ArticuloErrorExcelDTO
    {
        public int Fila { get; set; }
        public ArticuloCreacionDTO Articulo { get; set; } = new();
        public List<string> Errores { get; set; } = new();
        public List<string> CamposInvalidos { get; set; } = new();

        public string Detalle => string.Join(System.Environment.NewLine, Errores);
    }
}
