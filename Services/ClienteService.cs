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
    public class ClienteService : IClienteService
    {
        private HttpClient _httpClient;
        public ClienteService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }
        public async Task<ClienteDTO> ObtenerClienteCI(string identificacion)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Cliente/BuscarClienteCI?identificacion={identificacion}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<ClienteDTO> result = JsonConvert.DeserializeObject<Response<ClienteDTO>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }
    }
}
