using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool.Models;
using KonSchool.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KonSchool.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly SchoolService _schoolService;
        private List<School> _schools;

        public SchoolsController(SchoolService schoolService)
        {
            _schoolService = schoolService;
            _schools = _schoolService.GetSchools().ToList();
        }

        [HttpGet]
        public IEnumerable<School> Get()
        {
            return _schools;
        }

        [HttpGet("{id}")]
        public ActionResult<School> GetOneSchool(string id)
        {
            var school = _schools.Where(s => s.EIIN == int.Parse(id)).First();

            if (school == null)
            {
                return NotFound();
            }

            return Ok(school);
        }

        [HttpGet("div/{div}")]
        public ActionResult<IEnumerable<School>> GetSchoolsByDivision(string div)
        {
            var schools = _schools.Where(s => s.Division == div);

            if (schools == null)
            {
                return NotFound();
            }

            return Ok(schools);
        }

        [HttpGet("dis/{dis}")]
        public ActionResult<IEnumerable<School>> GetSchoolsByDistrict(string dis)
        {
            var schools = _schools.Where(s => s.District == dis);

            if (schools == null)
            {
                return NotFound();
            }

            return Ok(schools);
        }

    }
}