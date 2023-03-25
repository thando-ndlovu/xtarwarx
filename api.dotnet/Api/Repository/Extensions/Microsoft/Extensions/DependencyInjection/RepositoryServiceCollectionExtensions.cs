namespace Microsoft.Extensions.DependencyInjection
{
	public static class RepositoryServiceCollectionExtensions
	{
		public static RepositoryBuilder AddDefaultRepository(this IServiceCollection serviceCollection)
			=> new (serviceCollection);
	}
}