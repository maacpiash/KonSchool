using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

using KonSchool_Models;

namespace KonSchool_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAHPController : ControllerBase
    {
        // GET api/fahp
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Gimme values fam!";
        }

        // GET api/fahp/6,5.0,1,13,RAJSHAHI,SIRAJGANJ,KAMARKHANDA,ROY DAULATPUR,-1,2,1,-3,1,3,1,0,3,0,-2,0,-2,0,3,...
        [HttpGet("{variables}")]
        public ActionResult<string> Get(string variables)
        {
            if (!variables.Contains(','))
                return "Where are the other values?!";
            string[] values = variables.Split(',');
            int max = values.Length;
            if (max < 22)
                return "Where are the other values?!";
            string fp = Directory.GetCurrentDirectory();

            fp = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Dataset.csv");
            Query query;
            try
            {
                query = new Query(6, fp)
                {
                    Class = Convert.ToInt32(values[0]),
                    Social = Convert.ToDouble(values[1]),
                    IsMale = values[2] == "1",
                    Age = Convert.ToInt32(values[3]),
                    Location = new Address(values[4], values[5], values[6], values[7])
                };
                for (int i = 0; i < 15; i++)
                    query.FuzzyValues[i] = Convert.ToInt32(values[i + 8]);
            }
            catch (Exception x)
            {
                return x.ToString();
            }


            query.CreateComparisonMatrix();
            FAHP fAHP = new FAHP(query.ComparisonMatrix);
            double[] weights = fAHP.CriteriaWeights;
            if (max == 23)
                return string.Join(',', weights);
            int[] choices = new int[max - 23];
            for (int i = 23; i < max; i++)
                choices[i - max] = Convert.ToInt32(values[i]);
            query.Alternatives = choices;
            double[] finalValues = (new BootStrap(query, fAHP)).FinalScores;
            return string.Join(',', finalValues);

        }

        /* 
         * Since there will not be any POST/PUT/DELETE
         * functionality for this particular API,
         * the remaining methods are not implemented.
         */
         
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
