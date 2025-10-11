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
    public class CompraService : ICompraService
    {
        private readonly HttpClient _httpClient;

        public CompraService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }
        public async Task<bool> EditarCompra(CompraEditarDTO compraDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(compraDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PutAsync($"api/Compras/EditarCompra", content);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<bool> result = JsonConvert.DeserializeObject<Response<bool>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<CompraMinDTO>> ListarCompras(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Compras/ListarCompras?fechaInicial={fechaInicial:yyyy-MM-dd}&fechaFinal={fechaFinal:yyyy-MM-dd}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<CompraMinDTO>> result = JsonConvert.DeserializeObject<Response<List<CompraMinDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<EstadoCompraDTO>> ListarEstadosCompra()
        { 
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Compras/ListarEstadosCompra");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<EstadoCompraDTO>> result = JsonConvert.DeserializeObject<Response<List<EstadoCompraDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<CompraDTO> ObtenerCompra(int idCompra)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Compras/ObtenerCompra?idCompra={idCompra}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<CompraDTO> result = JsonConvert.DeserializeObject<Response<CompraDTO>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<int> RegistrarCompra(CompraCreacionDTO compraDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(compraDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Compras/RegistrarCompra", content);
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

        public Task<bool> ReversarCompra(int id)
        {
            throw new NotImplementedException();
        }
    }
}
