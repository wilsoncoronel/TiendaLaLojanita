using SistemaTienda.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Services
{
    public class DevolucionCompraService : IDevolucionCompraService
    {
        private readonly ApiClient apiClient;

        public DevolucionCompraService(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
        public async Task<int> CrearDevolucionCompra(DevolucionCompraCreacionDTO devolucion)
        {
            var response = await this.apiClient.PostAsync<int>("api/DevolucionCompra/CrearDevolucionCompra", devolucion);
            return response.Value;
        }
    }
}
