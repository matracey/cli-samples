using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HelloWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseServer("Microsoft.AspNetCore.Server.Kestrel")
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseDefaultHostingConfiguration(args)
                        .UseIISPlatformHandlerUrl()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}