using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    internal class ImpuestoService : IImpuestoService
    {
        private readonly ApiClient _apiClient;

        public ImpuestoService(ApiClient apiClient)
        {
            this._apiClient = apiClient;
        }
        public async Task<int> CrearImpuesto(ImpuestoArticuloCreacionDTO impuestoCreacionDto)
        {
            
            var response = await this._apiClient.PostAsync<int>($"api/Configuraciones/CrearImpuesto", impuestoCreacionDto);
            return response.Value;
        }

        public async Task<bool> EditarImpuesto(ImpuestoArticuloEditarDTO impuestoEditarDto)
        {
            var response = await this._apiClient.PutAsync<bool>($"api/Configuraciones/EditarImpuesto", impuestoEditarDto);
            return response.Value;
        }

        public async Task<List<EstadoImpuestoDTO>> ListarEstadosImpuestos()
        {
            var response = await _apiClient.GetAsync<List<EstadoImpuestoDTO>>($"api/Configuraciones/ListarEstados");
            return response.Value;
        }

        public async Task<List<ImpuestoArticuloDTO>> ListarImpuestos()
        {
            var response = await this._apiClient.GetAsync<List<ImpuestoArticuloDTO>>($"api/Configuraciones/ListarImpuestosArticulos");
            return response.Value;
        }
    }
}
