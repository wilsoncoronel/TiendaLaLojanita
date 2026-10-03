using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IDevolucionCompraService
    {
        Task<int> CrearDevolucionCompra(DevolucionCompraCreacionDTO devolucion);
        Task<List<TransaccionInventarioDTO>> ListaTransaccionesInventario();
    }
}
