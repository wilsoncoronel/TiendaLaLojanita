using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class VentaValidator:AbstractValidator<VentaCreacionDTO>
    {
        public VentaValidator()
        {
            RuleFor(x => x.IdCliente)
                .GreaterThan(0).WithMessage("Debe seleccionar un cliente.");
            RuleFor(x => x.FechaCompra).NotEmpty().WithMessage("La fecha de venta es obligatoria.")
                    .LessThanOrEqualTo(DateTime.Now).WithMessage("La fecha de venta no puede ser mayor a la fecha actual.");
            RuleFor(x => x.IdEstado)
                    .GreaterThan(0).WithMessage("Debe seleccionar un estado.");
            RuleFor(x => x.DetalleVenta).NotEmpty().WithMessage("La venta debe tener al menos un detalle.");

        }
    }
}
