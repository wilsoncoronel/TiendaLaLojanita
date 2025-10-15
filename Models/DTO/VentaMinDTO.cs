using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class VentaMinDTO
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdEstado { get; set; }
        public EstadoVentaDTO EstadoVentaDto { get; set; }
        public int IdUsuarioCreador { get; set; }
        public UsuarioMinDTO UsuarioCreadorMinDTO { get; set; }

        public ClienteMinDTO ProveedorMinDto { get; set; }
    }
}
