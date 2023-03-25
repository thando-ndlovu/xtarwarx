using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IStarship
	{
		public new interface ISearch<T> : ITransporter.ISearch<T>
		{
			T MGLTs { get; set; }
			T HyperdriveRatings { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearch : ITransporter.ISearch
		{
			new ISearchContainables? SearchContainables { get; set; }

			ISearchValues<int?>? MGLTs { get; set; }
			ISearchValues<double?>? HyperdriveRatings { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : ITransporter.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }

				public ISearchValues<int?>? MGLTs { get; set; }
				public ISearchValues<double?>? HyperdriveRatings { get; set; }
			}
			public new class Default<T> : ITransporter.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					MGLTs = defaultvalue;
					HyperdriveRatings = defaultvalue;
				}

				public T MGLTs { get; set; }
				public T HyperdriveRatings { get; set; }
			}

			public bool ShouldReturnStarship(IStarship starship)
			{
				if (SearchContainables?.ShouldReturnStarship(starship, SearchString) ?? false)
					return true;

				if (HyperdriveRatings is not null && HyperdriveRatings.Search(starship.HyperdriveRating, out int _)) return true;
				if (MGLTs is not null && MGLTs.Search(starship.MGLT, out int _)) return true;

				return false;
			}
			public bool ShouldReturnStarship(
				IStarship starship,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<ICharacter>>? pilotsFunc = null)
			{
				if (ShouldReturnStarship(starship))
					return true;

				return ShouldReturnTransporter(
					transporter: starship,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc);
			}
			public async Task<bool> ShouldReturnStarshipAsync(
				IStarship starship,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? pilotsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnStarship(starship))
					return true;

				return await ShouldReturnTransporterAsync(
					transporter: starship,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc,
					cancellationToken: cancellationToken);
			}

			public int GetMatchCount(IStarship starship)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnStarship(starship, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (HyperdriveRatings is not null && HyperdriveRatings.Search(starship.HyperdriveRating, out int hyperdriverating)) matchcount += hyperdriverating;
				if (MGLTs is not null && MGLTs.Search(starship.MGLT, out int mgltmatchcount)) matchcount += mgltmatchcount;

				return matchcount;
			}
			public int GetMatchCount(
				IStarship starship,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<ICharacter>>? pilotsFunc = null)
			{
				int matchcount = GetMatchCount(starship);

				matchcount += GetMatchCount(
					transporter: starship,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc);

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(
				IStarship starship,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? pilotsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(starship);

				matchcount += await GetMatchCountAsync(
					transporter: starship,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc,
					cancellationToken: cancellationToken);

				return matchcount;
			}
		}
	}

	public static class StarshipSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IStarship.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IStarship.ISearch<T>.MGLTs), search.MGLTs).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IStarship.ISearch<T>.HyperdriveRatings), search.HyperdriveRatings).AppendLine();

			return stringbuilder.Append(search as ITransporter.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IStarship.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IStarship.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IStarship.ISearch.MGLTs), search.MGLTs).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IStarship.ISearch.HyperdriveRatings), search.HyperdriveRatings).AppendLine();

			return stringbuilder.Append(search as ITransporter.ISearch);
		}
	}
}
