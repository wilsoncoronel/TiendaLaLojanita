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
        private ApiClient _apiClient;
        public InventarioService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }

        public async Task<List<InventarioLoteDTO>> ExistenciasInventario(bool incluirCeros = false)
        {
            var response = await _apiClient.GetAsync<List<InventarioLoteDTO>>($"api/Inventario/ExistenciasInventario?incluirCeros={incluirCeros}");
            return response.Value;
        }

        public async Task<List<MovimientoDTO>> ListaInventario(DateOnly Inicio, DateOnly Fin)
        {
            var response = await _apiClient.GetAsync<List<MovimientoDTO>>($"api/Inventario/ListaInventario?fechaInicio={Inicio:yyyy-MM-dd}&fechaFin={Fin:yyyy-MM-dd}");
            return response.Value;
        }

        public async Task<List<TransaccionInventarioDTO>> ListaTransaccionesInventario()
        {
            var response = await _apiClient.GetAsync<List<TransaccionInventarioDTO>>($"api/Inventario/ListaTransaccionesInventario");
            return response.Value;
        }

        public async Task<List<InventarioLoteDTO>> ListaDetallesInventario(int IdMovimiento)
        {
            var response = await _apiClient.GetAsync<List<InventarioLoteDTO>>($"api/Inventario/ListaDetallesInventario?IdMovimiento={IdMovimiento}");
            return response.Value;
        }

       

        public async Task<int> CrearTransaccionInventario(InventarioCreacionDTO traInventario)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Inventario/RegistrarTransaccionInventario", traInventario);
            return response.Value;
        }

        public async Task<List<ResumenVentasDiarioDTO>> ResumenVentasDiario(DateTime fechaResumen)
        {   
            DateOnly fechaActual = DateOnly.FromDateTime(fechaResumen);
            var fechaStr = fechaActual.ToString("yyyy-MM-dd");
            var response = await _apiClient.GetAsync<List<ResumenVentasDiarioDTO>>($"api/Inventario/ResumenVentasDiario?fechaResumen={fechaStr}");
            return response.Value;
        }

        public async Task<List<ResumenVentasDiarioDTO>> ResumenVentasMensual(DateTime fechaResumen)
        {
            DateOnly fechaActual = DateOnly.FromDateTime(fechaResumen);
            var fechaStr = fechaActual.ToString("yyyy-MM-dd");
            var response = await _apiClient.GetAsync<List<ResumenVentasDiarioDTO>>($"api/Inventario/ResumenVentasMensual?fechaResumen={fechaStr}");
            return response.Value;
        }
    }
}