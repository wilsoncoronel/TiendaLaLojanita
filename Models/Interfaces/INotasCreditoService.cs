using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface INotasCreditoService
    {
        Task<List<CreditoProveedorDTO>> ListarNotasCreditoProveedor(int idProveedor);
    }
}
