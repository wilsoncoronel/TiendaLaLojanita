using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IUnidadService
    {
        Task<int> CreaUnidad(UnidadMedidaDTO marcaCreacionDto);
        Task<bool> EditarUnidad(UnidadEditarDTO clienteEditarDto);
        Task<List<UnidadMedidaDTO>> ListarUnidades();
    }
}
