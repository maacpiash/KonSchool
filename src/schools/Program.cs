using static Microsoft.AspNetCore.Http.Results;

namespace KonSchool.Schools;

public class Program
{
	static async Task Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddSingleton<ISchoolsRepository, SchoolsRepository>();

		var app = builder.Build();

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

		app.MapGet("/", (string div, string dis, string sex, bool seg, int @class, ISchoolsRepository schools) =>
		{
			var filteredSchools = schools
				.GetAllSchools()
				.FilterByDivision(div)
				.FilterByDistrict(dis)
				.FilterBySex(sex)
				.FilterBySegregated(seg ? sex : null)
				.FilterByClass(@class);

			app.Logger.LogInformation($"{filteredSchools.Count()} school(s) found with the following query:\n" +
				$"Division:\t{div}\nDistrict:\t{dis}\nSex:\t\t{sex}\nSegragated:\t{seg}\nClass:\t\t{@class}\n");

			if (filteredSchools.Count() == 0)
				return NotFound();

			return Ok(filteredSchools);
		});

		await app.RunAsync();
	}
}
