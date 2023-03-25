using Microsoft.EntityFrameworkCore.Infrastructure;

using System;

namespace Repository.Implementations.InMemory
{
	public class InMemoryRepositoryOptions : RepositoryOptions 
	{
		public Action<InMemoryDbContextOptionsBuilder>? DbContextOptions { get; set; }
	}
}
