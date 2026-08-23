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
        private readonly ApiClient _apiClient;
        
        public PorcentajeService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<int> CrearPorcentaje(PorcentajeGananciaCreacionDTO porcentajeCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Configuraciones/CrearPorcentaje", porcentajeCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarPorcentaje(PorcentajeGananciaDTO porcentajeEditarDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Configuraciones/EditarPorcentaje", porcentajeEditarDto);
            return response.Value;
        }

        public async Task<List<PorcentajeGananciaDTO>> ListarPorcentajes()
        {
            var response = await this._apiClient.GetAsync<List<PorcentajeGananciaDTO>>($"api/Configuraciones/ListarPorcentajes");
            return response.Value;
        }
    }
}
