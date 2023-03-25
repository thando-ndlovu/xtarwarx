using System.Collections.Generic;
using System.Linq;

namespace Api.Queries
{
	public interface IPagination
	{
		int? ItemsPerPage { get; set; }
		IEnumerable<int>? ItemsPerPageOptions { get; set; }
		int? Page { get; set; }
		IEnumerable<int>? Pages { get; set; }
		string? OrderBy { get; set; }
		IEnumerable<string>? OrderByOptions { get; set; }
		bool? Reverse { get; set; }

		public void SetPageCount(int? pagecount)
		{
			Pages = pagecount.HasValue
				? Enumerable.Range(1, pagecount.Value)
				: Pages = Enumerable.Empty<int>();
		}

		public class Default : IPagination
		{
			public int? ItemsPerPage { get; set; }
			public IEnumerable<int>? ItemsPerPageOptions { get; set; }
			public int? Page { get; set; }
			public IEnumerable<int>? Pages { get; set; }
			public string? OrderBy { get; set; }
			public IEnumerable<string>? OrderByOptions { get; set; }
			public bool? Reverse { get; set; }
		}
	}
}
