using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using DotNetEnv;
using static System.Environment;

namespace KonSchool.Schools
{
    public class SchoolsRepository : ISchoolsRepository
    {
        private readonly List<School> _schools;
		private readonly IWebHostEnvironment _env;
        private readonly ILogger _logger;

        public SchoolsRepository(IWebHostEnvironment env, ILogger<SchoolsRepository> logger)
        {
			_env = env;
            _logger = logger;
			_schools = GetAllSchools();
        }

        public List<School> GetAllSchools()
        {
			if (!(_schools is null))
				return _schools;

			try
			{
				bool dev = _env.IsDevelopment();
				string envPath = Path.Combine(Directory.GetCurrentDirectory(), ".env");
				var env = new Environment(dev, envPath);

				var client = new MongoClient(env.ConnectionString);
				var database = client.GetDatabase(env.DatabaseName);
				var collection = database.GetCollection<School>(env.CollectionName);
				return collection.Find(_ => true).ToList();
			}
			catch (Exception e)
			{
				_logger.LogError(e.Message);
				return null;
			}
        }
    }
}
