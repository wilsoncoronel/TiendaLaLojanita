using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class ExcelArticuloValidator : AbstractValidator<ArticuloCreacionDTO>
    {
        public ExcelArticuloValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio para la importación.")
                .MaximumLength(500).WithMessage("El nombre no puede exceder los 500 caracteres.");

            RuleFor(x => x.IdImpuesto)
                .GreaterThan(0).WithMessage("Debe indicar un IdImpuesto válido para la importación.");

            RuleFor(x => x.IdMarca)
                .GreaterThan(0).WithMessage("Debe indicar un IdMarca válido para la importación.");
            RuleFor(x => x.IdPorcentajeGanancia)
                .GreaterThan(0).WithMessage("Debe indicar un IdPorcentaje válido para la importación.");

            RuleFor(x => x.IdTipoArticulo)
                .GreaterThan(0).WithMessage("Debe indicar un IdTipoArticulo válido para la importación.");

            RuleFor(x => x.IdUnidad)
                .GreaterThan(0).WithMessage("Debe indicar una unidad de medida válido para la importación.");

            RuleFor(x => x.UnidadValor)
                .GreaterThan(0).WithMessage("La unidad valor debe ser mayor que 0 para la importación.");

            RuleFor(x => x.ValorCompra)
                .GreaterThan(0).WithMessage("El valor de compra debe ser mayor que 0 para la importación.");

            RuleFor(x => x.ValorVenta)
                .GreaterThanOrEqualTo(0).WithMessage("El valor de venta debe ser mayor o igual a 0.");
        }

        /// <summary>
        /// Valida un artículo combinando reglas FluentValidation y comprobaciones de existencia
        /// en los catálogos cargados (marcas, tipos, impuestos, porcentajes).
        /// Devuelve la lista de mensajes de error encontrados (vacía si es válido).
        /// </summary>
        public (List<string> Errores, List<string> CamposInvalidos) ValidateArticulo(ArticuloCreacionDTO art, IEnumerable<MarcaDTO> marcas, IEnumerable<TipoArticuloDTO> tipos, IEnumerable<ImpuestoArticuloDTO> impuestos, IEnumerable<PorcentajeGananciaDTO> porcentajes)
        {
            var errores = new List<string>();
            var camposInvalidos = new List<string>();

            var resultado = this.Validate(art);
            if (!resultado.IsValid)
            {
                errores.AddRange(resultado.Errors.Select(e => e.ErrorMessage));
                camposInvalidos.AddRange(resultado.Errors.Select(e => e.PropertyName).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct());
            }

            if (!marcas.Any(m => m.Id == art.IdMarca))
            {
                errores.Add("Marca no encontrada o IdMarca inválido.");
                camposInvalidos.Add(nameof(art.IdMarca));
            }
            if (!tipos.Any(t => t.Id == art.IdTipoArticulo))
            {
                errores.Add("Tipo de artículo no encontrado o IdTipoArticulo inválido.");
                camposInvalidos.Add(nameof(art.IdTipoArticulo));
            }
            if (!impuestos.Any(i => i.Id == art.IdImpuesto))
            {
                errores.Add("Impuesto no encontrado o IdImpuesto inválido.");
                camposInvalidos.Add(nameof(art.IdImpuesto));
            }
            if (art.IdPorcentajeGanancia.HasValue && !porcentajes.Any(p => p.Id == art.IdPorcentajeGanancia.Value))
            {
                errores.Add("Porcentaje de ganancia no encontrado o IdPorcentaje inválido.");
                camposInvalidos.Add(nameof(art.IdPorcentajeGanancia));
            }

            // Asegurar que no haya duplicados en campos inválidos
            camposInvalidos = camposInvalidos.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

            return (errores, camposInvalidos);
        }
    }
}
