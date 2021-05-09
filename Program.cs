using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DotNetHttpClientExample
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(args[0]);
            Console.WriteLine("Result was " + result.StatusCode);
            return (int) result.StatusCode >= 200 && (int) result.StatusCode <= 299 ? 0 : 1;
        }
    }
}
