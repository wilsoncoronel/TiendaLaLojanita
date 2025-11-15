using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Models.Interfaces
{
    public interface IImpuestoService
    {
        Task<int> CrearImpuesto(ImpuestoArticuloCreacionDTO impuestoCreacionDto);
        Task<bool> EditarImpuesto(ImpuestoArticuloEditarDTO impuestoEditarDto);
        Task<List<ImpuestoArticuloDTO>> ListarImpuestos();
        Task<List<EstadoImpuestoDTO>> ListarEstadosImpuestos();
    }
}
