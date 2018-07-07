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
using KonSchool_Models;

namespace KonSchool_Desktop
{
    public class Program
    {
        public static Query MyQuery { get; set; }

        public static void Main(string[] args)
        {
            string fp;

            if (args.Length == 0)
                fp = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Dataset.csv");
            else
                fp = args[0];
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
