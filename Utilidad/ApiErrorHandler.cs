using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Utilidad
{
    public class ApiErrorHandler
    {
        public static void Mostrar(ApiException ex)
        {
            string titulo;
            MessageBoxIcon icono;

            if (ex.StatusCode == null)
            {
                titulo = "Error de conexión";
                icono = MessageBoxIcon.Error;
            }
            else
            {
                switch (ex.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        titulo = "Solicitud incorrecta";
                        icono = MessageBoxIcon.Warning;
                        break;

                    case HttpStatusCode.Unauthorized:
                        titulo = "Autenticación";
                        icono = MessageBoxIcon.Warning;
                        break;

                    case HttpStatusCode.Forbidden:
                        titulo = "Acceso denegado";
                        icono = MessageBoxIcon.Warning;
                        break;

                    case HttpStatusCode.NotFound:
                        titulo = "No encontrado";
                        icono = MessageBoxIcon.Information;
                        break;

                    case HttpStatusCode.Conflict:
                        titulo = "Conflicto";
                        icono = MessageBoxIcon.Warning;
                        break;

                    case HttpStatusCode.InternalServerError:
                        titulo = "Error del servidor";
                        icono = MessageBoxIcon.Error;
                        break;

                    default:
                        titulo = "Error";
                        icono = MessageBoxIcon.Error;
                        break;
                }
            }

            MessageBox.Show(
                ex.ApiMessage,
                titulo,
                MessageBoxButtons.OK,
                icono);
        }
    }
}