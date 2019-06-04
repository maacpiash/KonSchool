using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KonSchool.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace KonSchool.Services
{
    public class SchoolService
    {
        public readonly List<School> Schools;

        public SchoolService()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://konschool-mlab-host.herokuapp.com/api/schools/");

            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Console.WriteLine("Content length is {0}", response.ContentLength);
            // Console.WriteLine("Content type is {0}", response.ContentType);
             
            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            // Console.WriteLine("Response stream received.");
            string json = readStream.ReadToEnd();
            Schools = JsonConvert.DeserializeObject<List<School>>(json);
            Console.WriteLine("NUMBER OF SCHOOLS: " + Schools?.Count);

            response.Close();
            readStream.Close();
        }

        public School Get(string eiin) => Schools.Find(School => School.EIIN.Equals(eiin));
        
    }
}