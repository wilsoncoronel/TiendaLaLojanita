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
    public class ProveedorService : IProveedorService
    {
        private HttpClient _httpClient;
        public ProveedorService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("ApiClient"); ;
        }

        public async Task<int> CrearProveedor(ProveedorCreacionDTO proveedorCreacionDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(proveedorCreacionDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Proveedor/CrearProveedor", content);
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

        public async Task<bool> EditarProveedor(ProveedorEditarDTO proveedorEditarDTO)
        {
            try
            {
                string json = JsonConvert.SerializeObject(proveedorEditarDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                // Cadena sin caracteres ocultos
                HttpResponseMessage response = await this._httpClient.PutAsync($"api/Proveedor/EditarProveedor", content);
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

        public async Task<List<CiudadDTO>> ListarCiudades()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Proveedor/ListarCiudades");
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

        public async Task<List<ProveedorDTO>> ListarProveedores()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Proveedor/ListarProveedores");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<ProveedorDTO>> result = JsonConvert.DeserializeObject<Response<List<ProveedorDTO>>>(responseJson);
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
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Proveedor/ListarTiposIdentificacion");
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

        public async Task<ProveedorDTO> ObtenerProveedorCI(string identificacion)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Proveedor/BuscarProveedorCI?identificacion={identificacion}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<ProveedorDTO> result = JsonConvert.DeserializeObject<Response<ProveedorDTO>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }

        }
    }
}
