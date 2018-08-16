using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ElectronNET.API;
using ElectronNET.API.Entities;

namespace KonSchool.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment())
            {
                
                app.UseBrowserLink();
            }
            else
            {
                //app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
            Bootstrap();
        }

        public async void Bootstrap()
        {
            var MainWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
            {
                Show = false
            });

            MainWindow.OnReadyToShow += () => MainWindow.Show();

            var Menubar = new MenuItem[]
            {
                new MenuItem
                {
                    Label = "File",
                    Submenu = new MenuItem[]
                    {
                        new MenuItem { Label = "About", Click = ShowAbout },
                        new MenuItem { Label = "Exit", Click = Exit }
                    }
                }
            };

            Electron.Menu.SetApplicationMenu(Menubar);
            Electron.App.WindowAllClosed += () => Exit();
        }

        public async void ShowAbout()
        {
            await Electron.Dialog.ShowMessageBoxAsync("কোন স্কুল? desktop application was developed by\n" +
                "Md. Abdul Ahad Chowdhury, with the graceful help of Rezaur Rahman Shaon and\n" +
                "Abdullah-Al Nahian Siraj\nWe are all grateful to Dr. M Rashedur Rahman " +
                "for his support\nand guidance regarding our Fuzzy AHP project.");
        }

        private void Exit()
        {
            Electron.App.Quit();
            Environment.Exit(0); 
        }

    }
}
