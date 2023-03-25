using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface ITransporter
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T CargoCapacities { get; set; }
			T Consumables { get; set; }
			T CostInCredits { get; set; }
			T Lengths { get; set; }
			T Manufacturers { get; set; }
			T MaxAtmospheringSpeeds { get; set; }
			T MaxCrews { get; set; }
			T MinCrews { get; set; }
			T Passengers { get; set; }
			T Pilots { get; set; }

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

			ISearchValues<long?>? CargoCapacities { get; set; }
			ISearchValues<IConsumable?>? Consumables { get; set; }
			ISearchValues<long?>? CostInCredits { get; set; }
			ISearchValues<double?>? Lengths { get; set; }
			IManufacturer.ISearchContainables? Manufacturers { get; set; }
			ISearchValues<int?>? MaxAtmospheringSpeeds { get; set; }
			ISearchValues<int?>? MaxCrews { get; set; }
			ISearchValues<int?>? MinCrews { get; set; }
			ISearchValues<int?>? Passengers { get; set; }
			ICharacter.ISearchContainables? Pilots { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ITransporter.ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }

				public ISearchValues<long?>? CargoCapacities { get; set; }
				public ISearchValues<IConsumable?>? Consumables { get; set; }
				public ISearchValues<long?>? CostInCredits { get; set; }
				public ISearchValues<double?>? Lengths { get; set; }
				public ISearchValues<int?>? Passengers { get; set; }
				public IManufacturer.ISearchContainables? Manufacturers { get; set; }
				public ISearchValues<int?>? MaxAtmospheringSpeeds { get; set; }
				public ISearchValues<int?>? MaxCrews { get; set; }
				public ISearchValues<int?>? MinCrews { get; set; }
				public ICharacter.ISearchContainables? Pilots { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ITransporter.ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					CargoCapacities = defaultvalue;
					Consumables = defaultvalue;
					CostInCredits = defaultvalue;
					Lengths = defaultvalue;
					Manufacturers = defaultvalue;
					MaxAtmospheringSpeeds = defaultvalue;
					MaxCrews = defaultvalue;
					MinCrews = defaultvalue;
					Passengers = defaultvalue;
					Pilots = defaultvalue;
				}

				public T CargoCapacities { get; set; }
				public T Consumables { get; set; }
				public T CostInCredits { get; set; }
				public T Lengths { get; set; }
				public T Manufacturers { get; set; }
				public T MaxAtmospheringSpeeds { get; set; }
				public T MaxCrews { get; set; }
				public T MinCrews { get; set; }
				public T Passengers { get; set; }
				public T Pilots { get; set; }
			}

			public bool ShouldReturnTransporter(ITransporter transporter, bool searchContainables)
			{
				if (searchContainables && (SearchContainables?.ShouldReturnTransporter(transporter, SearchString) ?? false))
					return true;

				if (CargoCapacities is not null && CargoCapacities.Search(transporter.CargoCapacity, out int _)) return true;
				if (Consumables is not null && Consumables.Search(transporter.Consumables, new IConsumable.Comparer(), out int _)) return true;
				if (CostInCredits is not null && CostInCredits.Search(transporter.CostInCredits, out int _)) return true;
				if (Lengths is not null && Lengths.Search(transporter.Length, out int _)) return true;
				if (MaxAtmospheringSpeeds is not null && MaxAtmospheringSpeeds.Search(transporter.MaxAtmospheringSpeed, out int _)) return true;
				if (MaxCrews is not null && MaxCrews.Search(transporter.MaxCrew, out int _)) return true;
				if (MinCrews is not null && MinCrews.Search(transporter.MinCrew, out int _)) return true;
				if (Passengers is not null && Passengers.Search(transporter.Passengers, out int _)) return true;

				return false;
			}
			public bool ShouldReturnTransporter(
				ITransporter transporter,
				bool searchContainables,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<ICharacter>>? pilotsFunc = null)
			{
				if (ShouldReturnTransporter(transporter, searchContainables))
					return false;

				if (Manufacturers is not null && manufacturersFunc is not null)
					foreach (IManufacturer manufacturer in manufacturersFunc.Invoke())
						if (Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString))
							return true;

				if (Pilots is not null && pilotsFunc is not null)
					foreach (ICharacter pilot in pilotsFunc.Invoke())
						if (Pilots.ShouldReturnCharacter(pilot, SearchString))
							return true;

				return false;
			}
			public async Task<bool> ShouldReturnTransporterAsync(
				ITransporter transporter,
				bool searchContainables,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? pilotsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnTransporter(transporter, searchContainables))
					return false;

				if (Manufacturers is not null && manufacturersFunc is not null)
					await foreach (IManufacturer manufacturer in manufacturersFunc.Invoke().WithCancellation(cancellationToken))
						if (Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString))
							return true;

				if (Pilots is not null && pilotsFunc is not null)
					await foreach (ICharacter pilot in pilotsFunc.Invoke().WithCancellation(cancellationToken))
						if (Pilots.ShouldReturnCharacter(pilot, SearchString))
							return true;

				return false;
			}

			public int GetMatchCount(ITransporter transporter, bool searchContainables)
			{
				int matchcount = 0;

				if (searchContainables && SearchContainables is not null)
				{
					SearchContainables.ShouldReturnTransporter(transporter, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (CargoCapacities is not null && CargoCapacities.Search(transporter.CargoCapacity, out int cargocapacitymatchcount)) matchcount += cargocapacitymatchcount;
				if (Consumables is not null && Consumables.Search(transporter.Consumables, new IConsumable.Comparer(), out int consumablesmatchcount)) matchcount += consumablesmatchcount;
				if (CostInCredits is not null && CostInCredits.Search(transporter.CostInCredits, out int costincreditsmatchcount)) matchcount += costincreditsmatchcount;
				if (Lengths is not null && Lengths.Search(transporter.Length, out int lengthmatchcount)) matchcount += lengthmatchcount;
				if (MaxAtmospheringSpeeds is not null && MaxAtmospheringSpeeds.Search(transporter.MaxAtmospheringSpeed, out int maxatmospheringspeedmatchcount)) matchcount += maxatmospheringspeedmatchcount;
				if (MaxCrews is not null && MaxCrews.Search(transporter.MaxCrew, out int maxcrewmatchcount)) matchcount += maxcrewmatchcount;
				if (MinCrews is not null && MinCrews.Search(transporter.MinCrew, out int mincrewmatchcount)) matchcount += mincrewmatchcount;
				if (Passengers is not null && Passengers.Search(transporter.Passengers, out int passengersmatchcount)) matchcount += passengersmatchcount;

				return matchcount;
			}
			public int GetMatchCount(
				ITransporter transporter,
				bool searchContainables,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<ICharacter>>? pilotsFunc = null)
			{
				int matchcount = GetMatchCount(transporter, searchContainables);

				if (Manufacturers is not null && manufacturersFunc is not null)
					matchcount += manufacturersFunc.Invoke()
						.Select(manufacturer =>
						{
							Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString, out int manufacturermatchcount);

							return manufacturermatchcount;

						}).Sum();

				if (Pilots is not null && pilotsFunc is not null)
					matchcount += pilotsFunc.Invoke()
						.Select(pilot =>
						{
							Pilots.ShouldReturnCharacter(pilot, SearchString, out int pilotmatchcount);

							return pilotmatchcount;

						}).Sum();

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(
				ITransporter transporter,
				bool searchContainables,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? pilotsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(transporter, searchContainables);

				if (Manufacturers is not null && manufacturersFunc is not null)
					await foreach (IManufacturer manufacturer in manufacturersFunc.Invoke().WithCancellation(cancellationToken))
					{
						Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString, out int manufacturermatchcount); matchcount += manufacturermatchcount;
					}

				if (Pilots is not null && pilotsFunc is not null)
					await foreach (ICharacter pilot in pilotsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Pilots.ShouldReturnCharacter(pilot, SearchString, out int pilotmatchcount); matchcount += pilotmatchcount;
					}

				return matchcount;
			}
		}
	}

	public static class TransporterSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, ITransporter.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.CargoCapacities), search.CargoCapacities).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.Consumables), search.Consumables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.CostInCredits), search.CostInCredits).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.Lengths), search.Lengths).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.Manufacturers), search.Manufacturers).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.MaxCrews), search.MaxCrews).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.MinCrews), search.MinCrews).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.Passengers), search.Passengers).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearch<T>.Pilots), search.Pilots).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}	  
		public static StringBuilder Append(this StringBuilder stringbuilder, ITransporter.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(ITransporter.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			stringbuilder
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.CargoCapacities)).AppendLine().Append(search.CargoCapacities)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.Consumables)).AppendLine().Append(search.Consumables)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.CostInCredits)).AppendLine().Append(search.CostInCredits)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.Lengths)).AppendLine().Append(search.Lengths)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.Manufacturers)).AppendLine().Append(search.Manufacturers)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.MaxCrews)).AppendLine().Append(search.MaxCrews)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.MinCrews)).AppendLine().Append(search.MinCrews)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.Passengers)).AppendLine().Append(search.Passengers)
				.AppendFormat("{0}: ", nameof(ITransporter.ISearch.Pilots)).AppendLine().Append(search.Pilots);

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
