using System;
using MongoDB.Driver;

namespace Microsoft.Extensions.Logging.Slack
{
	public class MongoConfiguration
	{
		public string DatabaseName { get; set; }
		public IMongoClient Client { get; set; }
		public LogLevel MinLevel { get; set; }
	}
}