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
		readonly IMongoCollection<School> Schools;
		private readonly ILogger _logger;
		private string[] keys, env;
		private int connStr = 0, dbName = 1, collName = 2;

        public SchoolsRepository(IWebHostEnvironment hostEnvironment, ILogger<SchoolsRepository> logger)
        {
			_logger = logger;
			keys = new string[] { "CONNECTIONSTRING", "DBNAME", "COLLECTIONNAME" };
			env = new string[3];
			if (hostEnvironment.IsDevelopment())
			{
				var loadOptions = new Env.LoadOptions(parseVariables: true);
				string envPath = Path.Combine(Directory.GetCurrentDirectory(), ".env");
				try
				{
					if (File.Exists(envPath))
						_logger.LogInformation($"Trying to read environmental variables from {envPath}");
					else
						throw new System.Exception($"Environmental variables file not found at {envPath}");
					Env.Load(envPath, loadOptions);
					for (int i = 0; i < 3; i++)
						env[i] = Env.GetString(keys[i]);
					foreach (var value in env)
						if (value is null)
							throw new System.Exception($"Value of {value} not found in file {envPath}");
					_logger.LogInformation($"Environmental variables are read from {envPath}");
				}
				catch (System.Exception e)
				{
					_logger.LogError(e.Message);
					TryToGetValuesFromEnv();
				}
			}
			else
				TryToGetValuesFromEnv();

			var client = new MongoClient(env[connStr]);
            var database = client.GetDatabase(env[dbName]);
            Schools = database.GetCollection<School>(env[collName]);
        }

		private void TryToGetValuesFromEnv()
		{
			try
			{
				for (int i = 0; i < 3; i++)
					env[i] = GetEnvironmentVariable(keys[i]);
			}
			catch (System.Exception ex)
			{
				_logger.LogError("Environmental variables not found in the environment.");
				throw ex;
			}
		}

        public IEnumerable<School> GetAllSchools() => Schools.Find(Schools => true).ToList();
    }
}
