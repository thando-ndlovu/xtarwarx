using Microsoft.EntityFrameworkCore;

namespace Repository.Implementations.Sqlite
{
	public class SqliteRepositoryDbContext : RepositoryDbContext
	{
		public SqliteRepositoryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
	}
}
