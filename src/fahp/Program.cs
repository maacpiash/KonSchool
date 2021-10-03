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

app.MapGet("/{values}", (string inputs) =>
{
	if (string.IsNullOrEmpty(inputs) || !inputs.Contains(","))
	{
		app.Logger.LogInformation($"Invalid input: {inputs}");
		return Results.BadRequest($"Invalid input: {inputs}");
	}
	var values = inputs.Split(',');
	if (values.Length < 5)
	{
		app.Logger.LogInformation($"At least 5 integers between -9 and +9 (inclusive) are expected: {inputs}");
		return Results.BadRequest($"At least 5 integers between -9 and +9 (inclusive) are expected: {inputs}");
	}

	var numbers = new int[values.Length];
	for (int i = 0; i < values.Length; i++)
	{
		if (!int.TryParse(values[i], out int number))
		{
			app.Logger.LogInformation($"All the values must be numbers: {inputs}");
			return Results.BadRequest($"All the values must be numbers: {inputs}");
		}
		if (number < -9 || number > 9)
		{
			app.Logger.LogInformation($"Each fuzzy input must be between -9 and +9 (inclusive): {inputs}");
			return Results.BadRequest($"Each fuzzy input must be between -9 and +9 (inclusive): {inputs}");
		}
		numbers[i] = number;
	}

	var weights = numbers.GenerateComparisonMatrix().RunFAHP();

	app.Logger.LogInformation($"Returning values for {inputs}: "
		+ weights.Aggregate("", (all, w) => $"{all}, {w:0.000000}"));
	return Results.Ok(weights);
});

app.Run();
