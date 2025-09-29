using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface ICompraService
    {
        Task<int> RegistrarCompra(CompraCreacionDTO compraDto);
        Task<bool> EditarCompra(CompraEditarDTO compraDto);
        Task<List<CompraMinDTO>> ListarCompras(DateOnly fechaInicial, DateOnly fechaFinal);
        Task<CompraDTO> ObtenerCompra(int idCompra);
        Task<bool> ReversarCompra(int id);
    }
}