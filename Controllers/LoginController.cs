using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Controllers
{
    public class LoginController
    {
        private HttpClient _httpClient;
        public LoginController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<SesionDTO>
    }
}
