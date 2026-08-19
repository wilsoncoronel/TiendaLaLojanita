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
using TiendaLaLojanita.Services;

namespace TiendaLaLojanita.Controllers
{
    public class LogginService: ILogginService
    {
        private ApiClient apiClient;
        public LogginService( ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<List<PermisosRolDTO>> IniciarSesion(string usuario, string clave)
        {
            var response = await apiClient.GetAsync<List<PermisosRolDTO>>($"api/Login/IniciarSesion?usuario={usuario}&password={clave}");
            return response.Value ?? new List<PermisosRolDTO>();
        }

        public async Task<SesionDTO> ExtraerSesion(string usuario)
        {
            var response = await apiClient.GetAsync<SesionDTO>($"api/Login/ExtraerSesion?usuario={usuario}");
            return response.Value!;
        }
    }
}