using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercises_System.Net.Http.Classes
{
    internal class Class_StringContent
    {
        public async Task CopyRequestContent()
        {
            // Create an HTTP client
            // Crear un cliente HTTP
            var content = new StringContent("{\"key\": \"value\"}", System.Text.Encoding.UTF8, "application/json");

            // Create an output stream
            // Crear un flujo de salida
            using (var outputStream = new MemoryStream())
            {
                // Copy request content to output stream
                // Copiar el contenido de la solicitud al flujo de sallida
                await content.CopyToAsync(outputStream);

                // Convert the output stream to a string and display it in the console
                // Convertir el flujo de salida a una cadena y mostrarla en la consola
                var contentString = System.Text.Encoding.UTF8.GetString(outputStream.ToArray());
                Console.WriteLine(contentString);
            }
        }
    }
}
