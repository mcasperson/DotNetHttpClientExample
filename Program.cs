using System.Net.Http;
using System.Threading.Tasks;

namespace DotNetHttpClientExample
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(args[1]);
            return (int) result.StatusCode >= 200 && (int) result.StatusCode <= 299 ? 0 : 1;
        }
    }
}
