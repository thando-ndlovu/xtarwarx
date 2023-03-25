using Domain.Models;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Tests.Models
{
	public static class Defaults
	{
		public static class Zero
		{
			public static readonly bool Bool = false;
			public static readonly DateTime DateTime = DateTime.Parse("1995-12-07");
			public static readonly double Double = 0.0;
			public static readonly int Int = 0;
			public static readonly KnownColor KnownColor = KnownColor.Black;
			public static readonly long Long = 0;
			public static readonly string String = "Zero";
			public static readonly string TimeUnit = ITransporter.IConsumable.TimeUnits.Hour;
			public static readonly TimeSpan TimeSpan = TimeSpan.FromMinutes(1);

			public static readonly IEnumerable<DateTime?> DateTimeEnumerable = Enumerable.Empty<DateTime?>().Append(DateTime);
			public static readonly IEnumerable<double?> DoubleEnumerable = Enumerable.Empty<double?>().Append(Double);
			public static readonly IEnumerable<int?> IntEnumerable = Enumerable.Empty<int?>().Append(Int);
			public static readonly IEnumerable<KnownColor?> KnownColorEnumerable = Enumerable.Empty<KnownColor?>().Append(KnownColor);
			public static readonly IEnumerable<long?> LongEnumerable = Enumerable.Empty<long?>().Append(Long);
			public static readonly IEnumerable<string?> StringEnumerable = Enumerable.Empty<string?>().Append(String);
			public static readonly IEnumerable<TimeSpan?> TimeSpanEnumerable = Enumerable.Empty<TimeSpan?>().Append(TimeSpan);

			public static readonly IPlanet.IClimate PlanetClimate = new IPlanet.IClimate.Default
			{
				Type = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly IPlanet.ITerrain PlanetTerrain = new IPlanet.ITerrain.Default
			{
				Type = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly ITransporter.IConsumable TransporterConsumable = new ITransporter.IConsumable.Default
			{
				TimeUnit = TimeUnit,
				Value = Int
			};		 	  
			public static readonly IStarship.IStarshipClass StarshipClass = new IStarship.IStarshipClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};		 
			public static readonly IVehicle.IVehicleClass VehicleClass = new IVehicle.IVehicleClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};		 
			public static readonly IWeapon.IWeaponClass WeaponClass = new IWeapon.IWeaponClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};

			public static readonly IEnumerable<IPlanet.IClimate> PlanetClimateEnumerable = Enumerable.Empty<IPlanet.IClimate>();
			public static readonly IEnumerable<IPlanet.ITerrain> PlanetTerrainEnumerable = Enumerable.Empty<IPlanet.ITerrain>();
			public static readonly IEnumerable<ITransporter.IConsumable> TransporterConsumableEnumerable = Enumerable.Empty<ITransporter.IConsumable>();
			public static readonly IEnumerable<IStarship.IStarshipClass> StarshipClassEnumerable = Enumerable.Empty<IStarship.IStarshipClass>();
			public static readonly IEnumerable<IVehicle.IVehicleClass> VehicleClassEnumerable = Enumerable.Empty<IVehicle.IVehicleClass>();
			public static readonly IEnumerable<IWeapon.IWeaponClass> WeaponClassEnumerable = Enumerable.Empty<IWeapon.IWeaponClass>();
		}	  
		public static class One
		{
			public static readonly bool Bool = true;
			public static readonly DateTime DateTime = DateTime.Parse("2000-01-01");
			public static readonly double Double = 1.0;
			public static readonly int Int = 1;
			public static readonly KnownColor KnownColor = KnownColor.White;
			public static readonly long Long = 1;
			public static readonly string String = "One";
			public static readonly string TimeUnit = ITransporter.IConsumable.TimeUnits.Month;
			public static readonly TimeSpan TimeSpan = TimeSpan.FromMinutes(2);

			public static readonly IEnumerable<DateTime?> DateTimeEnumerable = Enumerable.Empty<DateTime?>().Append(DateTime);
			public static readonly IEnumerable<double?> DoubleEnumerable = Enumerable.Empty<double?>().Append(Double);
			public static readonly IEnumerable<int?> IntEnumerable = Enumerable.Empty<int?>().Append(Int);
			public static readonly IEnumerable<KnownColor?> KnownColorEnumerable = Enumerable.Empty<KnownColor?>().Append(KnownColor);
			public static readonly IEnumerable<long?> LongEnumerable = Enumerable.Empty<long?>().Append(Long);
			public static readonly IEnumerable<string?> StringEnumerable = Enumerable.Empty<string?>().Append(String);
			public static readonly IEnumerable<TimeSpan?> TimeSpanEnumerable = Enumerable.Empty<TimeSpan?>().Append(TimeSpan);

			public static readonly IPlanet.IClimate PlanetClimate = new IPlanet.IClimate.Default
			{
				Type = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly IPlanet.ITerrain PlanetTerrain = new IPlanet.ITerrain.Default
			{
				Type = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly ITransporter.IConsumable TransporterConsumable = new ITransporter.IConsumable.Default
			{
				TimeUnit = TimeUnit,
				Value = Int
			};		 	  
			public static readonly IStarship.IStarshipClass StarshipClass = new IStarship.IStarshipClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};		 
			public static readonly IVehicle.IVehicleClass VehicleClass = new IVehicle.IVehicleClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};		 
			public static readonly IWeapon.IWeaponClass WeaponClass = new IWeapon.IWeaponClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};

			public static readonly IEnumerable<IPlanet.IClimate> PlanetClimateEnumerable = Enumerable.Empty<IPlanet.IClimate>().Append(PlanetClimate);
			public static readonly IEnumerable<IPlanet.ITerrain> PlanetTerrainEnumerable = Enumerable.Empty<IPlanet.ITerrain>().Append(PlanetTerrain);
			public static readonly IEnumerable<ITransporter.IConsumable> TransporterConsumableEnumerable = Enumerable.Empty<ITransporter.IConsumable>().Append(TransporterConsumable);
			public static readonly IEnumerable<IStarship.IStarshipClass> StarshipClassEnumerable = Enumerable.Empty<IStarship.IStarshipClass>().Append(StarshipClass);
			public static readonly IEnumerable<IVehicle.IVehicleClass> VehicleClassEnumerable = Enumerable.Empty<IVehicle.IVehicleClass>().Append(VehicleClass);
			public static readonly IEnumerable<IWeapon.IWeaponClass> WeaponClassEnumerable = Enumerable.Empty<IWeapon.IWeaponClass>().Append(WeaponClass);
		}
		public static class Two
		{
			public static readonly DateTime DateTime = DateTime.Parse("2010-01-01");
			public static readonly double Double = 2.0;
			public static readonly int Int = 2;
			public static readonly KnownColor KnownColor = KnownColor.Gray;
			public static readonly long Long = 2;
			public static readonly string String = "Two";
			public static readonly string TimeUnit = ITransporter.IConsumable.TimeUnits.Year;
			public static readonly TimeSpan TimeSpan = TimeSpan.FromMinutes(3);

			public static readonly IEnumerable<DateTime?> DateTimeEnumerable = Enumerable.Empty<DateTime?>().Append(DateTime);
			public static readonly IEnumerable<double?> DoubleEnumerable = Enumerable.Empty<double?>().Append(Double);
			public static readonly IEnumerable<int?> IntEnumerable = Enumerable.Empty<int?>().Append(Int);
			public static readonly IEnumerable<KnownColor?> KnownColorEnumerable = Enumerable.Empty<KnownColor?>().Append(KnownColor);
			public static readonly IEnumerable<long?> LongEnumerable = Enumerable.Empty<long?>().Append(Long);
			public static readonly IEnumerable<string?> StringEnumerable = Enumerable.Empty<string?>().Append(String);
			public static readonly IEnumerable<TimeSpan?> TimeSpanEnumerable = Enumerable.Empty<TimeSpan?>().Append(TimeSpan);

			public static readonly IPlanet.IClimate PlanetClimate = new IPlanet.IClimate.Default
			{
				Type = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly IPlanet.ITerrain PlanetTerrain = new IPlanet.ITerrain.Default
			{
				Type = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly ITransporter.IConsumable TransporterConsumable = new ITransporter.IConsumable.Default
			{
				TimeUnit = TimeUnit,
				Value = Int
			};
			public static readonly IStarship.IStarshipClass StarshipClass = new IStarship.IStarshipClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly IVehicle.IVehicleClass VehicleClass = new IVehicle.IVehicleClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};
			public static readonly IWeapon.IWeaponClass WeaponClass = new IWeapon.IWeaponClass.Default
			{
				Class = String,
				Flags = StringEnumerable.OfType<string>()
			};

			public static readonly IEnumerable<IPlanet.IClimate> PlanetClimateEnumerable = Enumerable.Empty<IPlanet.IClimate>().Append(PlanetClimate);
			public static readonly IEnumerable<IPlanet.ITerrain> PlanetTerrainEnumerable = Enumerable.Empty<IPlanet.ITerrain>().Append(PlanetTerrain);
			public static readonly IEnumerable<ITransporter.IConsumable> TransporterConsumableEnumerable = Enumerable.Empty<ITransporter.IConsumable>().Append(TransporterConsumable);
			public static readonly IEnumerable<IStarship.IStarshipClass> StarshipClassEnumerable = Enumerable.Empty<IStarship.IStarshipClass>().Append(StarshipClass);
			public static readonly IEnumerable<IVehicle.IVehicleClass> VehicleClassEnumerable = Enumerable.Empty<IVehicle.IVehicleClass>().Append(VehicleClass);
			public static readonly IEnumerable<IWeapon.IWeaponClass> WeaponClassEnumerable = Enumerable.Empty<IWeapon.IWeaponClass>().Append(WeaponClass);
		}

		public static class Models
		{
			public static readonly ICharacter Character = new ICharacter.Default(0)
			{
				BirthYear = One.Double,
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				EyeColors = One.KnownColorEnumerable.OfType<KnownColor>(),
				HairColors = One.KnownColorEnumerable.OfType<KnownColor>(),
				Height = One.Int,
				HomeworldId = One.Int,
				Mass = One.Int,
				Name = One.String,
				Sex = One.String,
				SkinColors = One.KnownColorEnumerable.OfType<KnownColor>(),
			};
			public static readonly IFaction Faction = new IFaction.Default(One.Int)
			{
				AlliedCharacterIds = One.IntEnumerable.OfType<int>(),
				AlliedFactionIds = One.IntEnumerable.OfType<int>(),
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				LeaderIds = One.IntEnumerable.OfType<int>(),
				MemberCharacterIds = One.IntEnumerable.OfType<int>(),
				MemberFactionIds = One.IntEnumerable.OfType<int>(),
				Name = One.String,
				OrganizationTypes = One.StringEnumerable.OfType<string>()
			};
			public static readonly IFilm Film = new IFilm.Default(One.Int)
			{
				CastMembers = One.StringEnumerable.OfType<string>(),
				CharacterIds = One.IntEnumerable.OfType<int>(),
				Created = One.DateTime,
				Description = One.String,
				Director = One.String,
				Duration = One.TimeSpan,
				Edited = One.DateTime,
				EpisodeId = One.Int,
				FactionIds = One.IntEnumerable.OfType<int>(),
				ManufacturerIds = One.IntEnumerable.OfType<int>(),
				OpeningCrawl = One.String,
				Producers = One.StringEnumerable.OfType<string>(),
				PlanetIds = One.IntEnumerable.OfType<int>(),
				ReleaseDate = One.DateTime,
				SpecieIds = One.IntEnumerable.OfType<int>(),
				StarshipIds = One.IntEnumerable.OfType<int>(),
				Title = One.String,
				VehicleIds = One.IntEnumerable.OfType<int>(),
				WeaponIds = One.IntEnumerable.OfType<int>(),
			};
			public static readonly IManufacturer Manufacturer = new IManufacturer.Default(One.Int)
			{
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				HeadquatersPlanetId = One.Int,
				Name = One.String,
				StarshipIds = One.IntEnumerable.OfType<int>(),
				VehicleIds = One.IntEnumerable.OfType<int>(),
				WeaponIds = One.IntEnumerable.OfType<int>(),
			};
			public static readonly IPlanet Planet = new IPlanet.Default(One.Int)
			{
				Climates = One.PlanetClimateEnumerable,
				Created = One.DateTime,
				Description = One.String,
				Diameter = One.Int,
				Edited = One.DateTime,
				Gravity = One.Double,
				Name = One.String,
				OrbitalPeriod = One.TimeSpan,
				Population = One.Long,
				ResidentIds = One.IntEnumerable.OfType<int>(),
				RotationalPeriod = One.TimeSpan,
				SurfaceWater = One.Double,
				Terrains = One.PlanetTerrainEnumerable,
			};
			public static readonly ISpecie Specie = new ISpecie.Default(One.Int)
			{
				AverageHeight = One.Int,
				AverageLifespan = One.Int,
				CharacterIds = One.IntEnumerable.OfType<int>(),
				Classification = One.String,
				Created = One.DateTime,
				Description = One.String,
				Designation = One.String,
				Edited = One.DateTime,
				EyeColors = One.KnownColorEnumerable.OfType<KnownColor>(),
				HairColors = One.KnownColorEnumerable.OfType<KnownColor>(),
				HomeworldId = One.Int,
				Language = One.String,
				Name = One.String,
				SkinColors = One.KnownColorEnumerable.OfType<KnownColor>(),
			};
			public static readonly IStarship Starship = new IStarship.Default(One.Int)
			{
				CargoCapacity = One.Long,
				Consumables = One.TransporterConsumable,
				CostInCredits = One.Long,
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				HyperdriveRating = One.Double,
				Length = One.Double,
				ManufacturerIds = One.IntEnumerable.OfType<int>(),
				MaxAtmospheringSpeed = One.Int,
				MaxCrew = One.Int,
				MinCrew = One.Int,
				Model = One.String,
				MGLT = One.Int,
				Name = One.String,
				Passengers = One.Int,
				PilotIds = One.IntEnumerable.OfType<int>(),
				StarshipClass = One.StarshipClass,
			};
			public static readonly ITransporter Transporter = new ITransporter.Default(One.Int)
			{
				CargoCapacity = One.Long,
				Consumables = One.TransporterConsumable,
				CostInCredits = One.Long,
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				Length = One.Double,
				ManufacturerIds = One.IntEnumerable.OfType<int>(),
				MaxAtmospheringSpeed = One.Int,
				MaxCrew = One.Int,
				MinCrew = One.Int,
				Model = One.String,
				Name = One.String,
				Passengers = One.Int,
				PilotIds = One.IntEnumerable.OfType<int>(),
			};
			public static readonly IVehicle Vehicle = new IVehicle.Default(One.Int)
			{
				CargoCapacity = One.Long,
				Consumables = One.TransporterConsumable,
				CostInCredits = One.Long,
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				Length = One.Double,
				ManufacturerIds = One.IntEnumerable.OfType<int>(),
				MaxAtmospheringSpeed = One.Int,
				MaxCrew = One.Int,
				MinCrew = One.Int,
				Model = One.String,
				Name = One.String,
				Passengers = One.Int,
				PilotIds = One.IntEnumerable.OfType<int>(),
				VehicleClass = One.VehicleClass,
			};
			public static readonly IWeapon Weapon = new IWeapon.Default(One.Int)
			{
				Created = One.DateTime,
				Description = One.String,
				Edited = One.DateTime,
				Model = One.String,
				Name = One.String,
				WeaponClass = One.WeaponClass,
			};

			public static readonly IEnumerable<ICharacter> CharacterEnumerable = Enumerable.Empty<ICharacter>().Append(Character);
			public static readonly IEnumerable<IFaction> FactionEnumerable = Enumerable.Empty<IFaction>().Append(Faction);
			public static readonly IEnumerable<IFilm> FilmEnumerable = Enumerable.Empty<IFilm>().Append(Film);
			public static readonly IEnumerable<IManufacturer> ManufacturerEnumerable = Enumerable.Empty<IManufacturer>().Append(Manufacturer);
			public static readonly IEnumerable<IPlanet> PlanetEnumerable = Enumerable.Empty<IPlanet>().Append(Planet);
			public static readonly IEnumerable<ISpecie> SpecieEnumerable = Enumerable.Empty<ISpecie>().Append(Specie);
			public static readonly IEnumerable<IStarship> StarshipEnumerable = Enumerable.Empty<IStarship>().Append(Starship);
			public static readonly IEnumerable<ITransporter> TransporterEnumerable = Enumerable.Empty<ITransporter>().Append(Transporter);
			public static readonly IEnumerable<IVehicle> VehicleEnumerable = Enumerable.Empty<IVehicle>().Append(Vehicle);
			public static readonly IEnumerable<IWeapon> WeaponEnumerable = Enumerable.Empty<IWeapon>().Append(Weapon);

			public static async IAsyncEnumerable<ICharacter> CharacterAsyncEnumerable()
			{
				foreach (ICharacter Character in CharacterEnumerable)
					yield return await Task.FromResult(Character);
			}
			public static async IAsyncEnumerable<IFaction> FactionAsyncEnumerable()
			{
				foreach (IFaction Faction in FactionEnumerable)
					yield return await Task.FromResult(Faction);
			}
			public static async IAsyncEnumerable<IFilm> FilmAsyncEnumerable()
			{
				foreach (IFilm Film in FilmEnumerable)
					yield return await Task.FromResult(Film);
			}
			public static async IAsyncEnumerable<IManufacturer> ManufacturerAsyncEnumerable()
			{
				foreach (IManufacturer Manufacturer in ManufacturerEnumerable)
					yield return await Task.FromResult(Manufacturer);
			}
			public static async IAsyncEnumerable<IPlanet> PlanetAsyncEnumerable()
			{
				foreach (IPlanet Planet in PlanetEnumerable)
					yield return await Task.FromResult(Planet);
			}
			public static async IAsyncEnumerable<ISpecie> SpecieAsyncEnumerable()
			{
				foreach (ISpecie Specie in SpecieEnumerable)
					yield return await Task.FromResult(Specie);
			}
			public static async IAsyncEnumerable<IStarship> StarshipAsyncEnumerable()
			{
				foreach (IStarship Starship in StarshipEnumerable)
					yield return await Task.FromResult(Starship);
			}
			public static async IAsyncEnumerable<ITransporter> TransporterAsyncEnumerable()
			{
				foreach (ITransporter Transporter in TransporterEnumerable)
					yield return await Task.FromResult(Transporter);
			}
			public static async IAsyncEnumerable<IVehicle> VehicleAsyncEnumerable()
			{
				foreach (IVehicle Vehicle in VehicleEnumerable)
					yield return await Task.FromResult(Vehicle);
			}
			public static async IAsyncEnumerable<IWeapon> WeaponAsyncEnumerable()
			{
				foreach (IWeapon Weapon in WeaponEnumerable)
					yield return await Task.FromResult(Weapon);
			}
		}
	}
}
