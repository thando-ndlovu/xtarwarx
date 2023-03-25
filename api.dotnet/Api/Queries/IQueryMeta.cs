using Domain.Enums;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Queries
{
	public interface IQueryMeta<T>
	{
		T AdditionsSince { get; set; }
		T EditsSince { get; set; }

		public IEnumerable<T> AsEnumerable()
		{
			return Enumerable.Empty<T>()
				.Append(AdditionsSince)
				.Append(EditsSince);
		}
	}
	public interface IQueryMetaTyped<T> : IQueryMeta<T> { }
	public interface IQueryMeta
	{
		string? AdditionsSince { get; set; }
		string? EditsSince { get; set; }

		public IEnumerable<string> AsQueryData(IQueryMeta<string>? keys = null)
		{
			IEnumerable<string> querydata = Enumerable.Empty<string>();

			if (AdditionsSince is not null)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AdditionsSince ?? nameof(AdditionsSince).ToLower(), AdditionsSince));				  

			if (EditsSince is not null)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.EditsSince ?? nameof(EditsSince).ToLower(), EditsSince));

			return querydata;
		}

		public interface IResult : IEnumerable<IQueryMetaResult> 
		{
			public class Default : IResult
			{
				public Default() { }
				public Default(IEnumerable<IQueryMetaResult> results)
				{
					Results = results;
				}

				public IEnumerable<IQueryMetaResult> Results { get; set; } = Enumerable.Empty<IQueryMetaResult>();

				IEnumerator IEnumerable.GetEnumerator()
				{
					return Results.GetEnumerator();
				}
				IEnumerator<IQueryMetaResult> IEnumerable<IQueryMetaResult>.GetEnumerator()
				{
					return Results.GetEnumerator();
				}
			}
		}

		public class Default : IQueryMeta
		{
			public string? AdditionsSince { get; set; }
			public string? EditsSince { get; set; }
		}
		public class Default<T> : IQueryMeta<T>
		{
			public Default(T defaultvalue)
			{
				AdditionsSince = defaultvalue;
				EditsSince = defaultvalue;
			}

			public T AdditionsSince { get; set; }
			public T EditsSince { get; set; }
		}
		public class DefaultTyped<T> : Default<T>, IQueryMeta<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}

	public interface IQueryMetaResult<T>
	{
		T Id { get; set; }
		T StarWarsType { get; set; }
	}
	public interface IQueryMetaResultTyped<T> : IQueryMetaResult<T> { }
	public interface IQueryMetaResult
	{
		int Id { get; set; }
		StarWarsTypes StarWarsType { get; set; }

		public class Default : IQueryMetaResult
		{
			public int Id { get; set; }
			public StarWarsTypes StarWarsType { get; set; }
		}
		public class Default<T> : IQueryMetaResult<T>
		{
			public Default(T defaultvalue)
			{
				Id = defaultvalue;
				StarWarsType = defaultvalue;
			}

			public T Id { get; set; }
			public T StarWarsType { get; set; }
		}
		public class DefaultTyped<T> : Default<T>, IQueryMetaResultTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}
}
																						  