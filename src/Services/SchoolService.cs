using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text;

using KonSchool.Models;
using Newtonsoft.Json;

namespace KonSchool.Services
{
    public class SchoolService : ISchoolService
    {
        readonly List<School> Schools;

        public SchoolService()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://konschool-mlab-host.herokuapp.com/api/schools/");

            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
             
            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            
            string json = readStream.ReadToEnd();
            Schools = JsonConvert.DeserializeObject<List<School>>(json);

            response.Close();
            readStream.Close();
        }

        public IEnumerable<School> GetSchools() => Schools;

        public School Get(string eiin) => Schools.Find(School => School.EIIN.Equals(eiin));
        
    }

    public interface ISchoolService
    {
        School Get(string eiin);
        IEnumerable<School> GetSchools();
    }
}