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
            Console.WriteLine("4. HttpRequestException ex");
            Console.WriteLine("5. HttpRequestMessage");

            Console.WriteLine("");

            string opcion = Console.ReadLine();

            var myHttpClient = new Class_HttpClient();
            var myStringContent = new Class_StringContent();
            var myHttpRequestException = new Class_HttpRequestException();
            var myHttpRequestMessage = new Class_HttpRequestMessage();

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
                    await myHttpRequestException.GetHttpErrors();
                    break;
                case "5":
                    await myHttpRequestMessage.SendDetailedRequest();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
