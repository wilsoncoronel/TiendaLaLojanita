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

        public async Task<List<DetallesPagoDTO>> ListaDetallesPagos(int idPago)
        {
            var response = await _apiClient.GetAsync<List<DetallesPagoDTO>>($"api/Pagos/ListaDetallesPagos?idPago={idPago}");
            return response.Value ?? new List<DetallesPagoDTO>();
        }
        public Task<List<PagosVentasDTO>> ListarPagos(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PagosVentasDTO>> ListarPagosConCliente(DateOnly fechaInicial, DateOnly fechaFinal, int idCliente)
        {
            var response = await _apiClient.GetAsync<List<PagosVentasDTO>>($"api/Pagos/ListarPagosConCliente?fechaInicial={fechaInicial:yyyy-MM-dd}&fechaFinal={fechaFinal:yyyy-MM-dd}&idCliente={idCliente}");
            return response.Value ?? new List<PagosVentasDTO>();
        }

        public Task<int> ObtenerIdEstadoAsync(string nombre)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PagoVentaCompletoDTO>> PagoVenta(int idVenta)
        {
            var response = await _apiClient.GetAsync<List<PagoVentaCompletoDTO>>($"api/Pagos/PagoVenta?idVenta={idVenta}");
            return response.Value ?? new List<PagoVentaCompletoDTO>();
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
