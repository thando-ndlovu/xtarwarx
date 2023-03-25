using Microsoft.EntityFrameworkCore;

namespace Repository.Implementations.MySQL
{
	public class MySQLRepositoryDbContext : RepositoryDbContext
	{
		public MySQLRepositoryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
	}
}
