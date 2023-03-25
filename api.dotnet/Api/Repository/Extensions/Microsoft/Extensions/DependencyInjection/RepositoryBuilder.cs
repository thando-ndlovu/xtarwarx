using Api.Repository.Exceptions;
using Api.Repository.Options;
using Api.Repository.Services;

using Repository.Implementations.InMemory;
using Repository.Implementations.MongoDb;
using Repository.Implementations.MySQL;
using Repository.Implementations.Sqlite;
using Repository.Implementations.SqlServer;

using System;

namespace Microsoft.Extensions.DependencyInjection
{
	public class RepositoryBuilder
	{
		public RepositoryBuilder(IServiceCollection services)
		{
			Services = services;
		}

		public IServiceCollection Services { get; }

		public RepositoryBuilder WithOptions(Action<RepositoryOptions> repositoryOptions)
		{
			Services.Configure(repositoryOptions);

			return this;
		}
		public RepositoryBuilder WithStartupOptions(Action<RepositoryStartupOptions> repositoryStartupOptions)
		{
			Services.Configure(repositoryStartupOptions);

			return this;
		}

		public void Configure(Action<RepositoryConfigurationOptions> options)
		{
			RepositoryConfigurationOptions Options = new ();

			options.Invoke(Options);
			Services.Configure(options);

			switch (Options.ConfigurationType)
			{
				case RepositoryConfigurationOptions.ConfigurationType_InMemory:
					InMemoryRepository.Configure(Services, new InMemoryRepositoryOptions
					{
						ConnectionString = Options.ConnectionString,
						DatabaseName = Options.DatabaseName,
						DbContextOptions = Options.InMemoryDbContextOptions

					}); break;

				case RepositoryConfigurationOptions.ConfigurationType_MongoDB:
					MongoDbRepository.Configure(Services, new MongoDbRepositoryOptions
					{
						ConnectionString = Options.ConnectionString,
						DatabaseName = Options.DatabaseName,

					}); break;

				case RepositoryConfigurationOptions.ConfigurationType_MySQL:
					MySQLRepository.Configure(Services, new MySQLRepositoryOptions
					{
						ConnectionString = Options.ConnectionString,
						DatabaseName = Options.DatabaseName,
						DbContextOptions = Options.MySQLDbContextOptions

					}); break;

				case RepositoryConfigurationOptions.ConfigurationType_Sqlite:
					SqliteRepository.Configure(Services, new SqliteRepositoryOptions
					{
						ConnectionString = Options.ConnectionString,
						DatabaseName = Options.DatabaseName,
						DbContextOptions = Options.SqliteDbContextOptions

					}); break;

				case RepositoryConfigurationOptions.ConfigurationType_SqlServer:
					SqlServerRepository.Configure(Services, new SqlServerRepositoryOptions
					{
						ConnectionString = Options.ConnectionString,
						DatabaseName = Options.DatabaseName,
						DbContextOptions = Options.SqlServerDbContextOptions

					}); break;

				default:
					{
						if (string.IsNullOrWhiteSpace(Options.ConfigurationType))
							throw new RepositoryException(
								message: "ConfigurationType cannot be null",
								innerException: new ArgumentNullException(paramName: nameof(Options.ConfigurationType)));
						else
							throw new RepositoryException(
								message: string.Format("ConfigurationType '{0}' is invalid", Options.ConfigurationType),
								innerException: new ArgumentException(
									message: null,
									paramName: nameof(Options.ConfigurationType)));
					}
			}

			Services.AddHostedService<RepositoryStartup>();
		}
	}
}
