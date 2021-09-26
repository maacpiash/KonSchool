using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using KonSchool.FAHP;

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

app.MapGet("/{numbers}", (string numbers) =>
{
	try
	{
		var values = Array.ConvertAll((numbers).Split(','), int.Parse);
		var fahp = new FAHP(Inference.ComparisonMatrix(values));
		app.Logger.LogInformation($"Returning values for {numbers}.");
		var weights = fahp.CriteriaWeights;
		var weightsStr = string.Join(", ", weights.Select(x => x.ToString("0.00000")).ToArray());
		app.Logger.LogInformation($"Values: {weightsStr}");
		return Results.Ok(weights);
	}
	catch (Exception e)
	{
		app.Logger.LogError(e.Message);
		return Results.BadRequest($"{e.Message}: {numbers}");
	}
});

app.Run();
