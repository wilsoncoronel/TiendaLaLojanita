using SistemaTienda.DTO;
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

namespace TiendaLaLojanita.Controllers
{
    public class LoginController
    {
        private HttpClient _httpClient;
        public LoginController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<PermisosRolDTO>> IniciarSesion(string usuario, string clave)
        {
            try {
                PermisosRolDTO permisosRolDto = new PermisosRolDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"https://localhost:7168/api/Login/IniciarSesion?usuario={usuario}&password={clave}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<PermisosRolDTO>> result = JsonConvert.DeserializeObject<Response<List<PermisosRolDTO>>>(responseJson);

                return result.Value;
            }
            catch {
                throw;
            }
            
        }
    }
}