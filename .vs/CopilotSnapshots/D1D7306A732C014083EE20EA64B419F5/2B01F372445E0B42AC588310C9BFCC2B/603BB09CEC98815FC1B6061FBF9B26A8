using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IPagoVentaService
    {
        Task<PagoVentaCompletoDTO> PagoVenta(int idVenta);
        Task<List<PagosVentasDTO>> ListarPagos(DateOnly fechaInicial, DateOnly fechaFinal);
        Task<List<DetallesPagoDTO>> ListaDetallesPagos(int idPago);
        Task<bool> AnularPago(int idDetallePago);
        Task<bool> ActualizarComprobantePago(ActualizarComprobantePagoDTO comprobanteDto);
        Task<int> ObtenerIdEstadoAsync(string nombre);
        Task<List<EstadosPagoDTO>> ListarEstadosPagos();
        Task<List<TipoPagoDTO>> ListarTiposPagos();
        Task<int> CrearDetallePago(DetallePagoCreacionDTO detalle);
    }
}
