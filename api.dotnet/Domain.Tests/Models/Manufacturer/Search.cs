using Domain.Models;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Manufacturer
	{
		public class FuncsSync
		{
			public Func<IPlanet?>? HeadquatersPlanet { get; set; }
			public Func<IEnumerable<IStarship>>? Starships { get; set; }
			public Func<IEnumerable<IVehicle>>? Vehicles { get; set; }
			public Func<IEnumerable<IWeapon>>? Weapons { get; set; }
		}	 
		public class FuncsAsync
		{
			public Func<Task<IPlanet?>>? HeadquatersPlanet { get; set; }
			public Func<IAsyncEnumerable<IStarship>>? Starships { get; set; }
			public Func<IAsyncEnumerable<IVehicle>>? Vehicles { get; set; }
			public Func<IAsyncEnumerable<IWeapon>>? Weapons { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IManufacturer.ISearch.Default{ },
				Defaults.Models.Manufacturer,
				false,
				0
			},
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.One.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					HeadquatersPlanet = () => Defaults.Models.Planet,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.One.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					HeadquatersPlanet = () => Defaults.Models.Planet,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.One.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					HeadquatersPlanet = () => Defaults.Models.Planet,
				},
				true,
				2
			},

			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Starships = () => Defaults.Models.StarshipEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Starships = () => Defaults.Models.StarshipEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Starships = () => Defaults.Models.StarshipEnumerable,
				},
				true,
				5
			},

			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Vehicles = () => Defaults.Models.VehicleEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Vehicles = () => Defaults.Models.VehicleEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Vehicles = () => Defaults.Models.VehicleEnumerable,
				},
				true,
				5
			},

			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Weapons = () => Defaults.Models.WeaponEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsSync
				{
					Weapons = () => Defaults.Models.WeaponEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
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
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.One.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					HeadquatersPlanet = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.One.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					HeadquatersPlanet = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
				{
					SearchString = Defaults.One.String,

					HeadquatersPlanet = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					HeadquatersPlanet = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				true,
				2
			},

			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Starships = () => Defaults.Models.StarshipAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Starships = () => Defaults.Models.StarshipAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Starships = () => Defaults.Models.StarshipAsyncEnumerable(),
				},
				true,
				5
			},

			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Vehicles = () => Defaults.Models.VehicleAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Vehicles = () => Defaults.Models.VehicleAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Vehicles = () => Defaults.Models.VehicleAsyncEnumerable(),
				},
				true,
				5
			},

			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Weapons = () => Defaults.Models.WeaponAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
				new FuncsAsync
				{
					Weapons = () => Defaults.Models.WeaponAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IManufacturer.ISearch.Default
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
				new IManufacturer.Default(0) { },
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
		[Trait(nameof(IManufacturer.ISearch), "")]
		public void Search(IManufacturer.ISearch search, IManufacturer manufacturer, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IManufacturer.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IManufacturer: ", manufacturer.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnManufacturer(manufacturer);
			int actualmatchcount = search.GetMatchCount(manufacturer);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(IManufacturer.ISearch), "")]
		public void SearchSync(IManufacturer.ISearch search, IManufacturer manufacturer, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IManufacturer.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IManufacturer: ", manufacturer.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnManufacturer(manufacturer, funcs.HeadquatersPlanet, funcs.Starships, funcs.Vehicles, funcs.Weapons);
			int actualmatchcount = search.GetMatchCount(manufacturer, funcs.HeadquatersPlanet, funcs.Starships, funcs.Vehicles, funcs.Weapons);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(IManufacturer.ISearch), "")]
		public async void SearchAsync(IManufacturer.ISearch search, IManufacturer manufacturer, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IManufacturer.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IManufacturer: ", manufacturer.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnManufacturerAsync(manufacturer, funcs.HeadquatersPlanet, funcs.Starships, funcs.Vehicles, funcs.Weapons, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(manufacturer, funcs.HeadquatersPlanet, funcs.Starships, funcs.Vehicles, funcs.Weapons, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
