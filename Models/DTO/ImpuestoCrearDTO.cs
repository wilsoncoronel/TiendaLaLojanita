using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models.DTO
{
    public class ImpuestoCrearDTO
    {
        public string Nombre { get; set; } = null!;

        public int IdTipoCalculo { get; set; }

        public decimal Valor { get; set; }

        public bool Estado { get; set; }
    }
}
