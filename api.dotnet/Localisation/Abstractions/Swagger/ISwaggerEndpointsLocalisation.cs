
namespace Localisation.Abstractions.Swagger
{
	public interface ISwaggerEndpointLocalisation<T>
	{
		T Description { get; set; }
		T OperationId { get; set; }
		T Summary { get; set; }
	}				 
	public interface ISwaggerEndpointLocalisation
	{
		public string? Description { get; set; }
		public string? OperationId { get; set; }
		public string? Summary { get; set; }

		#region Defaults

		public class Default : ISwaggerEndpointLocalisation
		{
			public string? Description { get; set; }
			public string? OperationId { get; set; }
			public string? Summary { get; set; }
		}
		public class Default<T> : ISwaggerEndpointLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				Description = defaultvalue;
				OperationId = defaultvalue;
				Summary = defaultvalue;
			}

			public T Description { get; set; }
			public T OperationId { get; set; }
			public T Summary { get; set; }
		}

		#endregion
	}
	public interface ISwaggerEndpointsLocalisation<T>
	{
		T Characters { get; set; }
		T Factions { get; set; }
		T Films { get; set; }
		T Manufacturers { get; set; }
		T Planets { get; set; }
		T Search { get; set; }		
		T Species { get; set; }
		T Starships { get; set; }
		T Vehicles { get; set; }
		T Weapons { get; set; }
		T Meta { get; set; }
	}
	public interface ISwaggerEndpointsLocalisation
	{
		ISwaggerEndpointLocalisation? Characters { get; set; }
		ISwaggerEndpointLocalisation? Factions { get; set; }
		ISwaggerEndpointLocalisation? Films { get; set; }
		ISwaggerEndpointLocalisation? Manufacturers { get; set; }
		ISwaggerEndpointLocalisation? Planets { get; set; }
		ISwaggerEndpointLocalisation? Search { get; set; }
		ISwaggerEndpointLocalisation? Species { get; set; }
		ISwaggerEndpointLocalisation? Starships { get; set; }
		ISwaggerEndpointLocalisation? Vehicles { get; set; }
		ISwaggerEndpointLocalisation? Weapons { get; set; }
		ISwaggerEndpointLocalisation? Meta { get; set; }

		#region Defaults

		public class Default : ISwaggerEndpointsLocalisation
		{
			public ISwaggerEndpointLocalisation? Characters { get; set; }
			public ISwaggerEndpointLocalisation? Factions { get; set; }
			public ISwaggerEndpointLocalisation? Films { get; set; }
			public ISwaggerEndpointLocalisation? Manufacturers { get; set; }
			public ISwaggerEndpointLocalisation? Planets { get; set; }
			public ISwaggerEndpointLocalisation? Search { get; set; }
			public ISwaggerEndpointLocalisation? Species { get; set; }
			public ISwaggerEndpointLocalisation? Starships { get; set; }
			public ISwaggerEndpointLocalisation? Vehicles { get; set; }
			public ISwaggerEndpointLocalisation? Weapons { get; set; }
			public ISwaggerEndpointLocalisation? Meta { get; set; }
		}
		public class Default<T> : ISwaggerEndpointsLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				Characters = defaultvalue;
				Factions = defaultvalue;
				Films = defaultvalue;
				Manufacturers = defaultvalue;
				Planets = defaultvalue;
				Search = defaultvalue;
				Species = defaultvalue;
				Starships = defaultvalue;
				Vehicles = defaultvalue;
				Weapons = defaultvalue;
				Meta = defaultvalue;
			}

			public T Characters { get; set; }
			public T Factions { get; set; }
			public T Films { get; set; }
			public T Manufacturers { get; set; }
			public T Planets { get; set; }
			public T Search { get; set; }
			public T Species { get; set; }
			public T Starships { get; set; }
			public T Vehicles { get; set; }
			public T Weapons { get; set; }
			public T Meta { get; set; }
		}

		#endregion
	}
}
