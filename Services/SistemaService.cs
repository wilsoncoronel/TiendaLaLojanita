using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class SistemaService : ISistemaService
    {
        private readonly ApiClient _apiClient;

        public SistemaService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<List<PersonaDTO>> ListaPersonas()
        {
            var response = await _apiClient.GetAsync<List<PersonaDTO>>($"api/Sistemas/ListarPersonas");
            return response.Value ?? new List<PersonaDTO>();
        }
    }
}
