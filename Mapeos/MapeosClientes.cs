using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Mapeos
{
    public interface IMapeosClientes
    {
        ClienteDTO MapeoClienteCreacionDtoAClienteDto(ClienteCreacionDTO clienteCreacionDto);
        ClienteDTO MapeoClienteEdicionDtoAClienteDto(ClienteEditarDTO clienteEditarDto);
    }

    public class MapeosClientes : IMapeosClientes
    {
        public ClienteDTO MapeoClienteCreacionDtoAClienteDto(ClienteCreacionDTO clienteCreacionDto)
        {
            var cliente = new ClienteDTO
            {
                Nombres = clienteCreacionDto.Nombres,
                Apellidos = clienteCreacionDto.Apellidos,
                Telefono = clienteCreacionDto.Telefono,
                Mail = clienteCreacionDto.Mail,
                DireccionDto = new DireccionDTO
                {
                    Descripcion = clienteCreacionDto.DireccionCreacionDto.Descripcion,
                    IdCiudad = clienteCreacionDto.DireccionCreacionDto.IdCiudad,
                },
                TipoIdentificacionDto = new TipoIdentificacionDTO
                {
                    Id = clienteCreacionDto.IdTipoIdentificacion,
                },
                Identificacion = clienteCreacionDto.Identificacion,
                Estado = clienteCreacionDto.Estado,
            };
            return cliente;
        }

        public ClienteDTO MapeoClienteEdicionDtoAClienteDto(ClienteEditarDTO clienteEditarDto) {
            return new ClienteDTO
            {
                Id = clienteEditarDto.Id,
                Nombres = clienteEditarDto.Nombres,
                Apellidos = clienteEditarDto.Apellidos,
                Telefono = clienteEditarDto.Telefono,
                Mail = clienteEditarDto.Mail,
                DireccionDto = new DireccionDTO
                {
                    Descripcion = clienteEditarDto.DireccionEdicionDto.Descripcion,
                    IdCiudad = clienteEditarDto.DireccionEdicionDto.IdCiudad,
                },
                TipoIdentificacionDto = new TipoIdentificacionDTO
                {
                    Id = clienteEditarDto.IdTipoIdentificacion,
                },
                Estado = clienteEditarDto.Estado,
            };
        }
    }
}
