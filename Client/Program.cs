using Refit;
using System.Linq;
using System.Threading.Tasks;

namespace Client
{
    public interface ITestService
    {
        [Post("/api/test")]
        Task PostAsync([Body]string[] values);
    }

    class Program
    {
        static async Task Main()
        {
            var settings = new RefitSettings(new SystemTextJsonContentSerializer());
            var client = RestService.For<ITestService>("http://localhost:5000/", settings);

            // Works: const int count = 20000;
            const int count = 25000;
            const string value = "a";
            var values = Enumerable.Repeat(value, count).ToArray();
            await client.PostAsync(values);
        }
    }
}
