using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Mapeos
{
    public interface IMapeoProveedor
    {
        ProveedorDTO MapeoProveedorCreacionDtoAProveedorDto(ProveedorCreacionDTO proveedorCreacionDTO);
        ProveedorDTO MapeoProveedorEditarDtoAProveedorDto(ProveedorEditarDTO proveedorEditarDTO);
    }

    public class MapeoProveedor : IMapeoProveedor
    {
        public ProveedorDTO MapeoProveedorCreacionDtoAProveedorDto(ProveedorCreacionDTO proveedorCreacionDTO)
        {
            return new ProveedorDTO
            {
                Nombres = proveedorCreacionDTO.Nombres,
                Apellidos = proveedorCreacionDTO.Apellidos,
                IdIdentificacion = proveedorCreacionDTO.IdIdentificacion,
                Mail = proveedorCreacionDTO.Mail,
                Identificacion = proveedorCreacionDTO.Identificacion,
                Telefono = proveedorCreacionDTO.Telefono,
                EstadoVisual = proveedorCreacionDTO.EstadoVisual,
                Estado = proveedorCreacionDTO.Estado,
                RazonSocial = proveedorCreacionDTO.RazonSocial,
                Descripcion = proveedorCreacionDTO.Descripcion,
                DireccionDto = new DireccionDTO
                {
                    Descripcion = proveedorCreacionDTO.DireccionCreacionDto.Descripcion,
                    IdCiudad = proveedorCreacionDTO.DireccionCreacionDto.IdCiudad,
                    EstadoVisual = true
                }
            };
        }

        public ProveedorDTO MapeoProveedorEditarDtoAProveedorDto(ProveedorEditarDTO proveedorEditarDTO)
        {
            return new ProveedorDTO
            {
                Id = proveedorEditarDTO.Id,
                Nombres = proveedorEditarDTO.Nombres,
                Apellidos = proveedorEditarDTO.Apellidos,
                IdIdentificacion = proveedorEditarDTO.IdIdentificacion,
                TipoIdentificacionDto = new TipoIdentificacionDTO
                {
                    Id = proveedorEditarDTO.IdIdentificacion
                },
                Mail = proveedorEditarDTO.Mail,
                Identificacion = proveedorEditarDTO.Identificacion,
                Telefono = proveedorEditarDTO.Telefono,
                EstadoVisual = proveedorEditarDTO.EstadoVisual,
                Estado = proveedorEditarDTO.Estado,
                RazonSocial = proveedorEditarDTO.RazonSocial,
                Descripcion = proveedorEditarDTO.Descripcion,
                DireccionDto = new DireccionDTO
                {
                    Descripcion = proveedorEditarDTO.DireccionEdicionDto.Descripcion,
                    IdCiudad = proveedorEditarDTO.DireccionEdicionDto.IdCiudad,
                    EstadoVisual = true
                },
                FechaModificacion = proveedorEditarDTO.FechaModificacion 
            };
        }
    }
}
