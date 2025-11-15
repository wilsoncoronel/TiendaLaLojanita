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
        private readonly HttpClient _httpClient;

        public ImpuestoService(IHttpClientFactory httpClient)
        {
            this._httpClient = httpClient.CreateClient("ApiClient");
        }
        public async Task<int> CrearImpuesto(ImpuestoArticuloCreacionDTO impuestoCreacionDto)
        {
            string json = JsonConvert.SerializeObject(impuestoCreacionDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this._httpClient.PostAsync($"api/Configuraciones/CrearImpuesto", content);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<int> result = JsonConvert.DeserializeObject<Response<int>>(responseJson);
            return result.Value;
        }

        public async Task<bool> EditarImpuesto(ImpuestoArticuloEditarDTO impuestoEditarDto)
        {
            string json = JsonConvert.SerializeObject(impuestoEditarDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this._httpClient.PutAsync($"api/Configuraciones/EditarImpuesto", content);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<bool> result = JsonConvert.DeserializeObject<Response<bool>>(responseJson);
            return result.Value;
        }

        public async Task<List<EstadoImpuestoDTO>> ListarEstadosImpuestos()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"api/Configuraciones/ListarEstados");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();
                Response<List<EstadoImpuestoDTO>> result = JsonConvert.DeserializeObject<Response<List<EstadoImpuestoDTO>>>(responseJson);
                return result.Value;
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<ImpuestoArticuloDTO>> ListarImpuestos()
        {
            HttpResponseMessage response = await this._httpClient.GetAsync($"api/Configuraciones/ListarImpuestosArticulos");
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            Response<List<ImpuestoArticuloDTO>> result = JsonConvert.DeserializeObject<Response<List<ImpuestoArticuloDTO>>>(responseJson);
            return result.Value;
        }
    }
}
