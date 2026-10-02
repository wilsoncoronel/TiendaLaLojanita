using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ImpuestoCalculadoDTO
    {
        public int IdArticulo { get; set; }
        public int IdImpuesto { get; set; }
        public string NombreImpuesto { get; set; }
        public string TipoImpuesto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorConfigurado { get; set; }
        public decimal ValorImpuesto { get; set; }
        public decimal Cantidad { get; set; }
    }
}
