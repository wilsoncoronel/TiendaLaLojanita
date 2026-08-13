using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ArticuloInventarioDTO
    {
        public ArticuloDTO Articulo { get; set; } = new ArticuloDTO();

        // Campos de lote / inventario
        public string NumeroLote { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public DateTime? FechaIngreso { get; set; }
        public DateOnly? FechaExpiracion { get; set; }
        public decimal StockDisponible { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal CostoUnitario { get; set; }

        // Conveniencia
        public int IdArticulo => Articulo?.Id ?? 0;
    }
}
