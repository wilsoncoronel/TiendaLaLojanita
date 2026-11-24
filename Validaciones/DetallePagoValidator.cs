using FluentValidation;
using SistemaTienda.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class DetallePagoValidator : AbstractValidator<DetallePagoCreacionDTO>
    {
        public DetallePagoValidator()
        {
            RuleFor(x => x.IdPagoVenta)
                .GreaterThan(0)
                .WithMessage("El pago de la venta es obligatorio.");

            RuleFor(x => x.IdTipoPago)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de pago.");

            RuleFor(x => x.Valor)
                .GreaterThan(0)
                .WithMessage("El valor del pago debe ser mayor que cero.")
                .PrecisionScale(18, 2, true)
                .WithMessage("El valor del pago no puede tener más de dos decimales.");

            RuleFor(x => x.FechaPago)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("La fecha de pago no puede ser futura.");
        }
    }
}
