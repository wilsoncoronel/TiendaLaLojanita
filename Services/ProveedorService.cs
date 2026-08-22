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
        private ApiClient _apiClient;
        public ProveedorService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<SriContribuyenteDTO> ConsultarRUC(string ruc)
        {
            var response = await _apiClient.GetAsync<SriContribuyenteDTO>($"api/Proveedor/ConsultarRuc?ruc={ruc}");
            return response.Value?? new SriContribuyenteDTO();  
        }

        public async Task<int> CrearProveedor(ProveedorCreacionDTO proveedorCreacionDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Proveedor/CrearProveedor", proveedorCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarProveedor(ProveedorEditarDTO proveedorEditarDTO)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Proveedor/EditarProveedor", proveedorEditarDTO);
            return response.Value;
        }

        public async Task<List<CiudadDTO>> ListarCiudades()
        {
            var response = await _apiClient.GetAsync<List<CiudadDTO>>($"api/Proveedor/ListarCiudades");
            return response.Value ?? new List<CiudadDTO>();
        }

        public async Task<List<ProveedorDTO>> ListarProveedores()
        {
            var response = await _apiClient.GetAsync<List<ProveedorDTO>>($"api/Proveedor/ListarProveedores");
            return response.Value ?? new List<ProveedorDTO>();
        }

        public async Task<List<TipoIdentificacionDTO>> ListarTiposIdentificacion()
        {
            var response = await _apiClient.GetAsync<List<TipoIdentificacionDTO>>($"api/Proveedor/ListarTiposIdentificacion");
            return response.Value ?? new List<TipoIdentificacionDTO>();
        }

        public async Task<ProveedorDTO> ObtenerProveedorCI(string identificacion, bool verPersona)
        {
            var response = await _apiClient.GetAsync<ProveedorDTO>($"api/Proveedor/BuscarProveedorCI?identificacion={identificacion}&verPersona={verPersona}");
            return response.Value ?? new ProveedorDTO();
        }
    }
}
