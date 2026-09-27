using System.Collections.Generic;

namespace TiendaLaLojanita.Models.DTO
{
    public class ArticuloImpuestosCalculadosDTO
    {
        public int IdArticulo { get; set; }
        public int IdImpuesto { get; set; }
        public string NombreImpuesto { get; set; }
        public string TipoImpuesto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorImpuesto { get; set; }
        public decimal Cantidad { get; set; }
    }
}