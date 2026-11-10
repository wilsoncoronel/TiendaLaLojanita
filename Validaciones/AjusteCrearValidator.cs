using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class AjusteCrearValidator: AbstractValidator<AjusteInventarioCrearDTO>
    {
        public AjusteCrearValidator()
        {
            RuleFor(x => x.Motivo).NotEmpty().WithMessage("El campo Motivo es obligatorio.");
            RuleFor(x => x.IdTransaccion).NotEmpty().WithMessage("El campo Transacción es obligatorio.");
            RuleFor(x => x.IdEstado).NotEmpty().WithMessage("El campo Estado es obligatorio.");
            RuleFor(x => x.Detalles).NotEmpty().WithMessage("El campo Detalle es obligatorio.");
        }
    }
}
