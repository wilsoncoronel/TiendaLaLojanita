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
using TiendaLaLojanita.Views;

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

        public async Task<List<MovimientoDTO>> ListaInventario(DateOnly Inicio, DateOnly Fin)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ListaInventario?fechaInicio={Inicio:yyyy-MM-dd}&fechaFin={Fin:yyyy-MM-dd}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<MovimientoDTO>> result = JsonConvert.DeserializeObject<Response<List<MovimientoDTO>>>(responseJson);
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

        public async Task<List<InventarioLoteDTO>> ListaDetallesInventario(int IdMovimiento)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ListaDetallesInventario?IdMovimiento={IdMovimiento}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<InventarioLoteDTO>> result = JsonConvert.DeserializeObject<Response<List<InventarioLoteDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

       

        public async Task<int> CrearTransaccionInventario(InventarioCreacionDTO traInventario)
        {
            try
            {
                string json = JsonConvert.SerializeObject(traInventario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Inventario/RegistrarTransaccionInventario", content);
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

        public async Task<List<ResumenVentasDiarioDTO>> ResumenVentasDiario(DateTime fechaResumen)
        {
            try
            {
                DateOnly fechaActual = DateOnly.FromDateTime(fechaResumen);
                var fechaStr = fechaActual.ToString("yyyy-MM-dd");
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ResumenVentasDiario?fechaResumen={fechaStr}");
                string responseJson = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    // Mostrar/registrar el cuerpo para diagnóstico del servidor
                    MessageBox.Show($"Operación fallida. Status {(int)response.StatusCode}: {response.ReasonPhrase}\n{responseJson}", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    response.EnsureSuccessStatusCode(); // lanzará la excepción original
                }
                
                Response<List<ResumenVentasDiarioDTO>> result = JsonConvert.DeserializeObject<Response<List<ResumenVentasDiarioDTO>>>(responseJson);
                return result.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Operación fallida."+ ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public async Task<List<ResumenVentasDiarioDTO>> ResumenVentasMensual(DateTime fechaResumen)
        {
            try
            {
                DateOnly fechaActual = DateOnly.FromDateTime(fechaResumen);
                var fechaStr = fechaActual.ToString("yyyy-MM-dd");
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Inventario/ResumenVentasMensual?fechaResumen={fechaStr}");
                string responseJson = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    // Mostrar/registrar el cuerpo para diagnóstico del servidor
                    MessageBox.Show($"Operación fallida. Status {(int)response.StatusCode}: {response.ReasonPhrase}\n{responseJson}", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    response.EnsureSuccessStatusCode(); // lanzará la excepción original
                }
                Response<List<ResumenVentasDiarioDTO>> result = JsonConvert.DeserializeObject<Response<List<ResumenVentasDiarioDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                MessageBox.Show("Operación fallida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }
    }
    
}
