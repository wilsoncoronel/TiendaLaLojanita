using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Controllers
{
    public class LogginService: ILogginService
    {
        private HttpClient _httpClient;
        public LogginService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        public async Task<List<PermisosRolDTO>> IniciarSesion(string usuario, string clave)
        {
            try {
                PermisosRolDTO permisosRolDto = new PermisosRolDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Login/IniciarSesion?usuario={usuario}&password={clave}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<PermisosRolDTO>> result = JsonConvert.DeserializeObject<Response<List<PermisosRolDTO>>>(responseJson);

                return result.Value;
            }
            catch {
                throw;
            }
            
        }

        public async Task<SesionDTO> ExtraerSesion(string usuario)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Login/ExtraerSesion?usuario={usuario}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<SesionDTO> result = JsonConvert.DeserializeObject<Response<SesionDTO>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }

        }
    }
}