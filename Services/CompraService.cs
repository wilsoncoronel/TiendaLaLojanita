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
        public Task<bool> EditarCompra(CompraEditarDTO compraDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompraMinDTO>> ListarCompras(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            throw new NotImplementedException();
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

        public Task<CompraDTO> ObtenerCompra(int idCompra)
        {
            throw new NotImplementedException();
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
