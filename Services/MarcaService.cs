using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class MarcaService : IMarcaService
    {
        private readonly HttpClient _httpClient;

        public MarcaService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }
        public async Task<int> CrearMarca(MarcaCreacionDTO marcaCreacionDto)
        {
            string json = JsonConvert.SerializeObject(marcaCreacionDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this._httpClient.PostAsync($"api/Marca/CrearMarca", content);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<int> result = JsonConvert.DeserializeObject<Response<int>>(responseJson);
            return result.Value;
        } 

        public async Task<bool> EditarMarca(MarcaEditarDTO marcaEditarDto)
        {
            string json = JsonConvert.SerializeObject(marcaEditarDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this._httpClient.PutAsync($"api/Marca/EditarMarca", content);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<bool> result = JsonConvert.DeserializeObject<Response<bool>>(responseJson);
            return result.Value;
        } 

        public async Task<List<MarcaDTO>> ListarMarcas()
        {
            HttpResponseMessage response = await this._httpClient.GetAsync($"api/Marca/ListaMarcas");
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<List<MarcaDTO>> result = JsonConvert.DeserializeObject<Response<List<MarcaDTO>>>(responseJson);
            return result.Value;

        }
    }
}
