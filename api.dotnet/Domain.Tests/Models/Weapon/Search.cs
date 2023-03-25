using Domain.Models;

using System;
using System.Collections.Generic;	
using System.Threading;	

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Weapon
	{
		public class FuncsSync
		{
			public Func<IEnumerable<IManufacturer>>? Manufacturers { get; set; }
		}			 
		public class FuncsAsync
		{
			public Func<IAsyncEnumerable<IManufacturer>>? Manufacturers { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IWeapon.ISearch.Default{ },
				Defaults.Models.Weapon,
				false,
				0
			},
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				true,
				2
			},
		};		  
		public static IEnumerable<object[]> SearchAsyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IWeapon.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IWeapon.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(IWeapon.ISearch), "")]
		public void Search(IWeapon.ISearch search, IWeapon weapon, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IWeapon.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IWeapon: ", weapon.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnWeapon(weapon);
			int actualmatchcount = search.GetMatchCount(weapon);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(IWeapon.ISearch), "")]
		public void SearchSync(IWeapon.ISearch search, IWeapon weapon, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IWeapon.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IWeapon: ", weapon.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnWeapon(weapon, funcs.Manufacturers);
			int actualmatchcount = search.GetMatchCount(weapon, funcs.Manufacturers);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(IWeapon.ISearch), "")]
		public async void SearchAsync(IWeapon.ISearch search, IWeapon weapon, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IWeapon.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IWeapon: ", weapon.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnWeaponAsync(weapon, funcs.Manufacturers, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(weapon, funcs.Manufacturers, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
