using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IWeapon
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T Manufacturers { get; set; }

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
			IManufacturer.ISearchContainables? Manufacturers { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }
				public IManufacturer.ISearchContainables? Manufacturers { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Manufacturers = defaultvalue;
				}

				public T Manufacturers { get; set; }
			}

			public bool ShouldReturnWeapon(IWeapon weapon, Func<IEnumerable<IManufacturer>>? manufacturersFunc = null)
			{
				if (SearchContainables?.ShouldReturnWeapon(weapon, SearchString) ?? false)
					return true;

				if (Manufacturers is not null && manufacturersFunc is not null)
					foreach (IManufacturer manufacturer in manufacturersFunc.Invoke())
						if (Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString))
							return true;

				return false;
			}
			public async Task<bool> ShouldReturnWeaponAsync(IWeapon weapon, Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null, CancellationToken cancellationToken = default)
			{
				if (SearchContainables?.ShouldReturnWeapon(weapon, SearchString) ?? false)
					return true;

				if (Manufacturers is not null && manufacturersFunc is not null)
					await foreach (IManufacturer manufacturer in manufacturersFunc.Invoke().WithCancellation(cancellationToken))
						if (Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString))
							return true;

				return false;
			}
			public int GetMatchCount(IWeapon weapon, Func<IEnumerable<IManufacturer>>? manufacturersFunc = null)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnWeapon(weapon, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (Manufacturers is not null && manufacturersFunc is not null)
					matchcount += manufacturersFunc.Invoke()
						.Select(manufacturer =>
						{
							Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString, out int manufacturermatchcount);

							return manufacturermatchcount;

						}).Sum();

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(IWeapon weapon, Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null, CancellationToken cancellationToken = default)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnWeapon(weapon, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (Manufacturers is not null && manufacturersFunc is not null)
					await foreach (IManufacturer manufacturer in manufacturersFunc.Invoke().WithCancellation(cancellationToken))
					{
						Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString, out int manufacturermatchcount); matchcount += manufacturermatchcount;
					}

				return matchcount;
			}
		}
	}

	public static class WeaponSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IWeapon.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IWeapon.ISearch<T>.Manufacturers), search.Manufacturers).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IWeapon.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IWeapon.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			if (search.Manufacturers is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IWeapon.ISearch.Manufacturers)).AppendLine()
					.Append(search.Manufacturers).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
