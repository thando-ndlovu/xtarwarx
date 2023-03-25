using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IVehicle
	{
		public new interface ISearch<T> : ITransporter.ISearch<T> 
		{
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

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : ITransporter.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }
			}
			public new class Default<T> : ITransporter.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue) { }
			}			

			public bool ShouldReturnVehicle(IVehicle vehicle)
			{
				if (SearchContainables?.ShouldReturnVehicle(vehicle, SearchString) ?? false)
					return true;

				return false;
			}
			public bool ShouldReturnVehicle(
				IVehicle vehicle,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<ICharacter>>? pilotsFunc = null)
			{
				if (ShouldReturnVehicle(vehicle))
					return true;

				return ShouldReturnTransporter(
					transporter: vehicle,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc);
			}
			public async Task<bool> ShouldReturnVehicleAsync(
				IVehicle vehicle,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? pilotsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnVehicle(vehicle))
					return true;

				return await ShouldReturnTransporterAsync(
					transporter: vehicle,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc,
					cancellationToken: cancellationToken);
			}

			public int GetMatchCount(IVehicle vehicle)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnVehicle(vehicle, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				return matchcount;
			}
			public int GetMatchCount(
				IVehicle vehicle,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<ICharacter>>? pilotsFunc = null)
			{
				int matchcount = GetMatchCount(vehicle);

				matchcount += GetMatchCount(
					transporter: vehicle,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc);

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(
				IVehicle vehicle,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? pilotsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(vehicle);

				matchcount += await GetMatchCountAsync(
					transporter: vehicle,
					searchContainables: false,
					manufacturersFunc: manufacturersFunc,
					pilotsFunc: pilotsFunc,
					cancellationToken: cancellationToken);

				return matchcount;
			}
		}
	}

	public static class VehicleSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IVehicle.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			return stringbuilder.Append(search as ITransporter.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IVehicle.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IVehicle.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			return stringbuilder.Append(search as ITransporter.ISearch);
		}
	}
}
