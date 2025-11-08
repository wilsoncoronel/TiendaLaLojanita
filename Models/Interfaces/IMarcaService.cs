using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IMarcaService
    {
        Task<int> CrearMarca(MarcaCreacionDTO marcaCreacionDto);
        Task<bool> EditarMarca(MarcaEditarDTO clienteEditarDto);
        Task<List<MarcaDTO>> ListarMarcas();
    }
}
