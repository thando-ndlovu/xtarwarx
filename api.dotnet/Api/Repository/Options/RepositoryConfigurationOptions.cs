using Microsoft.EntityFrameworkCore.Infrastructure;

using MySql.EntityFrameworkCore.Infrastructure;

using System;

namespace Api.Repository.Options
{
	public class RepositoryConfigurationOptions
	{
		public const string ConfigurationType_InMemory = "InMemory";
		public const string ConfigurationType_MongoDB = "MongoDB";
		public const string ConfigurationType_MySQL = "MySQL";
		public const string ConfigurationType_Sqlite = "Sqlite";
		public const string ConfigurationType_SqlServer = "SqlServer ";

		public string? ConfigurationType { get; set; }
		public string? ConnectionString { get; set; }
		public string? DatabaseName { get; set; }

		public Action<InMemoryDbContextOptionsBuilder>? InMemoryDbContextOptions { get; set; }
		public Action<MySQLDbContextOptionsBuilder>? MySQLDbContextOptions { get; set; }
		public Action<SqliteDbContextOptionsBuilder>? SqliteDbContextOptions { get; set; }
		public Action<SqlServerDbContextOptionsBuilder>? SqlServerDbContextOptions { get; set; }
	}
}
