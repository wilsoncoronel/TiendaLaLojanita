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
    public class InventarioService : IInventarioService
    {
        private HttpClient _httpClient;
        public InventarioService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }

        public async Task<List<ExistenciaDTO>> ExistenciasInventario()
        {
            try
            {
                ImpuestoArticuloDTO impuestoArticuloDTO = new ImpuestoArticuloDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ExistenciasInventario");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<ExistenciaDTO>> result = JsonConvert.DeserializeObject<Response<List<ExistenciaDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<InventarioDTO>> ListaInventario(DateOnly Inicio, DateOnly Fin)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ListaInventario?fechaInicio={Inicio:yyyy-MM-dd}&fechaFin={Fin:yyyy-MM-dd}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<InventarioDTO>> result = JsonConvert.DeserializeObject<Response<List<InventarioDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<TransaccionInventarioDTO>> ListaTransaccionesInventario()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ListaTransaccionesInventario");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<TransaccionInventarioDTO>> result = JsonConvert.DeserializeObject<Response<List<TransaccionInventarioDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<DetalleInventarioDTO>> ListaDetallesInventario(int IdInventario)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ListaDetallesInventario?IdInventario={IdInventario}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<DetalleInventarioDTO>> result = JsonConvert.DeserializeObject<Response<List<DetalleInventarioDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }
    }
    
}
