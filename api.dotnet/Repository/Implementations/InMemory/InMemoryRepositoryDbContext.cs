using Microsoft.EntityFrameworkCore;

namespace Repository.Implementations.InMemory
{
	public class InMemoryRepositoryDbContext : RepositoryDbContext
	{
		public InMemoryRepositoryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
	}
}
