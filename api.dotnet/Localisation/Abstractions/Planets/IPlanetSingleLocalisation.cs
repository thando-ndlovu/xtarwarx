using Domain.Models;

namespace Localisation.Abstractions.Planets
{
	public interface IPlanetSingleLocalisation<T> : IPlanet<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T ResidentsTitle { get; set; }
		T ResidentsEmptyText { get; set; }
	}
	public interface IPlanetSingleLocalisation : IPlanet<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? ResidentsTitle { get; set; }
		string? ResidentsEmptyText { get; set; }

		#region Methods

		public static IPlanetSingleLocalisation? FromPlanet(IPlanet<string?>? planet)
			=> planet == null
				? null
				: new Default
				{
					Uris = planet.Uris,
					Created = planet.Created,
					Edited = planet.Edited,

					Climates = planet.Climates,
					Description = planet.Description,
					Diameter = planet.Diameter,
					Gravity = planet.Gravity,
					Name = planet.Name,
					OrbitalPeriod = planet.OrbitalPeriod,
					Population = planet.Population,
					ResidentIds = planet.ResidentIds,
					RotationalPeriod = planet.RotationalPeriod,
					SurfaceWater = planet.SurfaceWater,
					Terrains = planet.Terrains,
				};

		#endregion

		#region Defaults

		public class Default : IPlanet.Default<string?>, IPlanetSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? ResidentsTitle { get; set; }
			public string? ResidentsEmptyText { get; set; }
		}
		public class Default<T> : IPlanet.Default<T>, IPlanetSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;

				ResidentsTitle = defaultvalue;
				ResidentsEmptyText = defaultvalue;
			}

			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T ResidentsTitle { get; set; }
			public T ResidentsEmptyText { get; set; }
		}

		#endregion
	}
}