using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class CompraDTO
    {
        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public string Documento { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdEstado { get; set; }
        public int IdTransaccion { get; set; }
        public EstadoCompraDTO EstadoCompra { get; set; }
        public bool EstadoVisual { get; set; }
        public List<DetalleCompraDTO> DetalleCompras { get; set; } = new List<DetalleCompraDTO>();
        public decimal ValorIva { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public int IdUsuarioCreador { get; set; }
        public UsuarioDTO UsuarioCreador { get; set; }
        public ProveedorDTO ProveedorDto { get; set; }
    }
}
