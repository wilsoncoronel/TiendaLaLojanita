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
    public class PorcentajeService : IPorcentajeService
    {
        private readonly HttpClient _httpClient;
        
        public PorcentajeService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("ApiClient");
        }
        public async Task<int> CrearPorcentaje(PorcentajeGananciaCreacionDTO porcentajeCreacionDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(porcentajeCreacionDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Configuraciones/CrearPorcentaje", content);
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

        public async Task<bool> EditarPorcentaje(PorcentajeGananciaDTO porcentajeEditarDto)
        {
            string json = JsonConvert.SerializeObject(porcentajeEditarDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this._httpClient.PutAsync($"api/Configuraciones/EditarPorcentaje", content);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<bool> result = JsonConvert.DeserializeObject<Response<bool>>(responseJson);
            return result.Value;
        }

        public async Task<List<PorcentajeGananciaDTO>> ListarPorcentajes()
        {
            HttpResponseMessage response = await this._httpClient.GetAsync($"api/Configuraciones/ListarPorcentajes");
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<List<PorcentajeGananciaDTO>> result = JsonConvert.DeserializeObject<Response<List<PorcentajeGananciaDTO>>>(responseJson);
            return result.Value;
        }
    }
}
