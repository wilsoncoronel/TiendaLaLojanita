using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IArticuloService
    {
        Task<int> CrearArticulo(ArticuloCreacionDTO articuloDto);
        Task<bool> EditarArticulo(ArticuloEdicionDTO articuloEdicionDTO);
        Task<bool> DesactivarArticulo(int id);
    }
}
