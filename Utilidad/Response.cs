using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Models
{
    public class Response<T>
    {
        public bool status { get; set; }
        public T Value { get; set; }
        public string msg { get; set; }
    }
}
