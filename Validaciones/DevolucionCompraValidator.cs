using FluentValidation;
using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Validaciones
{
    public class DevolucionCompraValidator: AbstractValidator<DevolucionCompraCreacionDTO>
    {
        public DevolucionCompraValidator()
        {
            RuleFor(x => x.IdCompra)
                .GreaterThan(0).WithMessage("Debe seleccionar una compra.");
            RuleFor(x => x.Estado)
                .InclusiveBetween(0, 1).WithMessage("El estado debe ser 0 o 1.");
            RuleFor(x => x.Motivo)
                .NotEmpty().WithMessage("El motivo es obligatorio.")
                .NotNull().WithMessage("El motivo no puede ser nulo.")
                .MaximumLength(500).WithMessage("El motivo no puede exceder los 500 caracteres.");
            
            // Validar propiedades de cada elemento del detalle
            RuleForEach(x => x.DetalleDevolucionCompraCreacionDTO).ChildRules(detalle =>
            {
                detalle.RuleFor(d => d.Cantidad)
                      .GreaterThan(0)
                      .WithMessage("La cantidad debe ser mayor a 0");
                detalle.RuleFor(d => d.IdDetalleCompra)
                      .GreaterThan(0)
                      .WithMessage("El IdDetalleCompra debe ser mayor a 0");
            });
        }
    }
}
