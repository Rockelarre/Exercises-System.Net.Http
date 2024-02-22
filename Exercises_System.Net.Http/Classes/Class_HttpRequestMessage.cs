using System;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Exercises_System.Net.Http.Classes
{
    internal class Class_HttpRequestMessage
    {
        public async Task SendDetailedRequest()
        {
            // Create an HTTP client
            // Crear un cliente HTTP
            using (var client = new HttpClient())
            {
                // Create an HTTP POST request
                // Crear una solicitud HTTP POST
                var request = new HttpRequestMessage(HttpMethod.Post, "https://jsonplaceholder.typicode.com/posts");

                // Add custom headers
                // Agregar encabezados personalizados
                request.Headers.Add("X-Custom-Headers", "CustomValue");

                // Add a JSON body to the request
                // Agregar un cuerpo JSON a la solicitud
                var json = "{\"key\": \"value\"}";
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                // Specify HTTP version
                // Especificar la versión de HTTP
                request.Version = new Version(1, 1);

                // Specify the TLS version
                // Especificar la versión de TLS
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Specify a client certificate
                // Especificar un certificado del cliente
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                // Specify authentication credentials
                // Especificar credenciales de autenticación
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes("username:password")));

                //
                // Especificar un tiempo de espera
                client.Timeout = TimeSpan.FromSeconds(10);

                // Specify a timeout
                // Especificar un token de cancelación
                var cancellationTokenSource = new CancellationTokenSource();
                var cancellationToken = cancellationTokenSource.Token;

                // Specify a proxy
                // Especificar un proxy
                // (Desde 4.5.1) client.DefaultProxy = new WebProxy("http://proxy.example.com");

                // Specify a cache policy
                // Especificar una política de caché
                client.DefaultRequestHeaders.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue { NoCache = true };

                //// PENDING
                //// 
                ////
                //// Especificar una política de redirecciones
                //client.DefaultRequestHeaders.AllowAutoRedirect = false;

                //// Especificar cookies
                //var cookieContainer = new CookieContainer();
                //var cookie = new Cookie("name", "value", "/", "example.com");
                //cookieContainer.Add(cookie);
                //clientHandler.CookieContainer = cookieContainer;

                //// Especificar certificados de servidor
                //clientHandler.ServerCertificateCustomValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                //// Especificar opciones de seguridad
                //clientHandler.SslProtocols = SslProtocols.Tls12;

                //// Especificar opciones de autenticación
                //clientHandler.Credentials = new NetworkCredential("username", "password");

                //// Especificar opciones de codificación
                //clientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                //// Especificar opciones de compresión
                //clientHandler.MaxResponseContentBufferSize = 1024 * 1024;

                //// Especificar opciones de control de caché
                //clientHandler.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);

                //// Especificar opciones de control de conexión
                //clientHandler.ConnectionGroupName = "MyConnectionGroup";

                //// Especificar opciones de control de contenido
                //clientHandler.ContentLength = 1024;

                //// Especificar opciones de control de cookies
                //clientHandler.CookieContainer = new CookieContainer();

                //// Especificar opciones de control de encabezados
                //clientHandler.DefaultRequestHeaders.Add("X-Custom-Header", "CustomValue");

                //// Especificar opciones de control de redirecciones
                //clientHandler.MaxAutomaticRedirections = 10;

                //// Especificar opciones de control de seguridad
                //clientHandler.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                //// Especificar opciones de control de versiones
                //clientHandler.UseDefaultCredentials = true;

                // Print request details
                // Imprimir detalles de la solicitud
                Console.WriteLine("Complete information for request:");
                Console.WriteLine(request);

                // Send HTTP request and get response
                // Enviar la solicitud HTTP y obtener la respuesta
                var response = await client.SendAsync(request, cancellationToken);

                // Check if the response was successful
                // Verificar si la respuesta fué exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Read response content as a string
                    // Leer el contenido de la respuesta como una cadena
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }

            }
        }
    }   
}
