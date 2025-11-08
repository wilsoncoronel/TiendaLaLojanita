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
    public class TiposArticulosService : ITiposArticulosService
    {
        private readonly HttpClient _httpClient;
        public TiposArticulosService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }
        public async Task<int> CrearTipoArticulo(TipoArticuloCreacionDTO marcaCreacionDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(marcaCreacionDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/TipoArticulo/CrearTipoArticulo", content);
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

        public async Task<bool> EditarTipoArticulo(TipoArticuloEditarDTO tipoArticuloEditarDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(tipoArticuloEditarDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Cadena sin caracteres ocultos
                HttpResponseMessage response = await this._httpClient.PutAsync($"api/TipoArticulo/EditarTipoArticulo", content);
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

        public async Task<List<TipoArticuloDTO>> ListarTiposArticulos()
        {
            HttpResponseMessage response = await this._httpClient.GetAsync($"api/TipoArticulo/ListarTiposArticulos");
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<List<TipoArticuloDTO>> result = JsonConvert.DeserializeObject<Response<List<TipoArticuloDTO>>>(responseJson);
            return result.Value;
        }
    }
}
