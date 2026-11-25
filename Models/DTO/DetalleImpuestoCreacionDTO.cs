namespace TiendaLaLojanita.Models.DTO
{
    public class DetalleImpuestoCreacionDTO
    {
        public int IdImpuesto { get; set; }
        public int IdArticulo { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdTipoCalculo { get; set; }
        public decimal Valor { get; set; }
    }
}
