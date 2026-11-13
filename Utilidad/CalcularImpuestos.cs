using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Utilidad
{
    public static class CalcularImpuestos
    {
        public static decimal Calcular(int idTipoCalculo, decimal valorCompra, decimal cantidad, decimal valorConfigurado, IEnumerable<TipoImpuestoDTO> tiposImpuesto)
        {
            var tipoImpuesto = tiposImpuesto.FirstOrDefault(t => t.Id == idTipoCalculo)
                ?? throw new InvalidOperationException($"No existe un TipoImpuesto con Id {idTipoCalculo}.");

            return Calcular(tipoImpuesto, valorCompra, cantidad, valorConfigurado);
        }

        public static decimal Calcular(TipoImpuestoDTO tipoImpuesto, decimal valorCompra, decimal cantidad, decimal valorConfigurado)
        {
            if (tipoImpuesto == null)
            {
                throw new InvalidOperationException("El impuesto no tiene TipoImpuesto cargado.");
            }

            if (string.Equals(tipoImpuesto.TipoCalculo?.Trim(), "PORCENTAJE", StringComparison.OrdinalIgnoreCase))
            {
                return CalcularPorcentaje(valorCompra, cantidad, valorConfigurado);
            }

            if (string.Equals(tipoImpuesto.TipoCalculo?.Trim(), "UNIDAD", StringComparison.OrdinalIgnoreCase))
            {
                return CalcularUnidad(cantidad, valorConfigurado);
            }

            return 0m;
        }

        public static decimal CalcularPorcentaje(decimal valorCompra, decimal cantidad, decimal valorConfigurado)
        {
            return valorCompra * cantidad * valorConfigurado;
        }

        public static decimal CalcularUnidad(decimal cantidad, decimal valorConfigurado)
        {
            return valorConfigurado * cantidad;
        }

        /*public static ImpuestoArticuloCalculadoDTO CrearDetalle(
            ArticuloDTO articulo,
            ArticuloImpuestoMinDTO impuesto,
            decimal valorCompra,
            decimal cantidad,
            int id)
        {
            var impuestoDto = impuesto.ImpuestoDTO;
            var tipoCalculo = impuestoDto?.TipoCalculo ?? string.Empty;
            var valorConfigurado = impuestoDto?.Valor ?? 0m;

            return new ImpuestoArticuloCalculadoDTO
            {
                Id = id,
                IdArticulo = articulo.Id,
                IdImpuesto = impuesto.IdImpuesto,
                NombreImpuesto = impuestoDto?.Nombre ?? string.Empty,
                TipoImpuesto = tipoCalculo,
                ValorConfigurado = valorConfigurado,
                ValorCompra = valorCompra,
                Cantidad = cantidad,
                ValorImpuesto = Calcular(tipoCalculo, valorCompra, valorConfigurado)
            };
        }*/

    }
}