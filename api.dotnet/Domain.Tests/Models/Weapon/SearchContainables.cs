using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Weapon
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = true,
					Model = true,
					Name = true,
					WeaponClass = true,
					WeaponClassFlags = true,
				},
				false,
				0
			}, 

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = false,
					WeaponClass = false,
					WeaponClassFlags = false,
				},
				false,
				0
			},	  

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = true,
					Model = false,
					Name = false,
					WeaponClass = false,
					WeaponClassFlags = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = false,
					Model = true,
					Name = false,
					WeaponClass = false,
					WeaponClassFlags = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = true,
					WeaponClass = false,
					WeaponClassFlags = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = false,
					WeaponClass = true,
					WeaponClassFlags = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Weapon,
				new IWeapon.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = false,
					WeaponClass = false,
					WeaponClassFlags = true,
				},
				true,
				1
			},

			new object[]
			{
				Defaults.One.String,
				new IWeapon.Default(0)
				{
					Description = Defaults.One.String,
					Model = Defaults.One.String,
					Name = Defaults.One.String,
					WeaponClass = new IWeapon.IWeaponClass.Default
					{
						Class = Defaults.One.String,
						Flags = new string[] { Defaults.One.String, Defaults.One.String }
					},
				},
				new IWeapon.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = false,
					WeaponClass = false,
					WeaponClassFlags = true,
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(IWeapon.ISearchContainables), "")]
		public void SearchContainables(string searchstring, IWeapon weapon, IWeapon.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("IWeapon: ", weapon.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("IWeapon.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnWeapon(weapon, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
