using iText.Kernel.Pdf.Tagutils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class CompraService : ICompraService
    {
        private readonly ApiClient _apiClient;

        public CompraService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<bool> EditarCompra(CompraEditarDTO compraDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Compras/EditarCompra", compraDto);
            return response.Value;
        }

        public async Task<List<CompraMinDTO>> ListarCompras(DateOnly fechaInicial, DateOnly fechaFinal)
        {
            var response = await _apiClient.GetAsync<List<CompraMinDTO>>($"api/Compras/ListarCompras?fechaInicial={fechaInicial:yyyy-MM-dd}&fechaFinal={fechaFinal:yyyy-MM-dd}");
            return response.Value;
        }

        public async Task<List<EstadoCompraDTO>> ListarEstadosCompra()
        { 
            var response = await _apiClient.GetAsync<List<EstadoCompraDTO>>($"api/Compras/ListarEstadosCompra");
            return response.Value;
        }

        public async Task<CompraDTO> ObtenerCompra(int idCompra)
        {
            var response = await _apiClient.GetAsync<CompraDTO>($"api/Compras/ObtenerCompra?idCompra={idCompra}");
            return response.Value;
        }

        public async Task<int> RegistrarCompra(CompraCreacionDTO compraDto)
        {
            var response = await this._apiClient.PostAsync<int>($"api/Compras/RegistrarCompra", compraDto);
            return response.Value;
        }

        public async Task<bool> ReversarCompra(int id)
        {
            var response = await _apiClient.GetAsync<bool>($"api/Compras/ReversarCompra?idCompra={id}");
            return response.Value;
        }
    }
}
