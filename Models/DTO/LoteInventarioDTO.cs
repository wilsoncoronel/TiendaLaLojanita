using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class LoteInventarioDTO
    {
        public int IdLote { get; set; }

        public int IdArticulo { get; set; }

        public string NumeroLote { get; set; } = null!;

        public string? Codigo { get; set; }

        public decimal StockDisponible { get; set; }
    }
}
