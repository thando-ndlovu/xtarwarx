using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IStarWarsModelSearchQuery<T>
	{
		T SearchString { get; set; }

		public IEnumerable<T> AsEnumerable()
		{
			return Enumerable.Empty<T>()
					.Append(SearchString);
		}
	}
	public interface IStarWarsModelSearchQuery
	{
		string? SearchString { get; set; }

		public IEnumerable<string> AsQueryData(IStarWarsModelSearchQuery<string>? keys)
		{
			IEnumerable<string> querydata = Enumerable.Empty<string>();

			if (!string.IsNullOrWhiteSpace(SearchString))
				querydata = querydata.Append(string.Format("{0}={1}", keys?.SearchString ?? nameof(SearchString).ToLower(), SearchString));

			return querydata;
		}

		public class Default : IStarWarsModelSearchQuery
		{
			public Default() { }
			public Default(IStarWarsModel.ISearch starwarsmodelsearch)
			{
				SearchString = starwarsmodelsearch.SearchString;
			}

			public string? SearchString { get; set; }
		}
		public class Default<T> : IStarWarsModelSearchQuery<T>
		{
			public Default(T defaultvalue)
			{
				SearchString = defaultvalue;
			}

			public T SearchString { get; set; }
		}
	}
}
