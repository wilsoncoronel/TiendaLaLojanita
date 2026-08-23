using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class ClienteService : IClienteService
    {
        private ApiClient _apiClient;
        public ClienteService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }

        public async Task<int> CrearCliente(ClienteCreacionDTO clienteCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Cliente/CrearCliente", clienteCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarCliente(ClienteEditarDTO clienteEditarDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Cliente/EditarCliente", clienteEditarDto);
            return response.Value;
        }

        public async Task<ClienteDTO> ObtenerClienteCI(string identificacion)
        {
            var response = await _apiClient.GetAsync<ClienteDTO>($"api/Cliente/BuscarClienteCI?identificacion={identificacion}");
            return response.Value;
            
        }

        public async Task<List<TipoIdentificacionDTO>> ListarTiposIdentificacion()
        {
            var response = await _apiClient.GetAsync<List<TipoIdentificacionDTO>>($"api/Cliente/ListarTiposIdentificacion");
            return response.Value;
        }
        public async Task<List<CiudadDTO>> ListarCiudades()
        {
            var response = await _apiClient.GetAsync<List<CiudadDTO>>($"api/Cliente/ListarCiudades");
            return response.Value;
        }

        public async Task<List<ClienteDTO>> ListarClientes()
        {
            var response = await _apiClient.GetAsync<List<ClienteDTO>>($"api/Cliente/ListarClientes");
            return response.Value;
        }
    }
}
