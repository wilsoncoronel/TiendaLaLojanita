using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class MarcaValidator: AbstractValidator<MarcaCreacionDTO>
    {
        public MarcaValidator()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEmpty()
                .WithMessage($"El nombre no puede ser nulo o estar vacio!!");
            RuleFor(x => x.EstadoVisual)
                .NotNull()
                .WithMessage($"El estado visual no puede ser nulo!!");
        }
    }
}
