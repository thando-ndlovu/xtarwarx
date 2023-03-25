using Domain.Models;

using System;
using System.Collections.Generic;
using System.Threading;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Transporter
	{
		public class FuncsSync
		{
			public Func<IEnumerable<IManufacturer>>? Manufacturers { get; set; }
			public Func<IEnumerable<ICharacter>>? Pilots { get; set; }
		}	 
		public class FuncsAsync
		{
			public Func<IAsyncEnumerable<IManufacturer>>? Manufacturers { get; set; }
			public Func<IAsyncEnumerable<ICharacter>>? Pilots { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new ITransporter.ISearch.Default{ },
				Defaults.Models.Transporter,
				false,
				0
			},

			// CargoCapacities long
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Lower = Defaults.One.Long
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Upper = Defaults.One.Long
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.One.LongEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Lower = Defaults.Two.Long
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Upper = Defaults.Zero.Long
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.Zero.LongEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.Two.LongEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// CargoCapacities

			// Consumables ITransporter.IConsumable
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Lower = Defaults.One.TransporterConsumable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Upper = Defaults.One.TransporterConsumable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Values = Defaults.One.TransporterConsumableEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Lower = Defaults.Two.TransporterConsumable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Upper = Defaults.Zero.TransporterConsumable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Values = Defaults.Zero.TransporterConsumableEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Consumables = new IStarWarsModel.ISearchValues.Default<ITransporter.IConsumable?>(null)
					{
						Values = Defaults.Two.TransporterConsumableEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// Consumables
			
			// CostInCredits long
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Lower = Defaults.One.Long
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Upper = Defaults.One.Long
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.One.LongEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Lower = Defaults.Two.Long
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Upper = Defaults.Zero.Long
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.Zero.LongEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.Two.LongEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// CostInCredits
			
			// Lengths double
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.One.Double
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.One.Double
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.One.DoubleEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.Two.Double
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.Zero.Double
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Zero.DoubleEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Two.DoubleEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// Lengths
			
			// MaxAtmospheringSpeeds int
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// MaxAtmospheringSpeeds
			
			// MaxCrews int
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// MaxCrews

			// MinCrews int
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// MinCrews
			
			// Passengers int
			#region
			// true
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Transporter,
				false,
				0
			},
			// false
			#endregion
			// Passengers
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync
				{
					Manufacturers = () => Defaults.Models.ManufacturerEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync
				{
					Pilots = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync
				{
					Pilots = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsSync
				{
					Pilots = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},
		};
		public static IEnumerable<object[]> SearchAsyncMemberData => new List<object[]>
		{
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync
				{
					Manufacturers = () => Defaults.Models.ManufacturerAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync
				{
					Pilots = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync
				{
					Pilots = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new ITransporter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IStarship.Default(0) { },
				new FuncsAsync
				{
					Pilots = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(ITransporter.ISearch), "")]
		public void Search(ITransporter.ISearch search, ITransporter transporter, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ITransporter.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ITransporter: ", transporter.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnTransporter(transporter, false);
			int actualmatchcount = search.GetMatchCount(transporter, false);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}  

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(ITransporter.ISearch), "")]
		public void SearchSync(ITransporter.ISearch search, ITransporter transporter, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ITransporter.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ITransporter: ", transporter.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnTransporter(transporter, false, funcs.Manufacturers, funcs.Pilots);
			int actualmatchcount = search.GetMatchCount(transporter, false, funcs.Manufacturers, funcs.Pilots);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}  

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(ITransporter.ISearch), "")]
		public async void SearchAsync(ITransporter.ISearch search, ITransporter transporter, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ITransporter.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ITransporter: ", transporter.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnTransporterAsync(transporter, false, funcs.Manufacturers, funcs.Pilots, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(transporter, false, funcs.Manufacturers, funcs.Pilots, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
