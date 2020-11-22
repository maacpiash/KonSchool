using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using KonSchool.Shared;
using static KonSchool.Schools.SchoolsService;

namespace KonSchool.Schools
{
	[Route("")]
	[ApiController]
	public class SchoolsController : ControllerBase
	{
		private ILogger _logger;
		private readonly ISchoolsService _schools;

		public SchoolsController(ISchoolsService schoolService, ILogger<SchoolsController> logger)
		{
			_logger = logger;
			_schools = schoolService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<School>> Get()
		{
			_logger.LogInformation("Returing details of all the schools.");
			return Ok(_schools.GetAllSchools());
		}

		[HttpGet("{id}")]
		public ActionResult<School> GetOneSchool(string id)
		{
			var school = _schools.GetSchool(id);

			if (school == null)
			{
				_logger.LogInformation($"School with EIIN {id} not found.");
				return NotFound();
			}

			return Ok(school);
		}

		[HttpGet("div/{div}/{sex:alpha?}")]
		public ActionResult<IEnumerable<School>> GetSchoolsByDivision(string div, string sex = "")
		{
			var schools = _schools.GetSchoolsByDivision(div);
			string logSuffix = ".";

			if (!string.IsNullOrEmpty(sex))
			{
				schools = FilterBySex(schools, sex);
				logSuffix = $" of type \"{sex}\".";
			}

			if (schools.Count == 0)
			{
				_logger.LogInformation($"No school in the division of {div} found" + logSuffix);
				return NotFound();
			}

			_logger.LogInformation($"{schools.Count} school(s) found in the divition of {div}" + logSuffix);
			return Ok(schools);
		}

		[HttpGet("dis/{dis}/{sex:alpha?}")]
		public ActionResult<IEnumerable<School>> GetSchoolsByDistrict(string dis, string sex = "")
		{
			var schools = _schools.GetSchoolsByDistrict(dis);
			string logSuffix = ".";

			if (!string.IsNullOrEmpty(sex))
			{
				schools = FilterBySex(schools, sex);
				logSuffix = $" of type \"{sex}\".";
			}

			if (schools.Count == 0)
			{
				_logger.LogInformation($"No school in the district of {dis} found" + logSuffix);
				return NotFound();
			}

			_logger.LogInformation($"{schools.Count} school(s) found in the district of {dis}" + logSuffix);
			return Ok(schools);
		}
	}
}
