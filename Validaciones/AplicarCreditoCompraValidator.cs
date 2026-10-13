using FluentValidation;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Validaciones
{
    public class AplicarCreditoCompraValidator : AbstractValidator<AplicarCreditoCompraDTO>
    {
        public AplicarCreditoCompraValidator()
        {
            RuleFor(x => x.IdCreditoProveedor)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un crédito de proveedor válido.");

            RuleFor(x => x.IdCompra)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una compra válida.");

            RuleFor(x => x.Valor)
                .GreaterThan(0)
                .WithMessage("El valor a aplicar debe ser mayor que cero.");
        }
    }
}
