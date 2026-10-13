using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class DevolucionCompraMinDTO
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int Estado { get; set; }

        public string Motivo { get; set; } = string.Empty;
        public int IdTipoDevolucion { get; set; }
    }
}
