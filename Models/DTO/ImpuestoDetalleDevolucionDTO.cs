using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ImpuestoDetalleDevolucionDTO: ImpuestoCrearDTO
    {
        public int Id { get; set; }
        public int IdDetalleDevolucionCompra { get; set; }
    }
}
