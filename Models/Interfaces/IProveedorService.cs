using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IProveedorService
    {
        Task<SriContribuyenteDTO> ConsultarRUC(string ruc, bool esProveedor);
        Task<ProveedorDTO> ObtenerProveedorCI(string identificacion, bool verPersona);
        Task<int> CrearProveedor(ProveedorCreacionDTO proveedorCreacionDto);
        Task<bool> EditarProveedor(ProveedorEditarDTO proveedorEditarDTO);
        Task<List<TipoIdentificacionDTO>> ListarTiposIdentificacion();
        Task<List<CiudadDTO>> ListarCiudades();
        Task<List<ProveedorDTO>> ListarProveedores();
    }
}
