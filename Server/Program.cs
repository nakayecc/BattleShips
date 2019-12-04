using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Server.Models.Board;
using Server.Services;

namespace Server
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

                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureServices(serviceCollection =>
                    {
                        serviceCollection.AddSingleton<IGame>(new Game()
                        {
                            PlayerGameBoard = new GameBoard(),
                             EnemyGameBoard = new GameBoard(),
                             Shipyard = new Shipyard()
                            
                        });
                    });
                });
            
    }
}
