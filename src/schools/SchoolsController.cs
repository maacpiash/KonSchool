using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using KonSchool.Shared;
using static KonSchool.Schools.SchoolsRepositoryHelpers;

namespace KonSchool.Schools
{
	[Route("api")]
	[ApiController]
	public class SchoolsController : ControllerBase
	{
		private ILogger _logger;
		private readonly IEnumerable<School> _schools;

		public SchoolsController(ISchoolsRepository schools, ILogger<SchoolsController> logger)
		{
			_logger = logger;
			_schools = schools.GetAllSchools();
		}

		[HttpGet("school/{eiin:int}")]
		public ActionResult<School> GetOneSchool(int eiin)
		{
			var school = _schools.GetSchool(eiin);

			if (school is null)
			{
				_logger.LogInformation($"School with EIIN {eiin} not found.");
				return NotFound();
			}

			_logger.LogInformation($"School with EIIN {eiin} found.");
			return Ok(school);
		}

		[HttpGet("schools")]
		public ActionResult<School> GetFilteredSchools(
			[FromQuery] string div,
			[FromQuery] string dis,
			[FromQuery] string sex,
			[FromQuery] bool segregated,
			[FromQuery] int @class
		)
		{
			var schools = _schools
				.FilterByDivision(div)
				.FilterByDistrict(dis)
				.FilterBySex(sex)
				.FilterBySegregated(segregated ? sex : null)
				.FilterByClass(@class);

			_logger.LogInformation($"{schools.Count()} school(s) found with the following query:\n" +
				$"Division: {div}\nDistrict: {dis}\nSex: {sex}\nSexOnly: {segregated}\nClass: {@class}\n");

			if (schools.Count() == 0)
				return NotFound();

			return Ok(schools);
		}
	}
}
