using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> ObtenerClienteCI(string identificacion);

        Task<int> CrearCliente(ClienteCreacionDTO clienteCreacionDto);
        Task<bool> EditarCliente(ClienteEditarDTO clienteEditarDto);
        Task<List<TipoIdentificacionDTO>> ListarTiposIdentificacion();

        Task<List<CiudadDTO>> ListarCiudades();
        Task<List<ClienteDTO>> ListarClientes();
    }
}