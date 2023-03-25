using Domain.Models;

namespace Localisation.Abstractions.Vehicles
{
	public interface IVehicleSingleLocalisation<T> : IVehicle<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T ManufacturersTitle { get; set; }
		T ManufacturersEmptyText { get; set; }

		T PilotsTitle { get; set; }
		T PilotsEmptyText { get; set; }
	}
	public interface IVehicleSingleLocalisation : IVehicle<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? ManufacturersTitle { get; set; }
		string? ManufacturersEmptyText { get; set; }

		string? PilotsTitle { get; set; }
		string? PilotsEmptyText { get; set; }

		#region Methods

		public static IVehicleSingleLocalisation? FromVehicle(IVehicle<string?>? starship)
			=> starship == null
				? null
				: new Default
				{
					Uris = starship.Uris,
					Created = starship.Created,
					Edited = starship.Edited,

					VehicleClass = starship.VehicleClass,

					CargoCapacity = starship.CargoCapacity,
					Consumables = starship.Consumables,
					CostInCredits = starship.CostInCredits,
					Description = starship.Description,
					Length = starship.Length,
					ManufacturerIds = starship.ManufacturerIds,
					MaxAtmospheringSpeed = starship.MaxAtmospheringSpeed,
					MaxCrew = starship.MaxCrew,
					MinCrew = starship.MinCrew,
					Model = starship.Model,
					Name = starship.Name,
					Passengers = starship.Passengers,
					PilotIds = starship.PilotIds,
				};

		#endregion

		#region Defaults

		public class Default : IVehicle.Default<string?>, IVehicleSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? ManufacturersTitle { get; set; }
			public string? ManufacturersEmptyText { get; set; }

			public string? PilotsTitle { get; set; }
			public string? PilotsEmptyText { get; set; }
		}
		public class Default<T> : IVehicle.Default<T>, IVehicleSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;

				ManufacturersTitle = defaultvalue;
				ManufacturersEmptyText = defaultvalue;

				PilotsTitle = defaultvalue;
				PilotsEmptyText = defaultvalue;
			}

			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T ManufacturersTitle { get; set; }
			public T ManufacturersEmptyText { get; set; }

			public T PilotsTitle { get; set; }
			public T PilotsEmptyText { get; set; }
		}

		#endregion
	}
}
