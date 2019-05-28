using System.Collections.Generic;
using System.Linq;
using KonSchool.Models;
using Microsoft.Extensions.Configuration;

namespace KonSchool.Services
{
    public class SchoolDbService
    {
        private readonly List<School> _Schools;
        private string APIKey;

        public SchoolDbService()
        {
            _Schools = new List<School>();
        }

        public List<School> Get()
        {
            return _Schools;
        }

        public School Get(string eiin)
        {
            return _Schools.Find(School => School.EIIN.Equals(eiin));
        }

        public void UseApiKey(string key) => APIKey = key;
    }
}