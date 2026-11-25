using iText.Commons.Actions;
using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class PagoVentaService : IPagoVentaService
    {
        private readonly ApiClient _apiClient;

        public PagoVentaService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public Task<bool> ActualizarComprobantePago(ActualizarComprobantePagoDTO comprobanteDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnularPago(int idDetallePago)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetallesPagoDTO>> ListaDetallesPagos(int idPago)
        {
            throw new NotImplementedException();
        }

        public Task<List<PagosVentasDTO>> ListarPagos(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            throw new NotImplementedException();
        }

        public Task<int> ObtenerIdEstadoAsync(string nombre)
        {
            throw new NotImplementedException();
        }

        public async Task<PagosVentasDTO> PagoVenta(int idVenta)
        {
            var response = await _apiClient.GetAsync<PagosVentasDTO>($"api/Pagos/PagoVenta?idVenta={idVenta}");
            return response.Value ?? new PagosVentasDTO();
        }

        public async Task<List<EstadosPagoDTO>> ListarEstadosPagos()
        {
            var response = await _apiClient.GetAsync<List<EstadosPagoDTO>>($"api/Pagos/ListarEstadosPago");
            return response.Value ?? new List<EstadosPagoDTO>();
        }

        public async Task<List<TipoPagoDTO>> ListarTiposPagos()
        {
            var response = await _apiClient.GetAsync<List<TipoPagoDTO>>($"api/Pagos/ListarTiposPago");
            return response.Value ?? new List<TipoPagoDTO>();
        }

        public async Task<int> CrearDetallePago(DetallePagoCreacionDTO detalle)
        {
            var response = await _apiClient.PostAsync<int>($"api/Pagos/CrearDetallePago", detalle);
            return response.Value;
        }
    }
}
