using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class CreditoProveedorService : ICreditoProveedorService
    {
        private readonly ApiClient _apiClient;

        public CreditoProveedorService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        
        public async Task<List<CreditoProveedorListaDTO>> ListarCreditosProveedor(int idProveedor)
        {
            var response = await _apiClient.GetAsync<List<CreditoProveedorListaDTO>>(
                $"api/CreditosProveedor/ListarCreditosProveedor/{idProveedor}");

            return response.Value ?? new List<CreditoProveedorListaDTO>();
        }

        public async Task<CreditoProveedorDTO> VerCredito(int id)
        {
            var response = await _apiClient.GetAsync<CreditoProveedorDTO>(
                $"api/CreditosProveedor/VerCredito/{id}");

            return response.Value ?? new CreditoProveedorDTO();
        }

        public async Task<bool> AplicarCreditoCompra(AplicarCreditoCompraDTO credito)
        {
            var response = await _apiClient.PostAsync<bool>(
                "api/CreditosProveedor/AplicarCreditoCompra",
                credito);

            return response.Value;
        }
    }
}
