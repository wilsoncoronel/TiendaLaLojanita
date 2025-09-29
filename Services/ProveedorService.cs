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
    public class ProveedorService : IProveedorService
    {
        private HttpClient _httpClient;
        public ProveedorService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("ApiClient"); ;
        }
        public async Task<ProveedorDTO> ObtenerProveedorCI(string identificacion)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Proveedor/BuscarProveedorCI?identificacion={identificacion}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<ProveedorDTO> result = JsonConvert.DeserializeObject<Response<ProveedorDTO>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }

        }
    }
}
