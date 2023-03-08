using CubeIntersection.Process.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CubeIntersection.Program
{
    public class Program
    {
        static IServiceProvider  serviceProvider = null;

        /// <summary>
        /// Main Process
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();
            IServiceScope servicesScope = host.Services.CreateScope();
            serviceProvider = servicesScope.ServiceProvider;
            var builder = serviceProvider.GetRequiredService<ICubeBuilder>();
            var cubeIntersection = new CubeIntersection(builder);
            cubeIntersection.Execute();
        }
  
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            // An example of Dependency Injection in Console Application.
            return Host.CreateDefaultBuilder(args)
                       .ConfigureServices((_, services) => services.AddSingleton(typeof(ICubeBuilder), typeof(CubeBuilder)));
        }
    }
}