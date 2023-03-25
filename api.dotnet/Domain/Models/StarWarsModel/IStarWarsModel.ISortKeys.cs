using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IStarWarsModel 
	{
		public interface ISortKeys<T>
		{
			T Created { get; set; }
			T Edited { get; set; }
			T Id { get; set; }

			public T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.Created => Created,
					ISortKeys.Keys.Edited => Edited,
					ISortKeys.Keys.Id => Id,

					_ => throw new ArgumentException(string.Format("Key '{0}' is not a valid key", sortkey)),
				};
			}
			public string ToString(StringBuilder? stringBuilder = null)
			{
				return (stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Created), Created).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Edited), Edited).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Id), Id).AppendLine()
					.ToString();
			}
		}
		public interface ISortKeys : ISortKeys<string?>
		{
			public class Sorter
			{
				public bool Descending { get; set; }
				public string? SortKey { get; set; }

				public static implicit operator Sorter(string sortkey)
				{
					return new Sorter
					{
						SortKey = sortkey
					};
				}
			}
			public class Keys
			{
				public const string Created = "Created";
				public const string Edited = "Edited";
				public const string Id = "Id";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Created)
						.Append(Edited)
						.Append(Id);
				}
				public static IOrderedEnumerable<TStarWarsModel> Sort<TStarWarsModel>(IEnumerable<TStarWarsModel> starwarsmodels, params Sorter[] sorters) where TStarWarsModel : IStarWarsModel
				{
					IOrderedEnumerable<TStarWarsModel>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(Created, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel.Created) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel.Created),
							(Created, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel.Created) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel.Created),

							(Edited, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel.Edited) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel.Edited),
							(Edited, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel.Edited) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel.Edited),

							(Id, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel.Id) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel.Id),
							(Id, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel.Id) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel.Id),

							(_, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel),
							(_, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel),
						};

					return ordered ?? starwarsmodels.OrderBy(starwarsmodel => starwarsmodel);
				}
				public static IOrderedQueryable<TStarWarsModel> Sort<TStarWarsModel>(IQueryable<TStarWarsModel> starwarsmodels, params Sorter[] sorters) where TStarWarsModel : IStarWarsModel
				{
					IOrderedQueryable<TStarWarsModel>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(Created, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel.Created) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel.Created),
							(Created, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel.Created) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel.Created),

							(Edited, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel.Edited) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel.Edited),
							(Edited, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel.Edited) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel.Edited),

							(Id, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel.Id) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel.Id),
							(Id, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel.Id) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel.Id),

							(_, false) => 
								ordered?.ThenBy(starwarsmodel => starwarsmodel) ??
								starwarsmodels.OrderBy(starwarsmodel => starwarsmodel),
							(_, true) => 
								ordered?.ThenByDescending(starwarsmodel => starwarsmodel) ??
								starwarsmodels.OrderByDescending(starwarsmodel => starwarsmodel),
						};

					return ordered ?? starwarsmodels.OrderBy(starwarsmodel => starwarsmodel);
				}
			}

			public class Default : Default<string?>, ISortKeys
			{
				public Default() : base(null) { } 
			}
			public class Default<T> : ISortKeys<T>
			{
				public Default(T defaultvalue)
				{
					Created = defaultvalue;
					Edited = defaultvalue;
					Id = defaultvalue;
				}

				public T Created { get; set; }
				public T Edited { get; set; }
				public T Id { get; set; }
			}
		}
	}
}
