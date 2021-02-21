using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using KonSchool.Client.Models;
using KonSchool.Client.Data;
using MudBlazor.Services;

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
		// For more information on how to configure your application,
		// visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddLocalization(options => options.ResourcesPath = "Resources");
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddSingleton<ILocationDataService, LocationDataService>();
			services.AddScoped<AppStateContainer>();
			services.AddMudServices();
		}

		private RequestLocalizationOptions GetLocalizationOptions()
		{
			var cultures = Configuration.GetSection("Cultures").GetChildren().ToDictionary(x => x.Key, x => x.Value);
			var supportedCultures = cultures.Keys.ToArray();
			return new RequestLocalizationOptions().AddSupportedCultures(supportedCultures)
				.AddSupportedUICultures(supportedCultures);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios,
				// see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRequestLocalization(GetLocalizationOptions());
			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
