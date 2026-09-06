using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class UnidadCreacionValidator: AbstractValidator<UnidadCreacionDTO>
    {
        public UnidadCreacionValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre de la unidad es obligatorio.")
                .NotNull().WithMessage("El nombre de la unidad no puede ser nulo.")
                .MaximumLength(500).WithMessage("El nombre de la unidad no puede exceder los 10 caracteres.");
        }
    }
}
