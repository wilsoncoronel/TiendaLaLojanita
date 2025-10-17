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
        private readonly HttpClient _httpClient;
       
        public VentaService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }
        public Task<bool> EditarVenta(VentaEditarDTO ventaDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EstadoVentaDTO>> ListarEstadosVenta()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Ventas/ListarEstadosVenta");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<EstadoVentaDTO>> result = JsonConvert.DeserializeObject<Response<List<EstadoVentaDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public Task<List<VentaMinDTO>> ListarVenta(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            throw new NotImplementedException();
        }

        public Task<VentaDTO> ObtenerVenta(int idVenta)
        {
            throw new NotImplementedException();
        }

        public async Task<int> RegistrarVenta(VentaCreacionDTO ventaDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(ventaDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Ventas/RegistrarVenta", content);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<int> result = JsonConvert.DeserializeObject<Response<int>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public Task<bool> ReversarVenta(int id)
        {
            throw new NotImplementedException();
        }
    }
}
