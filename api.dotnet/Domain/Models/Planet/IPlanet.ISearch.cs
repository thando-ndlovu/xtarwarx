using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IPlanet
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T ClimateTypes { get; set; }
			T ClimateFlags { get; set; }
			T Diameters { get; set; }
			T Gravities { get; set; }
			T OrbitalPeriods { get; set; }
			T Populations { get; set; }
			T Residents { get; set; }
			T RotationalPeriods { get; set; }
			T SurfaceWaters { get; set; }
			T TerrainTypes { get; set; }
			T TerrainFlags { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearch : IStarWarsModel.ISearch
		{
			new ISearchContainables? SearchContainables { get; set; }

			IEnumerable<string>? ClimateTypes { get; set; }
			IEnumerable<string>? ClimateFlags { get; set; }
			ISearchValues<int?>? Diameters { get; set; }
			ISearchValues<double?>? Gravities { get; set; }
			ISearchValues<TimeSpan?>? OrbitalPeriods { get; set; }
			ISearchValues<long?>? Populations { get; set; }
			ICharacter.ISearchContainables? Residents { get; set; }
			ISearchValues<TimeSpan?>? RotationalPeriods { get; set; }
			ISearchValues<double?>? SurfaceWaters { get; set; }
			IEnumerable<string>? TerrainTypes { get; set; }
			IEnumerable<string>? TerrainFlags { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }

				public IEnumerable<string>? ClimateTypes { get; set; }
				public IEnumerable<string>? ClimateFlags { get; set; }
				public ISearchValues<int?>? Diameters { get; set; }
				public ISearchValues<double?>? Gravities { get; set; }
				public ISearchValues<TimeSpan?>? OrbitalPeriods { get; set; }
				public ISearchValues<long?>? Populations { get; set; }
				public ICharacter.ISearchContainables? Residents { get; set; }
				public ISearchValues<TimeSpan?>? RotationalPeriods { get; set; }
				public ISearchValues<double?>? SurfaceWaters { get; set; }
				public IEnumerable<string>? TerrainTypes { get; set; }
				public IEnumerable<string>? TerrainFlags { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					ClimateTypes = defaultvalue;
					ClimateFlags = defaultvalue;
					Diameters = defaultvalue;
					Gravities = defaultvalue;
					OrbitalPeriods = defaultvalue;
					Populations = defaultvalue;
					Residents = defaultvalue;
					RotationalPeriods = defaultvalue;
					SurfaceWaters = defaultvalue;
					TerrainTypes = defaultvalue;
					TerrainFlags = defaultvalue;
				}

				public T ClimateTypes { get; set; }
				public T ClimateFlags { get; set; }
				public T Diameters { get; set; }
				public T Gravities { get; set; }
				public T OrbitalPeriods { get; set; }
				public T Populations { get; set; }
				public T Residents { get; set; }
				public T RotationalPeriods { get; set; }
				public T SurfaceWaters { get; set; }
				public T TerrainTypes { get; set; }
				public T TerrainFlags { get; set; }
			}

			public bool ShouldReturnPlanet(IPlanet planet)
			{
				if (SearchContainables?.ShouldReturnPlanet(planet, SearchString) ?? false)
					return true;

				if (SearchClimate(planet, out int _)) return true;
				if (Diameters is not null && Diameters.Search(planet.Diameter, out int _)) return true;
				if (Gravities is not null && Gravities.Search(planet.Gravity, out int _)) return true;
				if (OrbitalPeriods is not null && OrbitalPeriods.Search(planet.OrbitalPeriod, out int _)) return true;
				if (Populations is not null && Populations.Search(planet.Population, out int _)) return true;
				if (RotationalPeriods is not null && RotationalPeriods.Search(planet.RotationalPeriod, out int _)) return true;
				if (SurfaceWaters is not null && SurfaceWaters.Search(planet.SurfaceWater, out int _)) return true;
				if (SearchTerrain(planet, out int _)) return true;

				return false;
			}
			public bool ShouldReturnPlanet(
				IPlanet planet,
				Func<IEnumerable<ICharacter>>? residentsFunc = null)
			{
				if (ShouldReturnPlanet(planet))
					return true;

				if (Residents is not null && residentsFunc is not null)
					foreach (ICharacter resident in residentsFunc.Invoke())
						if (Residents.ShouldReturnCharacter(resident, SearchString))
							return true;

				return false;
			}
			public async Task<bool> ShouldReturnPlanetAsync(
				IPlanet planet,
				Func<IAsyncEnumerable<ICharacter>>? residentsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnPlanet(planet))
					return true;

				if (Residents is not null && residentsFunc is not null)
					await foreach (ICharacter resident in residentsFunc.Invoke().WithCancellation(cancellationToken))
						if (Residents.ShouldReturnCharacter(resident, SearchString))
							return true;

				return false;
			}

			public int GetMatchCount(IPlanet planet)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnPlanet(planet, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				SearchClimate(planet, out int climatematchcount); matchcount += climatematchcount;
				if (Diameters is not null && Diameters.Search(planet.Diameter, out int diametermatchcount)) matchcount += diametermatchcount;
				if (Gravities is not null && Gravities.Search(planet.Gravity, out int gravitiesmatchcount)) matchcount += gravitiesmatchcount;
				if (OrbitalPeriods is not null && OrbitalPeriods.Search(planet.OrbitalPeriod, out int orbitalperiodmatchcount)) matchcount += orbitalperiodmatchcount;
				if (Populations is not null && Populations.Search(planet.Population, out int populationmatchcount)) matchcount += populationmatchcount;
				if (RotationalPeriods is not null && RotationalPeriods.Search(planet.RotationalPeriod, out int rotationalperiodmatchcount)) matchcount += rotationalperiodmatchcount;
				if (SurfaceWaters is not null && SurfaceWaters.Search(planet.SurfaceWater, out int surfacewatermatchcount)) matchcount += surfacewatermatchcount;
				SearchTerrain(planet, out int terrainmatchcount); matchcount += terrainmatchcount;

				return matchcount;
			}
			public int GetMatchCount(
				IPlanet planet,
				Func<IEnumerable<ICharacter>>? residentsFunc = null)
			{
				int matchcount = GetMatchCount(planet);

				if (Residents is not null && residentsFunc is not null)
					matchcount += residentsFunc.Invoke()
						.Select(resident =>
						{
							Residents.ShouldReturnCharacter(resident, SearchString, out int residentmatchcount);

							return residentmatchcount;

						}).Sum();

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(
				IPlanet planet,
				Func<IAsyncEnumerable<ICharacter>>? residentsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(planet);

				if (Residents is not null && residentsFunc is not null)
					await foreach (ICharacter resident in residentsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Residents.ShouldReturnCharacter(resident, SearchString, out int residentmatchcount); matchcount += residentmatchcount;
					}

				return matchcount;
			}

			private bool SearchClimate(IPlanet planet, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (planet.Climates == null)
					return false;

				if (ClimateTypes is not null)
					foreach (string? Type in planet.Climates.Select(climate => climate.Type))
						if (!string.IsNullOrWhiteSpace(Type) && ClimateTypes.Contains(Type))
						{
							matchCount++;
							if (!shouldreturn) shouldreturn = true;
						}

				if (ClimateFlags is not null && planet.Climates.SelectMany(climate => climate.Flags ?? Enumerable.Empty<string>()) is IEnumerable<string> climateflags)
					foreach (string climateflag in climateflags)
						if (ClimateFlags.Contains(climateflag))
						{
							matchCount++;
							if (!shouldreturn) shouldreturn = true;
						}

				return shouldreturn;
			}
			private bool SearchTerrain(IPlanet planet, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (planet.Terrains == null)
					return false;

				if (TerrainTypes is not null)
					foreach (string? Type in planet.Terrains.Select(terrain => terrain.Type))
						if (!string.IsNullOrWhiteSpace(Type) && TerrainTypes.Contains(Type))
						{
							matchCount++;
							if (!shouldreturn) shouldreturn = true;
						}

				if (TerrainFlags is not null && planet.Terrains.SelectMany(terrain => terrain.Flags ?? Enumerable.Empty<string>()) is IEnumerable<string> terrainflags)
					foreach (string terrainflag in terrainflags)
						if (TerrainFlags.Contains(terrainflag))
						{
							matchCount++;
							if (!shouldreturn) shouldreturn = true;
						}

				return shouldreturn;
			}
		}
	}

	public static class PlanetSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IPlanet.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.ClimateTypes), search.ClimateTypes).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.ClimateFlags), search.ClimateFlags).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.Diameters), search.Diameters).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.Gravities), search.Gravities).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.OrbitalPeriods), search.OrbitalPeriods).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.Populations), search.Populations).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.Residents), search.Residents).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.RotationalPeriods), search.RotationalPeriods).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.SurfaceWaters), search.SurfaceWaters).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.TerrainTypes), search.TerrainTypes).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IPlanet.ISearch<T>.TerrainFlags), search.TerrainFlags).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IPlanet.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(ITransporter.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			stringbuilder
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.ClimateTypes)).AppendJoin(", ", search.ClimateTypes ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.ClimateFlags)).AppendJoin(", ", search.ClimateFlags ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.Diameters)).AppendLine().Append(search.Diameters)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.Gravities)).AppendLine().Append(search.Gravities)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.OrbitalPeriods)).AppendLine().Append(search.OrbitalPeriods)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.Populations)).AppendLine().Append(search.Populations)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.Residents)).AppendLine().Append(search.Residents)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.RotationalPeriods)).AppendLine().Append(search.RotationalPeriods)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.SurfaceWaters)).AppendLine().Append(search.SurfaceWaters)
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.TerrainTypes)).AppendJoin(", ", search.TerrainTypes ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(IPlanet.ISearch.TerrainFlags)).AppendJoin(", ", search.TerrainFlags ?? Enumerable.Empty<string>()).AppendLine();

			return stringbuilder;
		}
	}
}
