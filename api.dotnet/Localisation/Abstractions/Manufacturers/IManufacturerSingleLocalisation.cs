using Domain.Models;

namespace Localisation.Abstractions.Manufacturers
{
	public interface IManufacturerSingleLocalisation<T> : IManufacturer<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T HeadquatersPlanetTitle { get; set; }
		T HeadquatersPlanetAbsentText { get; set; }

		T StarshipsTitle { get; set; }
		T StarshipsEmptyText { get; set; }

		T VehiclesTitle { get; set; }
		T VehiclesEmptyText { get; set; }

		T WeaponsTitle { get; set; }
		T WeaponsEmptyText { get; set; }
	}
	public interface IManufacturerSingleLocalisation : IManufacturer<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? HeadquatersPlanetTitle { get; set; }
		string? HeadquatersPlanetAbsentText { get; set; }

		string? StarshipsTitle { get; set; }
		string? StarshipsEmptyText { get; set; }

		string? VehiclesTitle { get; set; }
		string? VehiclesEmptyText { get; set; }

		string? WeaponsTitle { get; set; }
		string? WeaponsEmptyText { get; set; }

		#region Methods

		public static IManufacturerSingleLocalisation? FromManufacturer(IManufacturer<string?>? manufacturer)
			=> manufacturer == null
				? null
				: new Default
				{
					Uris = manufacturer.Uris,
					Created = manufacturer.Created,
					Edited = manufacturer.Edited,

					Description = manufacturer.Description,
					HeadquatersPlanetId = manufacturer.HeadquatersPlanetId,
					Name = manufacturer.Name,
					StarshipIds = manufacturer.StarshipIds,
					VehicleIds = manufacturer.VehicleIds,
					WeaponIds = manufacturer.WeaponIds,
				};

		#endregion

		#region Defaults

		public class Default : IManufacturer.Default<string?>, IManufacturerSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? HeadquatersPlanetTitle { get; set; }
			public string? HeadquatersPlanetAbsentText { get; set; }

			public string? StarshipsTitle { get; set; }
			public string? StarshipsEmptyText { get; set; }

			public string? VehiclesTitle { get; set; }
			public string? VehiclesEmptyText { get; set; }

			public string? WeaponsTitle { get; set; }
			public string? WeaponsEmptyText { get; set; }
		}
		public class Default<T> : IManufacturer.Default<T>, IManufacturerSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;

				HeadquatersPlanetTitle = defaultvalue;
				HeadquatersPlanetAbsentText = defaultvalue;

				StarshipsTitle = defaultvalue;
				StarshipsEmptyText = defaultvalue;

				VehiclesTitle = defaultvalue;
				VehiclesEmptyText = defaultvalue;

				WeaponsTitle = defaultvalue;
				WeaponsEmptyText = defaultvalue;
			}

			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T HeadquatersPlanetTitle { get; set; }
			public T HeadquatersPlanetAbsentText { get; set; }

			public T StarshipsTitle { get; set; }
			public T StarshipsEmptyText { get; set; }

			public T VehiclesTitle { get; set; }
			public T VehiclesEmptyText { get; set; }

			public T WeaponsTitle { get; set; }
			public T WeaponsEmptyText { get; set; }
		}

		#endregion
	}
}
