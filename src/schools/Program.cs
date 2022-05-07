using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using static Microsoft.AspNetCore.Http.Results;
using KonSchool.Schools;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ISchoolsRepository, SchoolsRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
	options.SwaggerDoc("v1", new OpenApiInfo
	{
		Version = "v1",
		Title = "KonSchool Web API for Schools",
		Description = "Provides informations on secondary schools in Bangladesh",
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
		}
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

app.MapGet("/{eiin:int}", (int eiin, ISchoolsRepository schools) =>
{
	var school = schools.GetAllSchools().GetSchool(eiin);

	if (school is null)
	{
		app.Logger.LogInformation($"School with EIIN {eiin} not found.");
		return NotFound();
	}

	app.Logger.LogInformation($"School with EIIN {eiin} found.");
	return Ok(school);
});

app.MapGet("/", (string? div, string? dis, string? sex, bool? seg, int? @class, ISchoolsRepository schools) =>
{
	var filteredSchools = schools
		.GetAllSchools()
		.FilterByDivision(div)
		.FilterByDistrict(dis)
		.FilterBySex(sex)
		.FilterBySegregated((seg ?? false) ? sex : null)
		.FilterByClass(@class);

	app.Logger.LogInformation($"{filteredSchools.Count()} school(s) found with the following query:\n" +
		$"Division:\t{div}\nDistrict:\t{dis}\nSex:\t\t{sex}\nSegragated:\t{seg}\nClass:\t\t{@class}\n");

	if (filteredSchools.Count() == 0) return NotFound();

	return Ok(filteredSchools);
});

app.Run();
