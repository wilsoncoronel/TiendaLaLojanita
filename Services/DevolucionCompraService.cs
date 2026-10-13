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
    public class DevolucionCompraService : IDevolucionCompraService
    {
        private readonly ApiClient apiClient;

        public DevolucionCompraService(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        public async Task<int> CrearDevolucionCompra(DevolucionCompraCreacionDTO devolucion)
        {
            var response = await this.apiClient.PostAsync<int>("api/DevolucionCompra/CrearDevolucionCompra", devolucion);
            return response.Value;
        }

        public async Task<List<TransaccionInventarioDTO>> ListaTransaccionesInventario()
        {
            var response = await this.apiClient.GetAsync<List<TransaccionInventarioDTO>>("api/Configuraciones/ListarTransacciones");
            return response.Value;
        }

        public async Task<List<TipoDevolucionDTO>> ListaTiposDevolucion()
        {
            var response = await this.apiClient.GetAsync<List<TipoDevolucionDTO>>("api/DevolucionCompra/ListarTiposDevolucion");
            return response.Value;
        }

        public async Task<List<DevolucionCompraDTO>> ListarDevolucionesFechas(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            var response = await apiClient.GetAsync<List<DevolucionCompraDTO>>($"api/DevolucionCompra/ListarDevolucionesFechas?fechaInicio={fechaInicial:yyyy-MM-dd}&fechaFin={fechaFinal:yyyy-MM-dd}");
            return response.Value;
        }

        public async Task<CreditoProveedorDTO> VerCreditoPorDevolucion(int idDevolucion)
        { 
        
            var response = await apiClient.GetAsync<CreditoProveedorDTO>(
                $"api/DevolucionCompra/VerCreditoPorDevolucion?idDevolucion={idDevolucion}");

            return response.Value ?? new CreditoProveedorDTO();
        }

        public async Task<List<DetalleDevolucionCompraDTO>> ListarDetallesDevolucion(int idDetalleDevolucion)
        {
            var response = await apiClient.GetAsync<List<DetalleDevolucionCompraDTO>>($"api/DevolucionCompra/ListarDetallesDevolucion?idDevolucionCompra={idDetalleDevolucion}");
            return response.Value;
        }
    }
}
