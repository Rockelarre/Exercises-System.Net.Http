using Exercises_System.Net.Http.Classes;
using System;
using System.Threading.Tasks;

namespace Exercises_System.Net.Http
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Choose an option to see how it works:");
            Console.WriteLine("Elija una opción para ver su funcionamiento:");
            Console.WriteLine("");
            Console.WriteLine("1. HttpClient - GetAsync()");
            Console.WriteLine("2. HttpClient - PostAsync()");
            Console.WriteLine("3. StringContent - CopyToAsync()");
            Console.WriteLine("4. Salir");

            Console.WriteLine("");

            string opcion = Console.ReadLine();

            var myHttpClient = new Class_HttpClient();
            var myStringContent = new Class_StringContent();

            switch (opcion)
            {
                case "1":
                    await myHttpClient.HttpGetRequest();
                    break;
                case "2":
                    await myHttpClient.HttpPostRequest();
                    break;
                case "3":
                    await myStringContent.CopyRequestContent();
                    break;
                case "4":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
