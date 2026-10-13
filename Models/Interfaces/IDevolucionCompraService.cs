using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IDevolucionCompraService
    {
        Task<CreditoProveedorDTO> VerCreditoPorDevolucion(int idDevolucion);
        Task<int> CrearDevolucionCompra(DevolucionCompraCreacionDTO devolucion);
        Task<List<TransaccionInventarioDTO>> ListaTransaccionesInventario();
        Task<List<TipoDevolucionDTO>> ListaTiposDevolucion();
        Task<List<DetalleDevolucionCompraDTO>> ListarDetallesDevolucion(int idDetalleDevolucion);
        Task<List<DevolucionCompraDTO>> ListarDevolucionesFechas(DateOnly fechaInicial, DateOnly fechaFinal);
    }
}
