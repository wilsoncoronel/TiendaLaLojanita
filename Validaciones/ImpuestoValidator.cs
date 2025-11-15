using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class ImpuestoValidator: AbstractValidator<ImpuestoArticuloCreacionDTO>
    {
        public ImpuestoValidator()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEmpty()
                .WithMessage($"El nombre no puede ser nulo o estar vacio!!");
            RuleFor(x => x.ValorImpuesto)
                .NotNull()
                .WithMessage($"El valor no puede ser nulo!!");
            RuleFor(x => x.IdEstadoImpuesto)
                .NotNull()
                .WithMessage($"Debe seleccionar un estado!!");
        }
    }
}
