using System.IO;
using DotNetEnv;

namespace KonSchool.Schools
{
	public class Environment
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
		public string CollectionName { get; set; }

		public Environment(bool dev, string envPath)
		{
			if (dev)
			{
				var loadOptions = new Env.LoadOptions();
				if (!File.Exists(envPath))
					throw new System.Exception($"Environmental variables file not found at {envPath}");
				Env.Load(envPath, loadOptions);
				ConnectionString = Env.GetString("CONNECTIONSTRING");
				DatabaseName = Env.GetString("DBNAME");
				CollectionName = Env.GetString("COLLECTIONNAME");
			}
			else
			{
				ConnectionString = System.Environment.GetEnvironmentVariable("CONNECTIONSTRING");
				DatabaseName = System.Environment.GetEnvironmentVariable("DBNAME");
				CollectionName = System.Environment.GetEnvironmentVariable("COLLECTIONNAME");
			}
		}
	}
}
