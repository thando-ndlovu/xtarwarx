using Domain.Models;

using System;
using System.Collections.Generic;
using System.Threading;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Film
	{
		public class FuncsSync
		{
			public Func<IEnumerable<ICharacter>>? Characters { get; set; }
			public Func<IEnumerable<IFaction>>? Factions { get; set; }
			public Func<IEnumerable<IManufacturer>>? Manufacturers { get; set; }
			public Func<IEnumerable<IPlanet>>? Planets { get; set; }
			public Func<IEnumerable<ISpecie>>? Species { get; set; }
			public Func<IEnumerable<IStarship>>? Starships { get; set; }
			public Func<IEnumerable<IVehicle>>? Vehicles { get; set; }
			public Func<IEnumerable<IWeapon>>? Weapons { get; set; }
		}	
		public class FuncsAsync
		{
			public Func<IAsyncEnumerable<ICharacter>>? Characters { get; set; }
			public Func<IAsyncEnumerable<IFaction>>? Factions { get; set; }
			public Func<IAsyncEnumerable<IManufacturer>>? Manufacturers { get; set; }
			public Func<IAsyncEnumerable<IPlanet>>? Planets { get; set; }
			public Func<IAsyncEnumerable<ISpecie>>? Species { get; set; }
			public Func<IAsyncEnumerable<IStarship>>? Starships { get; set; }
			public Func<IAsyncEnumerable<IVehicle>>? Vehicles { get; set; }
			public Func<IAsyncEnumerable<IWeapon>>? Weapons { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IFilm.ISearch.Default{ },
				Defaults.Models.Film,
				false,
				0
			},	   

			// Durations TimeSpan
			#region
			// true
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Lower = Defaults.One.TimeSpan
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Upper = Defaults.One.TimeSpan
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.One.TimeSpanEnumerable
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Lower = Defaults.Two.TimeSpan
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Upper = Defaults.Zero.TimeSpan
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.Zero.TimeSpanEnumerable
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.Two.TimeSpanEnumerable
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			// false
			#endregion
			// Durations

			// EpisodeIds int
			#region
			// true
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			// false
			#endregion
			// EpisodeIds

			// ReleaseDates DateTime
			#region
			// true
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Lower = Defaults.One.DateTime
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Upper = Defaults.One.DateTime
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Values = new DateTime?[] { Defaults.One.DateTime }
					}
				},
				Defaults.Models.Film,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Lower = Defaults.Two.DateTime
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Upper = Defaults.Zero.DateTime
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Values = new DateTime?[] { Defaults.Zero.DateTime }
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(null)
					{
						Values = new DateTime?[] { Defaults.Two.DateTime }
					}
				},
				Defaults.Models.Film,
				false,
				0
			},
			// false
			#endregion
			// ReleaseDates
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Characters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Characters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Characters = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = false,
						Name = false,
						OrganizationTypes = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Factions = () => Defaults.Models.FactionEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Factions = () => Defaults.Models.FactionEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Factions = () => Defaults.Models.FactionEnumerable,
				},
				true,
				3
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Planets = () => Defaults.Models.PlanetEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Planets = () => Defaults.Models.PlanetEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Planets = () => Defaults.Models.PlanetEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Species = () => Defaults.Models.SpecieEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Species = () => Defaults.Models.SpecieEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Species = () => Defaults.Models.SpecieEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = false,
						Model = false,
						Name = false,
						StarshipClass = false,
						StarshipClassFlags = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Starships = () => Defaults.Models.StarshipEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						StarshipClass = true,
						StarshipClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						StarshipClass = true,
						StarshipClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Starships = () => Defaults.Models.StarshipEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						StarshipClass = true,
						StarshipClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Starships = () => Defaults.Models.StarshipEnumerable,
				},
				true,
				5
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = false,
						Model = false,
						Name = false,
						VehicleClass = false,
						VehicleClassFlags = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Vehicles = () => Defaults.Models.VehicleEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						VehicleClass = true,
						VehicleClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						VehicleClass = true,
						VehicleClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Vehicles = () => Defaults.Models.VehicleEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						VehicleClass = true,
						VehicleClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Vehicles = () => Defaults.Models.VehicleEnumerable,
				},
				true,
				5
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = false,
						Model = false,
						Name = false,
						WeaponClass = false,
						WeaponClassFlags = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Weapons = () => Defaults.Models.WeaponEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						WeaponClass = true,
						WeaponClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						WeaponClass = true,
						WeaponClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Weapons = () => Defaults.Models.WeaponEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						WeaponClass = true,
						WeaponClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsSync
				{
					Weapons = () => Defaults.Models.WeaponEnumerable,
				},
				true,
				5
			},
		};
		public static IEnumerable<object[]> SearchAsyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Characters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Characters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Characters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = false,
						Name = false,
						OrganizationTypes = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Factions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Factions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Factions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Factions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				true,
				3
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Planets = () => Defaults.Models.PlanetAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Planets = () => Defaults.Models.PlanetAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Planets = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Planets = () => Defaults.Models.PlanetAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Species = () => Defaults.Models.SpecieAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Species = () => Defaults.Models.SpecieAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Species = new ISpecie.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Species = () => Defaults.Models.SpecieAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = false,
						Model = false,
						Name = false,
						StarshipClass = false,
						StarshipClassFlags = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Starships = () => Defaults.Models.StarshipAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						StarshipClass = true,
						StarshipClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						StarshipClass = true,
						StarshipClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Starships = () => Defaults.Models.StarshipAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Starships = new IStarship.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						StarshipClass = true,
						StarshipClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Starships = () => Defaults.Models.StarshipAsyncEnumerable(),
				},
				true,
				5
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = false,
						Model = false,
						Name = false,
						VehicleClass = false,
						VehicleClassFlags = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Vehicles = () => Defaults.Models.VehicleAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						VehicleClass = true,
						VehicleClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						VehicleClass = true,
						VehicleClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Vehicles = () => Defaults.Models.VehicleAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Vehicles = new IVehicle.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						VehicleClass = true,
						VehicleClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Vehicles = () => Defaults.Models.VehicleAsyncEnumerable(),
				},
				true,
				5
			},

			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = false,
						Model = false,
						Name = false,
						WeaponClass = false,
						WeaponClassFlags = false,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Weapons = () => Defaults.Models.WeaponAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						WeaponClass = true,
						WeaponClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						WeaponClass = true,
						WeaponClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Weapons = () => Defaults.Models.WeaponAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFilm.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Weapons = new IWeapon.ISearchContainables.Default
					{
						Description = true,
						Model = true,
						Name = true,
						WeaponClass = true,
						WeaponClassFlags = true,
					},
				},
				new IFilm.Default(0) { },
				new FuncsAsync
				{
					Weapons = () => Defaults.Models.WeaponAsyncEnumerable(),
				},
				true,
				5
			},
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(IFilm.ISearch), "")]
		public void Search(IFilm.ISearch search, IFilm film, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IFilm.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IFilm: ", film.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnFilm(film);
			int actualmatchcount = search.GetMatchCount(film);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}	 

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(IFilm.ISearch), "")]
		public void SearchSync(IFilm.ISearch search, IFilm film, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IFilm.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IFilm: ", film.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnFilm(film, funcs.Characters, funcs.Factions, funcs.Manufacturers, funcs.Planets, funcs.Species, funcs.Starships, funcs.Vehicles, funcs.Weapons);
			int actualmatchcount = search.GetMatchCount(film, funcs.Characters, funcs.Factions, funcs.Manufacturers, funcs.Planets, funcs.Species, funcs.Starships, funcs.Vehicles, funcs.Weapons);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}	 

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(IFilm.ISearch), "")]
		public async void SearchAsync(IFilm.ISearch search, IFilm film, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IFilm.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IFilm: ", film.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnFilmAsync(film, funcs.Characters, funcs.Factions, funcs.Manufacturers, funcs.Planets, funcs.Species, funcs.Starships, funcs.Vehicles, funcs.Weapons, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(film, funcs.Characters, funcs.Factions, funcs.Manufacturers, funcs.Planets, funcs.Species, funcs.Starships, funcs.Vehicles, funcs.Weapons, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
