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
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Login/IniciarSesion?usuario={usuario}&password={clave}");
                
                string responseJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error de login!!",
                        "Error de conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return new List<PermisosRolDTO>();
                }
                var result = JsonConvert.DeserializeObject<Response<List<PermisosRolDTO>>>(responseJson);
                if (result == null || !result.status)
                {
                    MessageBox.Show(
                        result?.msg ?? "Usuario o contraseña incorrectos.",
                        "Error de autenticación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return new List<PermisosRolDTO>();
                }
                return result.Value;
            }
            catch (HttpRequestException ex){
                MessageBox.Show(
                   $"No se pudo establecer conexión con el servidor.\nVerifica tu conexión a internet.",
                   "Error de red",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
                return new List<PermisosRolDTO>();
            }
            catch (Exception ex)
            {
               MessageBox.Show(
                   $"Ocurrió un error inesperado.\n\nDetalle: {ex.Message}",
                   "Error general",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
               return new List<PermisosRolDTO>();
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