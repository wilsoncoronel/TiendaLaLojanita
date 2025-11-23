using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IInventarioService
    {
        Task<List<ExistenciaDTO>> ExistenciasInventario();
        Task<List<TransaccionInventarioDTO>> ListaTransaccionesInventario();
        Task<List<InventarioDTO>> ListaInventario(DateOnly Inicio, DateOnly Fin);
        Task<List<DetalleInventarioDTO>> ListaDetallesInventario(int IdInventario);
        Task<int> CrearTransaccionInventario(InventarioCreacionDTO traInventario);
        Task<List<ResumenVentasDiarioDTO>> ResumenVentasDiario(DateTime fechaResumen);
        Task<List<ResumenVentasDiarioDTO>> ResumenVentasMensual(DateTime fechaResumen);
    }
}
