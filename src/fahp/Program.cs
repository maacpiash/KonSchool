using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace KonSchool.FAHP;

public class Program
{
	static async Task Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen(options =>
		{
			options.SwaggerDoc("v1", new OpenApiInfo
			{
				Version = "v1",
				Title = "KonSchool Web API for FAHP",
				Description = "Calculates weights of criteria via Fuzzy Analytic Hierarchy Process (FAHP)",
				Contact = new OpenApiContact
				{
					Name = "Mohammad Abdul Ahad Chowdhury",
					Email = "ahad@maacpiash.com",
					Url = new Uri("https://www.maacpiash.com"),
				},
				License = new OpenApiLicense
				{
					Name = "AGPL-3.0",
					Url = new Uri("https://github.com/maacpiash/KonSchool/blob/master/LICENSE"),
				},
			});
		});

		var app = builder.Build();

		app.UseSwagger();
		app.UseSwaggerUI();

		if (builder.Environment.IsDevelopment())
			app.UseDeveloperExceptionPage();
		else
			app.UseHsts();
		app.UseHttpsRedirection();

		app.MapGet("/{numbers}", async context =>
		{
			var numbers = context.Request.RouteValues["numbers"];
			if (numbers is not null)
			{
				try
				{
					var values = Array.ConvertAll(((string)numbers).Split(','), int.Parse);
					var fahp = new FAHP(Inference.ComparisonMatrix(values));
					app.Logger.LogInformation($"Returning values for {numbers}.");
					var weights = fahp.CriteriaWeights;
					var weightsStr = string.Join(", ", weights.Select(x => x.ToString("0.00000")).ToArray());
					app.Logger.LogInformation($"Values: {weightsStr}");
					await context.Response.WriteAsJsonAsync(weights);
				}
				catch (Exception e)
				{
					app.Logger.LogError(e.Message);
					context.Response.StatusCode = 400;
					await context.Response.WriteAsync($"{e.Message}: {numbers}");
				}
			}
		});

		await app.RunAsync();
	}
}
