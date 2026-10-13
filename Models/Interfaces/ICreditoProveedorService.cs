using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface ICreditoProveedorService
    {
        Task<List<CreditoProveedorListaDTO>> ListarCreditosProveedor(int idProveedor);
        Task<CreditoProveedorDTO> VerCredito(int id);
        Task<bool> AplicarCreditoCompra(AplicarCreditoCompraDTO credito);
    }
}
