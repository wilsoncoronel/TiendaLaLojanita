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
                var fechaIniDt = fechaInicial.ToDateTime(TimeOnly.MinValue);
                var fechaFinDt = fechaFinal.ToDateTime(TimeOnly.MaxValue);
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

        public async Task<List<ArticuloDTO>> ListarTodosArticulos()
        {
            try {
                ArticuloDTO impuestoArticuloDTO = new ArticuloDTO();
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Articulo/ListarTodosArticulos");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<ArticuloDTO>> result = JsonConvert.DeserializeObject<Response<List<ArticuloDTO>>>(responseJson);
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
