﻿using devboost.DroneDelivery.Kafka.Consumer.External;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System.IO;

namespace devboost.DroneDelivery.Kafka.Consumer
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            services.AddSingleton(logger);

            logger.Information("Carregando configurações...");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            var configuration = builder.Build();
            services.AddSingleton<IConfiguration>(configuration);

            services.AddSingleton<DeliveryExternalControl>();

            services.AddTransient<ConsoleApp>();
        }
    }
}