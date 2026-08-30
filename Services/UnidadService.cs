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
        public async Task<int> CreaUnidad(UnidadMedidaDTO marcaCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Configuraciones/CrearUnidadMedida", marcaCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarUnidad(UnidadMedidaDTO clienteEditarDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Configuraciones/EditarUnidadMedida", clienteEditarDto);
            return response.Value;
        }

        public async Task<List<UnidadMedidaDTO>> ListarUnidades()
        {
            var response = await this._apiClient.GetAsync<List<UnidadMedidaDTO>>($"api/Configuraciones/ListarUnidadesMedida");
            return response.Value;
        }
    }
}
