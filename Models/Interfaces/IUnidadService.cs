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
        Task<int> CreaUnidad(UnidadMedidaDTO unidadCrearDto);
        Task<bool> EditarUnidad(UnidadMedidaDTO unidadEditarDto);
        Task<List<UnidadMedidaDTO>> ListarUnidades();
    }
}
