using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using KonSchool.Shared;

namespace KonSchool.Schools;

public class SchoolsRepository : ISchoolsRepository
{
	private readonly IEnumerable<School> _schools;
	private readonly IConfiguration _config;
	private readonly ILogger<SchoolsRepository> _logger;

	public SchoolsRepository(IConfiguration config, ILogger<SchoolsRepository> logger)
	{
		_config = config;
		_logger = logger;
		_schools = GetAllSchools();
	}

	public IEnumerable<School> GetAllSchools()
	{
		if (_schools is not null)
			return _schools;

		try
		{
			string connStr = _config.GetValue<string>("MongoDb:ConnectionString");
			string dbName = _config.GetValue<string>("MongoDb:DbName");
			string colName = _config.GetValue<string>("MongoDb:CollectionName");

			var client = new MongoClient(connStr);
			var database = client.GetDatabase(dbName);
			var collection = database.GetCollection<School>(colName);
			return collection.Find(_ => true).ToList() as IEnumerable<School>;
		}
		catch (Exception e)
		{
			_logger.LogError(e.Message);
			return new List<School>() as IEnumerable<School>;
		}
	}
}
