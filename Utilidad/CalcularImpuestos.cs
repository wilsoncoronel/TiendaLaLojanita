using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Utilidad
{
    public static class CalcularImpuestos
    {
        public static decimal Calcular(string? tipoCalculo, decimal valorCompra, decimal cantidad, decimal valorConfigurado)
        {
            if (string.Equals(tipoCalculo?.Trim(), "PORCENTAJE", StringComparison.OrdinalIgnoreCase))
            {
                return valorCompra * cantidad * valorConfigurado;
            }

            if (string.Equals(tipoCalculo?.Trim(), "UNIDAD", StringComparison.OrdinalIgnoreCase))
            {
                return valorConfigurado * cantidad;
            }

            return 0m;
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