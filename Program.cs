using Microsoft.Extensions.DependencyInjection;
using TiendaLaLojanita.Controllers;
using TiendaLaLojanita.Models.Interfaces;
using System.Net.Http.Headers;
using TiendaLaLojanita.Services;
using TiendaLaLojanita.Views;
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
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<FrmLoggin>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddHttpClient("ApiClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7168/");
                client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json")
                    );
            });
            services.AddScoped<ILogginService, LogginService>().AddScoped<FrmLoggin>();
            services.AddScoped<IArticuloService, ArticuloService>().AddScoped<Registro_Articulos>();
        }
    }
}