using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            RunSample().ConfigureAwait(false).GetAwaiter().GetResult();

        }

        public static async Task RunSample()
        {
            const string url = "https://localhost:44361/api/";

            HttpClient httpClient = null;
            try
            {
                httpClient = new HttpClient
                {
                    BaseAddress = new Uri(url)
                };
                var response = await httpClient.GetAsync("default/GetUserDetails");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (httpClient!=null)
                {
                    httpClient.Dispose();
                }
            }

        }

    }
}
