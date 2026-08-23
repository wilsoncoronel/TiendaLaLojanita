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
    public class TiposArticulosService : ITiposArticulosService
    {
        private readonly ApiClient _apiClient;
        public TiposArticulosService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<int> CrearTipoArticulo(TipoArticuloCreacionDTO marcaCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Configuraciones/CrearTipoArticulo", marcaCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarTipoArticulo(TipoArticuloEditarDTO tipoArticuloEditarDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Configuraciones/EditarTipoArticulo", tipoArticuloEditarDto);
            return response.Value;
           
        }

        public async Task<List<TipoArticuloDTO>> ListarTiposArticulos()
        {
            var response = await this._apiClient.GetAsync<List<TipoArticuloDTO>>($"api/Configuraciones/ListarTiposArticulos");
            return response.Value;
        }
    }
}
