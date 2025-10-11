using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class CompraEdicionValidator : AbstractValidator<CompraEditarDTO>
    {
        public CompraEdicionValidator()
        {
            RuleFor(x => x.IdProveedor)
                .GreaterThan(0).WithMessage("Debe seleccionar un proveedor.");
            RuleFor(x => x.Documento).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("El documento es obligatorio.")
                .NotNull().WithMessage("El documento no puede ser nulo.")
                .MaximumLength(50).WithMessage("El documento debe tener 50 carcateres.");
            RuleFor(x => x.FechaCompra).NotEmpty().WithMessage("La fecha de compra es obligatoria.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("La fecha de compra no puede ser mayor a la fecha actual.");
            RuleFor(x => x.IdEstado)
                .GreaterThan(0).WithMessage("Debe seleccionar un estado.");
            RuleFor(x => x.DetalleComprasEditarDto).NotEmpty().WithMessage("La compra debe tener al menos un detalle.");
        }
    }
}
