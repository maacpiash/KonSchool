using System.Collections.Generic;
using System.Linq;
using KonSchool.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace KonSchool.Services
{
    public class SchoolDbService
    {
        private readonly IMongoCollection<School> _Schools;

        public SchoolDbService()
        {
            // Credentials
            //string username = "konschool";
            //string password = "q12121";
            //string mongoDbAuthMechanism = "SCRAM-SHA-1";
            //MongoInternalIdentity internalIdentity = new MongoInternalIdentity("admin", username);
            //PasswordEvidence passwordEvidence = new PasswordEvidence(password);
            //MongoCredential mongoCredential = new MongoCredential(mongoDbAuthMechanism, internalIdentity, passwordEvidence);
            

            var credential = MongoCredential.CreateCredential("bdschooldb", "konschool", "q12121");
            var server = new MongoServerAddress("mongodb://ds016138.mlab.com");

            var setting = new MongoClientSettings();
            setting.Server = server;
            setting.Credential = credential;

            MongoClient client = new MongoClient(setting);
            
            var db = client.GetDatabase("bdschooldb");
            _Schools = db.GetCollection<School>("schools");
            // if (_Schools != null) System.Console.WriteLine($"SUCCESS! {_Schools.Database.ToString()}");
        }

        public List<School> Get()
        {
            return _Schools.Find(School => true).ToList();
        }

        public School Get(string eiin)
        {
            return _Schools.Find(School => School.EIIN.Equals(eiin)).FirstOrDefault();
        }
    }
}