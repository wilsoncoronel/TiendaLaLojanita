using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IArticuloService
    {
        Task<int> CrearArticulo(ArticuloCreacionDTO articuloDto);
        Task<bool> CrearArticuloLista(List<ArticuloCreacionDTO> listaArticulosDto);
        Task<bool> EditarArticulo(ArticuloEdicionDTO articuloEdicionDTO);
        Task<bool> DesactivarArticulo(int id);
        Task<List<TipoArticuloDTO>> ListaTipoArticulo();
        Task<List<ImpuestoArticuloDTO>> ListaImpuestoArticulo();
        Task<List<MarcaDTO>> ListaMarcaArticulo();
        Task<List<ArticuloDTO>> ListaArticulos(DateOnly fechaInicial, DateOnly fechaFinal);
        Task<List<ArticuloDTO>> ListaCodigosArticulos(int idArticulo);
        Task<List<ArticuloDTO>> ListarTodosArticulos();
    }
}
