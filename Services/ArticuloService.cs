using Newtonsoft.Json;
using System.Text;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class ArticuloService : IArticuloService
    {
        private readonly ApiClient _apiClient;

        public ArticuloService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<int> CrearArticulo(ArticuloCreacionDTO articuloDto)
        {
            var response = await _apiClient.PostAsync<int>("api/Articulo/CrearArticulo",articuloDto);
            return response.Value;
        }

        public async Task<bool> CrearArticuloLista(List<ArticuloCreacionDTO> listaArticulosDto)
        {
            var response = await _apiClient.PostAsync<bool>(
                "api/Articulo/CrearArticulosLista",
                listaArticulosDto);
            return response.Value;
        }

        public Task<bool> DesactivarArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditarArticulo(ArticuloEdicionDTO articuloEdicionDTO)
        {
            var response = await _apiClient.PutAsync<bool>("api/Articulo/EditarArticulo",articuloEdicionDTO);
            return response.Value;
        }

        public async Task<List<ArticuloDTO>> ListaArticulos(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            var response = await _apiClient.GetAsync<List<ArticuloDTO>>($"api/Articulo/ListaArticulos?fechaInicial={fechaInicial:yyyy-MM-dd}&fechaFinal={fechaFinal:yyyy-MM-dd}");
            return response.Value ?? new List<ArticuloDTO>();
        }

        public async Task<List<ImpuestoArticuloDTO>> ListaImpuestoArticulo()
        {
            var response = await _apiClient.GetAsync<List<ImpuestoArticuloDTO>>($"api/Articulo/CargarListaImpuestosArticulos");
            return response.Value ?? new List<ImpuestoArticuloDTO>();
        }

        public async Task<List<PorcentajeGananciaDTO>> ListaPorcentajesGanancias()
        {
            var response = await _apiClient.GetAsync<List<PorcentajeGananciaDTO>>($"api/Articulo/ListarPorcentajes");
            return response.Value ?? new List<PorcentajeGananciaDTO>();
        }

        public async Task<List<MarcaDTO>> ListaMarcaArticulo()
        {
            var response = await _apiClient.GetAsync<List<MarcaDTO>>($"api/Articulo/CargarListaMarcasArticulos");
            return response.Value ?? new List<MarcaDTO>();
        }

        public async Task<List<TransaccionInventarioDTO>> ListaTransaccionInventario()
        {
            var response = await _apiClient.GetAsync<List<TransaccionInventarioDTO>>($"api/Configuraciones/ListarTransacciones");
            return response.Value?? new List<TransaccionInventarioDTO>();
        }

        public async Task<List<ArticuloInventarioDTO>> ListarTodosArticulos(bool esVenta)
        {
            var response = await _apiClient.GetAsync<List<ArticuloInventarioDTO>>($"api/Articulo/ListarTodosArticulos?esVenta={esVenta}");
            return response.Value ?? new List<ArticuloInventarioDTO>();
        }

        public async Task<List<TipoArticuloDTO>> ListaTipoArticulo()
        {
            var response = await _apiClient.GetAsync<List<TipoArticuloDTO>>($"api/Articulo/CargarListaTiposArticulos");
            return response.Value ?? new List<TipoArticuloDTO>();
        }
    }
}
