using Microsoft.Extensions.DependencyInjection;
using TiendaLaLojanita.Controllers;
using TiendaLaLojanita.Models.Interfaces;
using System.Net.Http.Headers;
using TiendaLaLojanita.Services;
using TiendaLaLojanita.Views;
using TiendaLaLojanita.Mapeos;
using TiendaLaLojanita.Utilidad;
namespace TiendaLaLojanita
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = new FrmLoggin(serviceProvider);
                Application.Run(form1);
            }
        }
        private static void Application_ThreadException(
        object sender,
        ThreadExceptionEventArgs e)
        {
            ManejarExcepcion(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(
        object sender,
        UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                ManejarExcepcion(ex);
            }
        }
        private static void ManejarExcepcion(Exception ex)
        {
            string mensaje;

            if (ex is NullReferenceException)
            {
                mensaje =
                    "Se produjo un error al intentar acceder a un objeto " +
                    "que no está disponible.\n\n" +
                    "Verifique los datos e intente nuevamente.";
            }
            else if (ex is InvalidOperationException)
            {
                mensaje =
                    "La operación solicitada no puede realizarse en el estado actual.";
            }
            else
            {
                mensaje =
                    "Ocurrió un error inesperado en la aplicación.";
            }

            MessageBox.Show(
                mensaje,
                "Error de aplicación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddHttpClient("ApiClient", client =>

            {

                client.BaseAddress = new Uri("https://localhost:7168/");
                /*client.BaseAddress = new Uri("http://localhost:93" +
                    "/");*/
                client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json")
                    );
                client.Timeout = TimeSpan.FromSeconds(30);
            });
            services.AddScoped<ApiClient>();
            services.AddScoped<ILogginService, LogginService>();
            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<ITiposArticulosService, TiposArticulosService>();
            services.AddScoped<IImpuestoService, ImpuestoService>();
            services.AddScoped<IPorcentajeService, PorcentajeService>();
            services.AddScoped<IArticuloService, ArticuloService>();
            services.AddScoped<IMapeosArticulos, MapeosArticulos>();
            services.AddScoped<IMapeosClientes, MapeosClientes>();
            services.AddScoped<ICompraService, CompraService>();
            services.AddScoped<IProveedorService, ProveedorService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IVentaService, VentaService>();
            services.AddScoped<IInventarioService, InventarioService>();
            services.AddScoped<IMapeoProveedor, MapeoProveedor>();
            services.AddScoped<IProcesarExcel, ProcesarExcel>();
            services.AddScoped<FrmPrincipal>();
            services.AddScoped<Registro_Articulos>();
            services.AddScoped<Registro_Ventas>();
            services.AddScoped<Registro_Compras>();
            services.AddScoped<Inventario>();
            services.AddScoped<Cliente>();
            services.AddScoped<Proveedor>();
            services.AddScoped<DatosConfiguraciones>();
            services.AddScoped<Devolucion_Venta>();
        }
    }
}