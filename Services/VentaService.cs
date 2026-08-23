using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class VentaService : IVentaService
    {
        private readonly ApiClient _apiClient;
       
        public VentaService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public Task<bool> EditarVenta(VentaEditarDTO ventaDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EstadoVentaDTO>> ListarEstadosVenta()
        {
            var response = await _apiClient.GetAsync<List<EstadoVentaDTO>>($"api/Ventas/ListarEstadosVenta");
            return response.Value;
        }

        public async Task<List<VentaMinDTO>> ListarVenta(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            var response = await _apiClient.GetAsync<List<VentaMinDTO>>($"api/Ventas/ListarVentas?fechaInicial={fechaInicial:yyyy-MM-dd}&fechaFinal={fechaFinal:yyyy-MM-dd}");
            return response.Value;
        }

        public async Task<VentaDTO> ObtenerVenta(int idVenta)
        {
            var response = await _apiClient.GetAsync<VentaDTO>($"api/Ventas/ObtenerVenta?idVenta={idVenta}");
            return response.Value;
        }

        public async Task<int> RegistrarVenta(VentaCreacionDTO ventaDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Ventas/RegistrarVenta", ventaDto);
            return response.Value;
            
        }

        public Task<bool> ReversarVenta(int id)
        {
            throw new NotImplementedException();
        }
    }
}
