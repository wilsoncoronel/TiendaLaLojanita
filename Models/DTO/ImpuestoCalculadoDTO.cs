using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ImpuestoArticuloCalculadoDTO
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public string NombreImpuesto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorImpuesto { get; set; }
        public int Cantidad { get; set; }
    }
}
