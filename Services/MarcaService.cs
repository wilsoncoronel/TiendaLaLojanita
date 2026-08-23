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
    public class MarcaService : IMarcaService
    {
        private readonly ApiClient _apiClient;

        public MarcaService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<int> CrearMarca(MarcaCreacionDTO marcaCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Configuraciones/CrearMarca", marcaCreacionDto);
            return response.Value;
        } 

        public async Task<bool> EditarMarca(MarcaEditarDTO marcaEditarDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Configuraciones/EditarMarca", marcaEditarDto);
            return response.Value;
        } 

        public async Task<List<MarcaDTO>> ListarMarcas()
        {
            var response = await this._apiClient.GetAsync<List<MarcaDTO>>($"api/Configuraciones/ListarMarcas");
            return response.Value;
        }
    }
}
