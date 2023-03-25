using Microsoft.EntityFrameworkCore.Infrastructure;

using System;

namespace Repository.Implementations.Sqlite
{
	public class SqliteRepositoryOptions : RepositoryOptions
	{
		public Action<SqliteDbContextOptionsBuilder>? DbContextOptions { get; set; }
	}
}
