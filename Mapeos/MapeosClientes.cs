using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Mapeos
{
    public class MapeosClientes
    {
       public ClienteDTO MapeoClienteCreacionDtoAClienteDto(ClienteCreacionDTO clienteCreacionDto) {
            return new ClienteDTO
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
                Estado = clienteCreacionDto.Estado,
            }; 
       }
    }
}
