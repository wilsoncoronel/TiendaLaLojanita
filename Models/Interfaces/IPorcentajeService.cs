using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IPorcentajeService
    {
        Task<int> CrearPorcentaje(PorcentajeGananciaCreacionDTO porcentajeCreacionDto);
        Task<bool> EditarPorcentaje(PorcentajeGananciaDTO porcentajeEditarDto);
        Task<List<PorcentajeGananciaDTO>> ListarPorcentajes();
    }
}
