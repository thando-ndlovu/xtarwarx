using Microsoft.EntityFrameworkCore;

namespace Repository.Implementations.SqlServer
{
	public class SqlServerRepositoryDbContext : RepositoryDbContext
	{
		public SqlServerRepositoryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
	}
}
