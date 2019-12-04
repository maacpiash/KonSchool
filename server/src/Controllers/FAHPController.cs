using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using KonSchool.Models;

namespace KonSchool.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAHPController : ControllerBase
    {
        [HttpGet("{numbers}")]
        public ActionResult<IEnumerable<double>> Get(string numbers)
        {
            int[] values;
            try
            {
                values = Array.ConvertAll(numbers.Split(','), int.Parse);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
                return BadRequest(e);
            }

            if (values.Length < 5)
            {
                Console.Error.WriteLine("Insufficient values!");
                return BadRequest("Insufficient values!");
            }

            foreach (int item in values)
            {
                if (item > 9 || item < -9)
                {
                    Console.Error.WriteLine("All values must be between +9 and -9.");
                    return BadRequest("All values must be between +9 and -9.");
                }
            }
            
            return Ok(new FAHP(Inference.ComparisonMatrix(values)).CriteriaWeights);
        }
    }
}