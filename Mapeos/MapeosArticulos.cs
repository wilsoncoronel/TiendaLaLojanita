using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Mapeos
{
    public interface IMapeosArticulos
    {
        ArticuloEdicionDTO MapeoArticuloDtoAArticuloEdionDto(ArticuloDTO articuloDto);
        ArticuloDTO MapeoArticuloEdionDtoAArticuloDto(ArticuloEdicionDTO articuloDto);
        ArticuloDTO MapeoArticuloCreacionDtoAArticuloDto(ArticuloCreacionDTO articuloDto);
    }

    public class MapeosArticulos : IMapeosArticulos
    {
        public ArticuloEdicionDTO MapeoArticuloDtoAArticuloEdionDto(ArticuloDTO articuloDto)
        {
            return new ArticuloEdicionDTO
            {
                Id = articuloDto.Id,
                IdMarca = articuloDto.IdMarca,
                IdTipoArticulo = articuloDto.IdTipoArticulo,
                IdImpuesto = articuloDto.IdImpuesto,
                Nombre = articuloDto.Nombre,
                Codigo = articuloDto.Codigo,
                FechaCaducidad = articuloDto.FechaCaducidad,
                EstadoVisual = articuloDto.EstadoVisual,
                Estado = articuloDto.Estado,
                Descripcion = articuloDto.Descripcion,
                FechaActualizacion = DateTime.Now,
                Unidad = articuloDto.Unidad,
                UnidadValor = articuloDto.UnidadValor,
                ValorCompra = articuloDto.ValorCompra,
                ValorVenta = articuloDto.ValorVenta,
                Papeleria = articuloDto.Papeleria
            };
        }

        public ArticuloDTO MapeoArticuloEdionDtoAArticuloDto(ArticuloEdicionDTO articuloDto)
        {
            return new ArticuloDTO
            {
                Id = articuloDto.Id,
                IdMarca = articuloDto.IdMarca,
                IdTipoArticulo = articuloDto.IdTipoArticulo,
                IdImpuesto = articuloDto.IdImpuesto,
                Nombre = articuloDto.Nombre,
                Codigo = Convert.ToString(articuloDto.Id),
                FechaCaducidad = articuloDto.FechaCaducidad,
                EstadoVisual = articuloDto.EstadoVisual,
                Estado = articuloDto.Estado,
                Descripcion = articuloDto.Descripcion,
                FechaActualizacion = DateTime.Now,
                Unidad = articuloDto.Unidad,
                UnidadValor = articuloDto.UnidadValor,
                ValorCompra = articuloDto.ValorCompra,
                ValorVenta = articuloDto.ValorVenta,
                Papeleria = articuloDto.Papeleria
            };
        }

        public ArticuloDTO MapeoArticuloCreacionDtoAArticuloDto(ArticuloCreacionDTO articuloDto)
        {
            return new ArticuloDTO {
                IdMarca = articuloDto.IdMarca,
                IdTipoArticulo = articuloDto.IdTipoArticulo,
                IdImpuesto = articuloDto.IdImpuesto,
                Nombre = articuloDto.Nombre,
                FechaCreacion = DateTime.Now,
                FechaCaducidad = articuloDto.FechaCaducidad,
                EstadoVisual = articuloDto.EstadoVisual,
                Estado = articuloDto.Estado,
                Descripcion = articuloDto.Descripcion,
                FechaActualizacion = DateTime.Now,
                Unidad = articuloDto.Unidad,
                UnidadValor = articuloDto.UnidadValor,
                ValorCompra = articuloDto.ValorCompra,
                ValorVenta = articuloDto.ValorVenta,
                Papeleria = articuloDto.Papeleria,
            };
        }
    }
}
