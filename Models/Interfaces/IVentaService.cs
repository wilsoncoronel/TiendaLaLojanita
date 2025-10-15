using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IVentaService
    {
        Task<int> RegistrarVenta(VentaCreacionDTO ventaDto);
        Task<bool> EditarVenta(VentaEditarDTO ventaDto);
        Task<List<VentaMinDTO>> ListarVenta(DateOnly fechaInicial, DateOnly fechaFinal);
        Task<VentaDTO> ObtenerVenta(int idVenta);
        Task<bool> ReversarVenta(int id);
        Task<List<EstadoVentaDTO>> ListarEstadosVenta();
    }
}
