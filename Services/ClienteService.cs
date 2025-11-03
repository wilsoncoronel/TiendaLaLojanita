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
        private HttpClient _httpClient;
        public ClienteService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }

        public async Task<int> CrearCliente(ClienteCreacionDTO clienteCreacionDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(clienteCreacionDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Cliente/CrearCliente", content);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<int> result = JsonConvert.DeserializeObject<Response<int>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> EditarCliente(ClienteEditarDTO clienteEditarDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(clienteEditarDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Cadena sin caracteres ocultos
                HttpResponseMessage response = await this._httpClient.PutAsync($"api/Cliente/EditarCliente", content);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<bool> result = JsonConvert.DeserializeObject<Response<bool>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<ClienteDTO> ObtenerClienteCI(string identificacion)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Cliente/BuscarClienteCI?identificacion={identificacion}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<ClienteDTO> result = JsonConvert.DeserializeObject<Response<ClienteDTO>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<TipoIdentificacionDTO>> ListarTiposIdentificacion()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Cliente/ListarTiposIdentificacion");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<TipoIdentificacionDTO>> result = JsonConvert.DeserializeObject<Response<List<TipoIdentificacionDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        //api/Cliente/ListarCiudades
        public async Task<List<CiudadDTO>> ListarCiudades()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Cliente/ListarCiudades");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<CiudadDTO>> result = JsonConvert.DeserializeObject<Response<List<CiudadDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<ClienteDTO>> ListarClientes()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Cliente/ListarClientes");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<ClienteDTO>> result = JsonConvert.DeserializeObject<Response<List<ClienteDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }
    }
}
