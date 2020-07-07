using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;
using MongoDB.Driver;
using KonSchool.Models;
using static System.Environment;

namespace KonSchool.Services
{
    public class SchoolService : ISchoolService
    {
		readonly IMongoCollection<School> Schools;

        public SchoolService()
        {
			var client = new MongoClient(GetEnvironmentVariable("CONNECTIONSTRING"));
            var database = client.GetDatabase(GetEnvironmentVariable("DBNAME"));
            Schools = database.GetCollection<School>(GetEnvironmentVariable("COLLECTIONNAME"));
        }

        public IEnumerable<School> GetSchools() => Schools.Find(Schools => true).ToList();

    }

    public interface ISchoolService
    {
        IEnumerable<School> GetSchools();
    }
}
