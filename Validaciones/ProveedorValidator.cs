using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class ProveedorValidator: AbstractValidator<ProveedorCreacionDTO>
    {
        public ProveedorValidator()
        {
            RuleFor(x => x.Nombres)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .NotNull().WithMessage("El nombre no puede ser nulo.")
                .MaximumLength(500).WithMessage("El nombre no puede exceder los 500 caracteres.");

            RuleFor(x => x.Apellidos)
                .NotEmpty().WithMessage("El apellido es obligatorio.")
                .NotNull().WithMessage("El nombre no puede ser nulo.")
                .MaximumLength(500).WithMessage("El apellido no puede exceder los 500 caracteres.");
            RuleFor(x => x.RazonSocial)
                .NotEmpty().WithMessage("La razón social es obligatoria.")
                .NotNull().WithMessage("La razón social no puede ser nulla.")
                .MaximumLength(250).WithMessage("El apellido no puede exceder los 250 caracteres.");
            RuleFor(x => x.IdIdentificacion)
                .GreaterThan(0).WithMessage("Debe seleccionar un tipo de identificación.");
            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("El email es obligatorio.")
                .NotNull().WithMessage("El email no puede ser nulo.")
                .MaximumLength(200).WithMessage("El email o puede ser mayor a 100 carácteres!!");
            RuleFor(x => x.Identificacion)
                .NotEmpty().WithMessage("La identificación es obligatoria.")
                .NotNull().WithMessage("La identificación no puede ser nulo.")
                .MaximumLength(15).WithMessage("La identifiación no puede ser mayor a 15 carácteres!!")
                .MinimumLength(10).WithMessage("La identificación no puede ser menor a 10 carácteres!!");
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("El teléfono es obligatorio.")
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
