using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class DetalleAjusteInventarioCompletoDTO
    {
        public int Id { get; set; }

        public int IdArticulo { get; set; }

        public int Cantidad { get; set; }

        public decimal CostoUnitario { get; set; }

        public bool Estado { get; set; }

        public List<ImpuestoCompraDTO> ImpuestosCompra { get; set; } = new List<ImpuestoCompraDTO>();
    }
}
