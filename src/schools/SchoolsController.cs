using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("div/{div}")]
        public ActionResult<IEnumerable<School>> GetSchoolsByDivision(string div)
        {
            var schools = _schools.GetSchoolsByDivision(div);

            if (schools.Count == 0)
            {
				_logger.LogInformation($"No school in the division of {div} found.");
                return NotFound();
            }

			_logger.LogInformation($"{schools.Count} school(s) found in the division of {div}");
            return Ok(schools);
        }

        [HttpGet("dis/{dis}")]
        public ActionResult<IEnumerable<School>> GetSchoolsByDistrict(string dis)
        {
            var schools = _schools.GetSchoolsByDistrict(dis);

            if (schools.Count == 0)
            {
				_logger.LogInformation($"No school in the district of {dis} found.");
                return NotFound();
            }

			_logger.LogInformation($"{schools.Count} school(s) found in the district of {dis}.");
            return Ok(schools);
        }

    }
}
