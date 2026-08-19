using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaLojanita.Utilidad
{
    public class ApiException: Exception
    {
        public HttpStatusCode? StatusCode { get; }
        public string? ApiMessage { get; }
        public ApiException(HttpStatusCode? statusCode, string message):base(message)
        {
            StatusCode = statusCode;
            ApiMessage = message;
        }
    }
}
