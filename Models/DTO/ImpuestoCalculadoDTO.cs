using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ImpuestoCalculadoDTO
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public decimal ValorImpuesto { get; set; }
    }
}
