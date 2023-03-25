using Microsoft.EntityFrameworkCore.Infrastructure;

using System;

namespace Repository.Implementations.SqlServer
{
	public class SqlServerRepositoryOptions : RepositoryOptions 
	{
		public Action<SqlServerDbContextOptionsBuilder>? DbContextOptions { get; set; }
	}
}
