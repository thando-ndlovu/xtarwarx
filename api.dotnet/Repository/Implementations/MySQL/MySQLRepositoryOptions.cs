using MySql.EntityFrameworkCore.Infrastructure;

using System;

namespace Repository.Implementations.MySQL
{
	public class MySQLRepositoryOptions : RepositoryOptions 
	{
		public Action<MySQLDbContextOptionsBuilder>? DbContextOptions { get; set; }
	}
}
