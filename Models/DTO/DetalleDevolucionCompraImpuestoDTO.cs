using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class DetalleDevolucionCompraImpuestoDTO: ImpuestoCrearDTO
    {
        public int IdImpuesto { get; set; }
        public TipoImpuestoDTO TipoImpuestoDTO{ get; set; }
    }
}
