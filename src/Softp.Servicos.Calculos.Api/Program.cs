using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Softp.Servicos.Calculos.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://localhost:8000").UseStartup<Startup>();
                });
    }
}
