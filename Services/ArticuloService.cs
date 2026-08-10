using Newtonsoft.Json;
using System.Text;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class ArticuloService : IArticuloService
    {
        private readonly HttpClient _httpClient;

        public ArticuloService(IHttpClientFactory httpClientFactory)
        {
            this._httpClient = httpClientFactory.CreateClient("ApiClient");
        }
        public async Task<int> CrearArticulo(ArticuloCreacionDTO articuloDto)
        {
            try
            {
                string json = JsonConvert.SerializeObject(articuloDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PostAsync($"api/Articulo/CrearArticulo",content);
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<int> result = JsonConvert.DeserializeObject<Response<int>>(responseJson);
                return result.Value;
            }
            catch {
                throw;
            }
        }

        public async Task<bool> CrearArticuloLista(List<ArticuloCreacionDTO> listaArticulosDto)
        {
            string json = JsonConvert.SerializeObject(listaArticulosDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this._httpClient.PostAsync($"api/Articulo/CrearArticulosLista", content);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<bool> result = JsonConvert.DeserializeObject<Response<bool>>(responseJson);
            return result.Value;
        }

        public Task<bool> DesactivarArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditarArticulo(ArticuloEdicionDTO articuloEdicionDTO)
        {
            try
            {
                string json = JsonConvert.SerializeObject(articuloEdicionDTO);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this._httpClient.PutAsync($"api/Articulo/EditarArticulo", content);
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

        public async Task<List<ArticuloDTO>> ListaArticulos(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            try
            {
               
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Articulo/ListaArticulos?fechaInicial={fechaInicial:yyyy-MM-dd}&fechaFinal={fechaFinal:yyyy-MM-dd}");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<ArticuloDTO>> result = JsonConvert.DeserializeObject<Response<List<ArticuloDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<ImpuestoArticuloDTO>> ListaImpuestoArticulo()
        {
            try
            {
                ImpuestoArticuloDTO impuestoArticuloDTO = new ImpuestoArticuloDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Articulo/CargarListaImpuestosArticulos");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<ImpuestoArticuloDTO>> result = JsonConvert.DeserializeObject<Response<List<ImpuestoArticuloDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<MarcaDTO>> ListaMarcaArticulo()
        {
            try
            {
                MarcaDTO MarcaDTO = new MarcaDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Articulo/CargarListaMarcasArticulos");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<MarcaDTO>> result = JsonConvert.DeserializeObject<Response<List<MarcaDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<TransaccionInventarioDTO>> ListaTransaccionInventario()
        {
            try
            {
                MarcaDTO MarcaDTO = new MarcaDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Configuraciones/ListarTransacciones");
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

        public async Task<List<InventarioLoteDTO>> ListarTodosArticulos()
        {
            try {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Articulo/ListarTodosArticulos");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<InventarioLoteDTO>> result = JsonConvert.DeserializeObject<Response<List<InventarioLoteDTO>>>(responseJson);
                return result.Value;

            } catch {
                throw;
            }
            
        }

        public async Task<List<TipoArticuloDTO>> ListaTipoArticulo()
        {
            try
            {
                TipoArticuloDTO TipoArticuloDTO = new TipoArticuloDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Articulo/CargarListaTiposArticulos");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<TipoArticuloDTO>> result = JsonConvert.DeserializeObject<Response<List<TipoArticuloDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }
    }
}
