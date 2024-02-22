using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercises_System.Net.Http.Classes
{
    internal class Class_HttpRequestException
    {
        public async Task GetHttpErrors()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Make an HTTP request
                    // Hacer una solicitud HTTP
                    var response = await client.GetAsync("https://example.commm/api");

                    // Read the content of the response
                    // Leer el contenido de la respuesta
                    var content = await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException ex)
                {
                    // Handle the exception
                    // Manejar la excepción
                    Console.WriteLine("Error de E/S al hacer la solicitud HTTP: " + ex);
                }


            }
        }
    }
}
