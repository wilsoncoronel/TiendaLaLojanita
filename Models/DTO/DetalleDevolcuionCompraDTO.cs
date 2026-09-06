using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class DetalleDevolcuionCompraDTO
    {
        public int Id { get; set; }
        public int IdDetalleCompra { get; set; }
        public DetalleCompraDTO DetalleCompraDto { get; set; } = null!;

        public int Cantidad { get; set; }

        public bool Estado { get; set; }
    }
}
