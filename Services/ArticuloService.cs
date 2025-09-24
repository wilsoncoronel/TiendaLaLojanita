using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class ArticuloService : IArticuloService
    {
        public Task<int> CrearArticulo(ArticuloCreacionDTO articuloDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DesactivarArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarArticulo(ArticuloEdicionDTO articuloEdicionDTO)
        {
            throw new NotImplementedException();
        }
    }
}
