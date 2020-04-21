using System;
using System.IO;
using COW.API.Enricher;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Exceptions.Core;
using Serilog.Formatting.Compact;

namespace COW.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Information()
                .WriteTo.Console(new CompactJsonFormatter())
                .CreateLogger();
            try
            {
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                        webBuilder.UseKestrel();
                        webBuilder.UseIISIntegration();
                        webBuilder.UseStartup<Startup>();
                        webBuilder.UseSerilog((hostingContext, config) => {
                            var env = hostingContext.HostingEnvironment;
                            config
                                .Enrich.FromLogContext()
                                .Enrich.WithExceptionDetails(
                                    new DestructuringOptionsBuilder()
                                        .WithDefaultDestructurers()
                                )
                                .Enrich.With<EventTypeEnricher>()
                                .Enrich.WithExceptionDetails()
                                .Enrich.WithThreadId()
                                .Enrich.WithProcessName()
                                .Enrich.WithCorrelationId()
                                .MinimumLevel.Information()
                                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                .MinimumLevel.Override("System", LogEventLevel.Warning)
                            .WriteTo.Console(new CompactJsonFormatter(), LogEventLevel.Information);
                             if (env.IsDevelopment() || env.IsEnvironment("Staging"))
                                config
                                    .MinimumLevel.Debug();
#if DEBUG
                            config.WriteTo.Seq("http://localhost:5341");
#endif
                        });

                    })
                .Build()
                .Run();
            }
            catch (Exception ex)
            {
                Log.Logger?.ForContext<Program>().Fatal(ex, "Unhandled exception");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
