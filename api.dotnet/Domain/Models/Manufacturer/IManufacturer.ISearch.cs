using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IManufacturer
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T HeadquatersPlanet { get; set; }
			T Starships { get; set; }
			T Vehicles { get; set; }
			T Weapons { get; set; }

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

			IPlanet.ISearchContainables? HeadquatersPlanet { get; set; }
			IStarship.ISearchContainables? Starships { get; set; }
			IVehicle.ISearchContainables? Vehicles { get; set; }
			IWeapon.ISearchContainables? Weapons { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }

				public IPlanet.ISearchContainables? HeadquatersPlanet { get; set; }
				public IStarship.ISearchContainables? Starships { get; set; }
				public IVehicle.ISearchContainables? Vehicles { get; set; }
				public IWeapon.ISearchContainables? Weapons { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					HeadquatersPlanet = defaultvalue;
					Starships = defaultvalue;
					Vehicles = defaultvalue;
					Weapons = defaultvalue;
				}

				public T HeadquatersPlanet { get; set; }
				public T Starships { get; set; }
				public T Vehicles { get; set; }
				public T Weapons { get; set; }
			}

			public bool ShouldReturnManufacturer(
				IManufacturer manufacturer,
				Func<IPlanet?>? headquatersPlanetFunc = null,
				Func<IEnumerable<IStarship>>? starshipsFunc = null,
				Func<IEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IEnumerable<IWeapon>>? weaponsFunc = null)
			{
				if (SearchContainables?.ShouldReturnManufacturer(manufacturer, SearchString) ?? false)
					return true;

				if (HeadquatersPlanet is not null && headquatersPlanetFunc is not null)
				{
					IPlanet? headquatersPlanet = headquatersPlanetFunc.Invoke();

					if (headquatersPlanet is not null && HeadquatersPlanet.ShouldReturnPlanet(headquatersPlanet, SearchString))
						return true;
				}

				if (Starships is not null && starshipsFunc is not null)
					foreach (IStarship starship in starshipsFunc.Invoke())
						if (Starships.ShouldReturnStarship(starship, SearchString))
							return true;

				if (Vehicles is not null && vehiclesFunc is not null)
					foreach (IVehicle vehicle in vehiclesFunc.Invoke())
						if (Vehicles.ShouldReturnVehicle(vehicle, SearchString))
							return true;

				if (Weapons is not null && weaponsFunc is not null)
					foreach (IWeapon weapon in weaponsFunc.Invoke())
						if (Weapons.ShouldReturnWeapon(weapon, SearchString))
							return true;

				return false;
			}

			public async Task<bool> ShouldReturnManufacturerAsync(
				IManufacturer manufacturer,
				Func<Task<IPlanet?>>? headquatersPlanetFunc = null,
				Func<IAsyncEnumerable<IStarship>>? starshipsFunc = null,
				Func<IAsyncEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IAsyncEnumerable<IWeapon>>? weaponsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (SearchContainables?.ShouldReturnManufacturer(manufacturer, SearchString) ?? false)
					return true;

				if (HeadquatersPlanet is not null && headquatersPlanetFunc is not null)
				{
					IPlanet? headquatersPlanet = await headquatersPlanetFunc.Invoke();

					if (headquatersPlanet is not null && HeadquatersPlanet.ShouldReturnPlanet(headquatersPlanet, SearchString))
						return true;
				}

				if (Starships is not null && starshipsFunc is not null)
					await foreach (IStarship starship in starshipsFunc.Invoke().WithCancellation(cancellationToken))
						if (Starships.ShouldReturnStarship(starship, SearchString))
							return true;

				if (Vehicles is not null && vehiclesFunc is not null)
					await foreach (IVehicle vehicle in vehiclesFunc.Invoke().WithCancellation(cancellationToken))
						if (Vehicles.ShouldReturnVehicle(vehicle, SearchString))
							return true;

				if (Weapons is not null && weaponsFunc is not null)
					await foreach (IWeapon weapon in weaponsFunc.Invoke().WithCancellation(cancellationToken))
						if (Weapons.ShouldReturnWeapon(weapon, SearchString))
							return true;

				return false;
			}

			public int GetMatchCount(
				IManufacturer manufacturer,
				Func<IPlanet?>? headquatersPlanetFunc = null,
				Func<IEnumerable<IStarship>>? starshipsFunc = null,
				Func<IEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IEnumerable<IWeapon>>? weaponsFunc = null)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnManufacturer(manufacturer, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (HeadquatersPlanet is not null && headquatersPlanetFunc?.Invoke() is IPlanet headquatersPlanet)
				{
					HeadquatersPlanet.ShouldReturnPlanet(headquatersPlanet, SearchString, out int homeworldmatchcount); matchcount += homeworldmatchcount;
				}

				if (Starships is not null && starshipsFunc is not null)
					matchcount += starshipsFunc.Invoke()
						.Select(starship =>
						{
							Starships.ShouldReturnStarship(starship, SearchString, out int starshipmatchcount);

							return starshipmatchcount;

						}).Sum();

				if (Vehicles is not null && vehiclesFunc is not null)
					matchcount += vehiclesFunc.Invoke()
						.Select(vehicle =>
						{
							Vehicles.ShouldReturnVehicle(vehicle, SearchString, out int vehiclematchcount);

							return vehiclematchcount;

						}).Sum();

				if (Weapons is not null && weaponsFunc is not null)
					matchcount += weaponsFunc.Invoke()
						.Select(weapon =>
						{
							Weapons.ShouldReturnWeapon(weapon, SearchString, out int weaponmatchcount);

							return weaponmatchcount;

						}).Sum();

				return matchcount;
			}

			public async Task<int> GetMatchCountAsync(
				IManufacturer manufacturer,
				Func<Task<IPlanet?>>? headquatersPlanetFunc = null,
				Func<IAsyncEnumerable<IStarship>>? starshipsFunc = null,
				Func<IAsyncEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IAsyncEnumerable<IWeapon>>? weaponsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnManufacturer(manufacturer, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (HeadquatersPlanet is not null && headquatersPlanetFunc?.Invoke() is Task<IPlanet?> headquatersPlanetTask && await headquatersPlanetTask is IPlanet headquatersPlanet)
				{
					HeadquatersPlanet.ShouldReturnPlanet(headquatersPlanet, SearchString, out int headquatersPlanetmatchcount); matchcount += headquatersPlanetmatchcount;
				}

				if (Starships is not null && starshipsFunc is not null)
					await foreach (IStarship starship in starshipsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Starships.ShouldReturnStarship(starship, SearchString, out int starshipmatchcount); matchcount += starshipmatchcount;
					}

				if (Vehicles is not null && vehiclesFunc is not null)
					await foreach (IVehicle vehicle in vehiclesFunc.Invoke().WithCancellation(cancellationToken))
					{
						Vehicles.ShouldReturnVehicle(vehicle, SearchString, out int vehiclematchcount); matchcount += vehiclematchcount;
					}

				if (Weapons is not null && weaponsFunc is not null)
					await foreach (IWeapon weapon in weaponsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Weapons.ShouldReturnWeapon(weapon, SearchString, out int weaponmatchcount); matchcount += weaponmatchcount;
					}

				return matchcount;
			}
		}
	}

	public static class ManufacturerSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IManufacturer.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IManufacturer.ISearch<T>.HeadquatersPlanet), search.HeadquatersPlanet).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IManufacturer.ISearch<T>.Starships), search.Starships).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IManufacturer.ISearch<T>.Vehicles), search.Vehicles).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IManufacturer.ISearch<T>.Weapons), search.Weapons).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IManufacturer.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IManufacturer.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();	   

			if (search.HeadquatersPlanet is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IManufacturer.ISearch.HeadquatersPlanet)).AppendLine()
					.Append(search.HeadquatersPlanet).AppendLine();	   

			if (search.Starships is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IManufacturer.ISearch.Starships)).AppendLine()
					.Append(search.Starships).AppendLine();	   

			if (search.Weapons is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IManufacturer.ISearch.Weapons)).AppendLine()
					.Append(search.Weapons).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
