using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Utilidad;

namespace TiendaLaLojanita.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(IHttpClientFactory httpClientFactory)
        {
            this._httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        public async Task<Response<T>> GetAsync<T>(string url)
        {
            HttpResponseMessage response;
            try
            {
                response = await this._httpClient.GetAsync(url);
            }
            catch(HttpRequestException)
            {
                throw new ApiException(null, "No se pudo establecer conexión con el servidor.");
            }
            catch(TaskCanceledException)
            {
                throw new ApiException(null, "La solicitud al servidor excedió el tiempo de espera.");
            }
            return await ProcesarRespuesta<T>(response);
        }

        public async Task<Response<T>> PostAsync<T>(string url,object data)
        {
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(data);

                using var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                 response = await _httpClient.PostAsync(url, content);
            }catch (HttpRequestException)
            {
                throw new ApiException(
                    null,
                    "No se pudo establecer conexión con el servidor.");
            }
            catch (TaskCanceledException)
            {
                throw new ApiException(
                    null,
                    "La solicitud al servidor excedió el tiempo de espera.");
            }
            return await ProcesarRespuesta<T>(response);
        }

        public async Task<Response<T>> PutAsync<T>(
            string url,
            object data)
        {
            HttpResponseMessage response;

            try
            {
                string json = JsonConvert.SerializeObject(data);

                using var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

                response = await _httpClient.PutAsync(url, content);
            }
            catch (HttpRequestException)
            {
                throw new ApiException(
                    null,
                    "No se pudo establecer conexión con el servidor.");
            }
            catch (TaskCanceledException)
            {
                throw new ApiException(
                    null,
                    "La solicitud al servidor excedió el tiempo de espera.");
            }

            return await ProcesarRespuesta<T>(response);
        }

        public async Task<Response<T>> DeleteAsync<T>(string url)
        {
            HttpResponseMessage response;

            try
            {
                response = await _httpClient.DeleteAsync(url);
            }
            catch (HttpRequestException)
            {
                throw new ApiException(
                    null,
                    "No se pudo establecer conexión con el servidor.");
            }
            catch (TaskCanceledException)
            {
                throw new ApiException(
                    null,
                    "La solicitud al servidor excedió el tiempo de espera.");
            }

            return await ProcesarRespuesta<T>(response);
        }

        private async Task<Response<T>> ProcesarRespuesta<T>(HttpResponseMessage response)
        {
            string responseJson =
                await response.Content.ReadAsStringAsync();

            Response<T>? result = null;

            // Intentamos deserializar la respuesta estándar de nuestra API
            if (!string.IsNullOrWhiteSpace(responseJson))
            {
                try
                {
                    result = JsonConvert.DeserializeObject<Response<T>>(
                        responseJson);
                }
                catch(JsonException)
                {
                    throw new ApiException(HttpStatusCode.InternalServerError, "El servidor devolvió una respuesta inválida.");
                    // La respuesta no tiene el formato esperado.
                }
            }

            // Error HTTP
            if (!response.IsSuccessStatusCode)
            {
                string mensaje = result?.msg;

                if (string.IsNullOrWhiteSpace(mensaje))
                {
                    mensaje = ObtenerMensajePorCodigo(
                        response.StatusCode);
                }

                throw new ApiException(
                    response.StatusCode,
                    mensaje);
            }

            if (result == null)
            {
                throw new ApiException(
                    HttpStatusCode.InternalServerError,
                    "El servidor no devolvió una respuesta válida.");
            }

            if (!result.status)
            {
                throw new ApiException(
                    response.StatusCode,
                    result.msg ?? "La operación no pudo realizarse.");
            }

            return result;
        }

        private string ObtenerMensajePorCodigo(HttpStatusCode statusCode)
        {
            return statusCode switch
            {
                HttpStatusCode.BadRequest =>
                    "La información enviada no es válida.",

                HttpStatusCode.Unauthorized =>
                    "No está autorizado para realizar esta operación.",

                HttpStatusCode.Forbidden =>
                    "No tiene permisos para realizar esta operación.",

                HttpStatusCode.NotFound =>
                    "El recurso solicitado no existe.",

                HttpStatusCode.Conflict =>
                    "La operación no puede realizarse debido al estado actual del recurso.",

                HttpStatusCode.InternalServerError =>
                    "Ocurrió un error interno en el servidor.",

                HttpStatusCode.BadGateway =>
                    "El servidor recibió una respuesta inválida.",

                HttpStatusCode.ServiceUnavailable =>
                    "El servicio no está disponible actualmente.",

                _ =>
                    $"Ocurrió un error en el servidor. Código HTTP: {(int)statusCode}"
            };
        }
    }
}
