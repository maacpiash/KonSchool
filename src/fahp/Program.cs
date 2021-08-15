using Serilog;

namespace KonSchool.FAHP;

public class Program
{
	static async Task Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		var app = builder.Build();

		if (builder.Environment.IsDevelopment())
			app.UseDeveloperExceptionPage();
		else
			app.UseHsts();
		app.UseHttpsRedirection();

		app.MapGet("/{numbers}", async context =>
		{
			using var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();
			var numbers = context.Request.RouteValues["numbers"];
			if (numbers is not null)
			{
				try
				{
					var values = Array.ConvertAll(((string)numbers).Split(','), int.Parse);
					var fahp = new FAHP(Inference.ComparisonMatrix(values));
					log.Information($"Returning values for {numbers}.");
					var weights = fahp.CriteriaWeights;
					var weightsStr = string.Join(", ", weights.Select(x => x.ToString("0.00000")).ToArray());
					log.Information($"Values: {weightsStr}");
					await context.Response.WriteAsJsonAsync(weights);
				}
				catch (Exception e)
				{
					log.Error(e.Message);
					context.Response.StatusCode = 400;
					await context.Response.WriteAsync($"{e.Message}: {numbers}");
				}
			}
		});

		await app.RunAsync();
	}
}
