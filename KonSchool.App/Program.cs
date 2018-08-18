using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using ElectronNET.API;
using KonSchool.Models;

namespace KonSchool.App
{
    public class Program
    {
        public static Query MyQuery { get; set; }

        public static void Main(string[] args)
        {
            string fp;
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Directory.GetCurrentDirectory());
            if (args.Length == 0)
                fp = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Dataset.csv");
            else
                fp = args[0];
            Console.WriteLine(fp);
            MyQuery = new Query(6, fp);
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseElectron(args)
                .UseStartup<Startup>()
                .Build();
    }
}
