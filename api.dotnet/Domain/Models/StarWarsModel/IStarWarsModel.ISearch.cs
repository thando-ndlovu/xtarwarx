using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IStarWarsModel
	{
		public interface ISearch<T>
		{
			T SearchString { get; set; }

			public string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public interface ISearch
		{
			string? SearchString { get; set; }

			ISearchContainables? SearchContainables { get; set; }

			public string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public class Default : ISearch
			{
				public string? SearchString { get; set; }

				public ISearchContainables? SearchContainables { get; set; }
			}
			public class Default<T> : ISearch<T>
			{
				public Default(T defaultValue)
				{
					SearchString = defaultValue;
				}

				public T SearchString { get; set; }
			}
		}
	}

	public static class StarWarsModelSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IStarWarsModel.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			return stringbuilder
				.AppendFormat("{0}: {1}", nameof(IStarWarsModel.ISearch<T>.SearchString), search.SearchString).AppendLine();
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IStarWarsModel.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IStarWarsModel.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			return stringbuilder
				.AppendFormat("{0}: {1}", nameof(IStarWarsModel.ISearch.SearchString), search.SearchString).AppendLine();;
		}
	}
}
