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
            Console.WriteLine("1. HttpClient: GET");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("3. Opción 3");
            Console.WriteLine("4. Salir");

            Console.WriteLine("");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    var myHttpClient = new Class_HttpClient();
                    await myHttpClient.HttpGetRequest();
                    break;
                case "2":
                    Console.WriteLine("Ha elegido la Opción 2");
                    break;
                case "3":
                    Console.WriteLine("Ha elegido la Opción 3");
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
