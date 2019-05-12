using System.Collections.Generic;
using System.Linq;
using KonSchool.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace SchoolsApi.Services
{
    public class SchoolService
    {
        private readonly IMongoCollection<School> _Schools;

        public SchoolService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("SchoolStoreDb"));
            var database = client.GetDatabase("SchoolStoreDb");
            _Schools = database.GetCollection<School>("Schools");
        }

        public List<School> Get()
        {
            return _Schools.Find(School => true).ToList();
        }

        public School Get(string id)
        {
            return _Schools.Find<School>(School => School.EIIN == int.Parse(id)).FirstOrDefault();
        }

        public School Create(School School)
        {
            _Schools.InsertOne(School);
            return School;
        }

        public void Update(string id, School SchoolIn)
        {
            _Schools.ReplaceOne(School => School.EIIN == int.Parse(id), SchoolIn);
        }

        public void Remove(School SchoolIn)
        {
            _Schools.DeleteOne(School => School.EIIN == SchoolIn.EIIN);
        }

        public void Remove(string id)
        {
            _Schools.DeleteOne(School => School.EIIN == int.Parse(id));
        }
    }
}