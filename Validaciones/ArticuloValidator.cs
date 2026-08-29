using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class ArticuloValidator: AbstractValidator<ArticuloCreacionDTO>
    {
        public ArticuloValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .NotNull().WithMessage("El nombre no puede ser nulo.")
                .MaximumLength(500).WithMessage("El nombre no puede exceder los 500 caracteres.");
            RuleFor(x=> x.IdImpuesto)
                .GreaterThan(0).WithMessage("Debe seleccionar un impuesto.");
            RuleFor(x => x.IdMarca)
                .GreaterThan(0).WithMessage("Debe seleccionar una marca."); 
            RuleFor(x => x.IdTipoArticulo)
                .GreaterThan(0).WithMessage("Debe seleccionar un tipo de articulo.");
            RuleFor(x => x.IdPorcentajeGanancia)
                .GreaterThan(0).WithMessage("Debe seleccionar un porcentaje de ganancia.");
            RuleFor(x => x.IdUnidad)
                .GreaterThan(0).WithMessage("Debe seleccionar una unidad de valor.");
            RuleFor(x => x.UnidadValor)
                .NotEmpty().WithMessage("La unidad valor es obligatorio.").GreaterThan(0).WithMessage("La unidadd valor debe ser mayor a 0");
            RuleFor(x => x.ValorCompra)
                .GreaterThan(0).WithMessage("El valor de compra debe ser mayor a 0");
        }
    }
}
