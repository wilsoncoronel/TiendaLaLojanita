using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class UnidadService : IUnidadService
    {
        private readonly ApiClient _apiClient;
        public UnidadService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<int> CreaUnidad(UnidadCreacionDTO unidadCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Configuraciones/CrearUnidadMedida", unidadCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarUnidad(UnidadMedidaDTO unidadMedidaDTO)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Configuraciones/EditarUnidadMedida", unidadMedidaDTO);
            return response.Value;
        }

        public async Task<List<UnidadMedidaDTO>> ListarUnidades()
        {
            var response = await this._apiClient.GetAsync<List<UnidadMedidaDTO>>($"api/Configuraciones/ListarUnidadesMedida");
            return response.Value;
        }
    }
}
