using Api.Queries.Retrievers;

using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Queries
{
	public interface IQuery<T>
	{
		T Ids { get; set; }
		T IdsToSkip { get; set; }
		T ItemsPerPage { get; set; }
		T OrderBy { get; set; }
		T Page { get; set; }

		public IEnumerable<T> AsEnumerable()
		{
			return Enumerable.Empty<T>()
				.Append(Ids)
				.Append(IdsToSkip)
				.Append(ItemsPerPage)
				.Append(OrderBy)
				.Append(Page);
		}
	}
	public interface IQueryTyped<T> : IQuery<T> { }
	public interface IQuery
	{
		int[]? Ids { get; set; }
		int[]? IdsToSkip { get; set; }
		int? ItemsPerPage { get; set; }
		string? OrderBy { get; set; }
		int? Page { get; set; }

		public IEnumerable<string> AsQueryData(IQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = Enumerable.Empty<string>();

			if (Ids is not null)
				querydata = querydata.Concat(Ids.Select(id => string.Format("{0}={1}", keys?.Ids ?? nameof(Ids).ToLower(), id)));	

			if (IdsToSkip is not null)
				querydata = querydata.Concat(IdsToSkip.Select(idtoskip => string.Format("{0}={1}", keys?.IdsToSkip ?? nameof(IdsToSkip).ToLower(), idtoskip)));

			if (ItemsPerPage.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ItemsPerPage ?? nameof(ItemsPerPage).ToLower(), ItemsPerPage.Value));

			if (OrderBy is not null)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.OrderBy ?? nameof(OrderBy).ToLower(), OrderBy));
																																			   
			if (Page.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Page ?? nameof(Page).ToLower(), Page.Value));

			return querydata;
		}

		public interface IResult<T>
		{
			int? Page { get; set; }
			int? Pages { get; set; }
			IEnumerable<T>? Items { get; set; }

			public string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public interface IResult
		{
			public class Default<T> : IResult<T> 
			{
				public Default() { }
				public Default(JObject jobject)
				{
					Page = jobject.GetValue(nameof(Page), StringComparison.OrdinalIgnoreCase)?
						.ToObject<int?>();
					Pages = jobject.GetValue(nameof(Pages), StringComparison.OrdinalIgnoreCase)?
						.ToObject<int?>();
					Items = jobject.GetValue(nameof(Items), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							JObject jobject = JObject.FromObject(jtoken);

							if (jobject.GetValue(nameof(IStarWarsModel.Id), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is not int id)
								return default;

							Type type = typeof(T);

							object obj = true switch
							{
								true when type == typeof(ICharacterRetriever.IRetrieved) 
									=> new ICharacterRetriever.IRetrieved.Default(id, jobject),

								true when type == typeof(IFactionRetriever.IRetrieved)
									=> new IFactionRetriever.IRetrieved.Default(id, jobject),

								true when type == typeof(IFilmRetriever.IRetrieved) 
									=> new IFilmRetriever.IRetrieved.Default(id, jobject),			   

								true when type == typeof(IManufacturerRetriever.IRetrieved) 
									=> new IManufacturerRetriever.IRetrieved.Default(id, jobject),			   

								true when type == typeof(IPlanetRetriever.IRetrieved) 
									=> new IPlanetRetriever.IRetrieved.Default(id, jobject),			   

								true when type == typeof(ISpecieRetriever.IRetrieved) 
									=> new ISpecieRetriever.IRetrieved.Default(id, jobject),			   

								true when type == typeof(IStarshipRetriever.IRetrieved) 
									=> new IStarshipRetriever.IRetrieved.Default(id, jobject),			   

								true when type == typeof(IVehicleRetriever.IRetrieved) 
									=> new IVehicleRetriever.IRetrieved.Default(id, jobject),			   

								true when type == typeof(IWeaponRetriever.IRetrieved) 
									=> new IWeaponRetriever.IRetrieved.Default(id, jobject),

								_ => throw new ArgumentException(string.Format("Type '{0}' is not supported", type))
							};

							return (T)obj;

						}).OfType<T>();
				}

				public int? Page { get; set; }
				public int? Pages { get; set; }
				public IEnumerable<T>? Items { get; set; }
			}
		}

		public class Default : IQuery
		{
			public int[]? Ids { get; set; }
			public int[]? IdsToSkip { get; set; }
			public int? ItemsPerPage { get; set; }
			public string? OrderBy { get; set; }
			public int? Page { get; set; }
		}
		public class Default<T> : IQuery<T>
		{
			public Default(T defaultvalue)
			{
				Ids = defaultvalue;
				IdsToSkip = defaultvalue;
				ItemsPerPage = defaultvalue;
				OrderBy = defaultvalue;
				Page = defaultvalue;
			}

			public T Ids { get; set; }
			public T IdsToSkip { get; set; }
			public T ItemsPerPage { get; set; }
			public T OrderBy { get; set; }
			public T Page { get; set; }
		}
		public class DefaultTyped<T> : Default<T>, IQueryTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}

	public static class IQueryStringBuilderExtensions
	{				 
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IQuery.IResult<T>? queryresult)
		{
			if (queryresult is null)
				return stringbuilder;

			return stringbuilder
				.AppendFormat("{0}: {1}", nameof(IQuery.IResult<T>.Page), queryresult.Page).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IQuery.IResult<T>.Pages), queryresult.Pages).AppendLine()
				.AppendFormat("{0}: ", nameof(IQuery.IResult<T>.Items)).AppendLine()
				.AppendJoin(",\n", queryresult.Items ?? Enumerable.Empty<T>());
		}
	}
}
