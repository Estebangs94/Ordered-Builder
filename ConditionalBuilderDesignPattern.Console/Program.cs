﻿using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace ConditionalBuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           // using IHost host = CreateHostBuilder(args).Build();

            Console.WriteLine("Hello World!");

            var builder = DemonSlayerBuilder.CreateBuilder()
                .WithName("Sparqui", 7)
                .WithLevel(10, 1)
                .WithKatanas(2, 4)
                .WithRank(Ranks.Hashira, 2)
                .WithEntries(3, "valor3", 3)
                .WithEntries(1, "valor1",1)
                .WithEntries(2, "valor2",2);

            var demonSlayer = builder.Build();

            Console.WriteLine($"This is demon slayer {demonSlayer.Name} of rank " +
                $"{demonSlayer.Rank} with {demonSlayer.Katanas} Katanas!");

            var values = demonSlayer.Entries.Values.ToList();

            Console.WriteLine("The values are");

            values.ForEach(e => Console.WriteLine(e));

            Console.ReadKey();
        }

        //private static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureServices((_, services) =>
        //            services.Add())
        //}
    }
}
