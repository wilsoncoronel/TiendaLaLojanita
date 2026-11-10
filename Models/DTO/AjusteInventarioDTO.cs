using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class AjusteInventarioDTO: AjusteInventarioCrearDTO
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaReversion { get; set; }
        public EstadoAjusteDTO EstadoAjusteDTO{ get; set; }
        public TransaccionInventarioDTO TransaccionInventarioDTO { get; set; }
        public UsuarioDTO UsuarioDTO{ get; set; }
    }
}
