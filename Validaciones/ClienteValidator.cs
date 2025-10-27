using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class ClienteValidator: AbstractValidator<ClienteCreacionDTO>
    {

        public ClienteValidator()
        {
            RuleFor(x => x.Nombres)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .NotNull().WithMessage("El nombre no puede ser nulo.")
                .MaximumLength(500).WithMessage("El nombre no puede exceder los 500 caracteres.");

            RuleFor(x => x.Apellidos)
                .NotEmpty().WithMessage("El apellido es obligatorio.")
                .NotNull().WithMessage("El nombre no puede ser nulo.")
                .MaximumLength(500).WithMessage("El apellido no puede exceder los 500 caracteres.");
            RuleFor(x => x.IdTipoIdentificacion)
                .GreaterThan(0).WithMessage("Debe seleccionar un tipo de identificación.");
            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("El email es obligatorio.")
                .NotNull().WithMessage("El email no puede ser nulo.")
                .MaximumLength(100).WithMessage("El email o puede ser mayor a 100 carácteres!!");
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("El telefono es obligatorio.")
                .MaximumLength(10).WithMessage("El teléfono no puede superar los 10 carácteres!!");
            RuleFor(x => x.DireccionCreacionDto.IdCiudad)
                .GreaterThan(0).WithMessage("Debe seleccionar una ciudad.");
            RuleFor(x => x.DireccionCreacionDto.Descripcion)
                .NotEmpty().WithMessage("El apellido es obligatorio.")
                .NotNull().WithMessage("El nombre no puede ser nulo.")
                .MaximumLength(200).WithMessage("La direccion no puede superar los 200 carácteres!!");

        }
    }
}
