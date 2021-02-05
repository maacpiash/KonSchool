using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KonSchool.FAHP;

namespace KonSchool.FAHP
{
	[Route("api")]
	[ApiController]
	public class FAHPController : ControllerBase
	{
		private ILogger _logger;

		public FAHPController(ILogger<FAHPController> logger) => _logger = logger;

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
				_logger.LogInformation(e.Message);
				return BadRequest(e);
			}

			if (values.Length < 5)
			{
				_logger.LogInformation("Insufficient values!");
				return BadRequest("Insufficient values!");
			}

			foreach (int item in values)
			{
				if (item > 9 || item < -9)
				{
					_logger.LogInformation("All values must be between +9 and -9.");
					return BadRequest("All values must be between +9 and -9.");
				}
			}

			_logger.LogInformation("Returning values for " + string.Join(",", values.Select(x => x.ToString()).ToArray()));
			var fahp = new FAHP(Inference.ComparisonMatrix(values));
			var weights = fahp.CriteriaWeights;
			_logger.LogInformation("Values: " + string.Join(",", weights.Select(x => x.ToString("0.00000")).ToArray()));
			return Ok(weights);
		}
	}
}
