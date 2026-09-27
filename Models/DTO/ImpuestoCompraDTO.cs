namespace TiendaLaLojanita.Models.DTO
{
    public class ImpuestoCompraDTO
    {
        public int IdImpuesto { get; set; }
        public string NombreImpuesto { get; set; } = null!;
        public string TipoCalculo { get; set; } = null!;
        public decimal ValorConfigurado { get; set; }
        public decimal ValorImpuesto { get; set; }
    }
}