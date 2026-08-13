using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class PorcentajeValidator: AbstractValidator<PorcentajeGananciaCreacionDTO>
    {
        public PorcentajeValidator()
        {
            RuleFor(x => x.PorcentajeGanancia)
                .NotEmpty().WithMessage("El porcentaje de ganancia es obligatorio.")
                .NotNull().WithMessage("El porcentaje de ganancia no puede ser nulo.")
                .MaximumLength(500).WithMessage("El porcentaje de ganancia no puede exceder los 500 caracteres.");
            RuleFor(x => x.Valor)
                .GreaterThan(0).WithMessage("El valor del porcentaje debe ser positivo.");
            
        }
    }
}
