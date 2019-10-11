using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var t = client.GetStringAsync("https://localhost:44334/api/values");
            Task.Run(() => t).Wait();

            Console.WriteLine(t.Result);

            Console.ReadKey();
        }
    }
}