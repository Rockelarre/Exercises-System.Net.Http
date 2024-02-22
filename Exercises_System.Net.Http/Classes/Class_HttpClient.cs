using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Exercises_System.Net.Http.Classes
{
    public class Class_HttpClient
    {
        public async Task HttpGetRequest()
        {
            // Create an HTTP client
            // Crear un cliente HTTP
            using (var client = new HttpClient())
            {
                // Make a GET request to a URL
                // Hacer una solicitud GET a una URL
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");

                // Check if the request was successful
                // Verificar si la solicitud fué exitosda
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response as a string
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
