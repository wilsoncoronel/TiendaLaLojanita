using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ActualizarComprobantePagoDTO
    {
        public int IdDetallePago { get; set; }
        public string NumeroComprobante { get; set; } = null!;
    }
}
