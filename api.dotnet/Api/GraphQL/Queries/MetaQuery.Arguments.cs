using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;
using GraphQL.Types;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Api.GraphQL.Queries
{
	public partial class MetaQuery
	{
		public new class Arguments : BaseQuery<IQueryMetaResultGraphType>.Arguments
		{
			public new class ArgumentNames : BaseQuery<IQueryMetaResultGraphType>.Arguments.ArgumentNames
			{
				public static readonly IQueryMeta<string> QueryMeta = new IQueryMeta.Default<string>(string.Empty)
				{
					AdditionsSince = nameof(IQueryMeta.AdditionsSince),
					EditsSince = nameof(IQueryMeta.EditsSince),
				};
			}

			public static IQueryMeta DefaultQuery => new IQueryMeta.Default
			{
				AdditionsSince = null,
				EditsSince = null,
			};

			public static QueryArgument AdditionsSinceQueryArgument(string? defaultvalue = null) => new(new StringGraphType())
			{
				Name = ArgumentNames.QueryMeta.AdditionsSince,
				DefaultValue = defaultvalue,
			};
			public static QueryArgument EditsSinceQueryArgument(string? defaultvalue = null) => new(new StringGraphType())
			{
				Name = ArgumentNames.QueryMeta.EditsSince,
				DefaultValue = defaultvalue,
			};
			public static QueryArguments QueryArguments(IQueryMeta? defaultquery = null)
			{
				return new QueryArguments
				(
					AdditionsSinceQueryArgument(defaultquery?.AdditionsSince),
					EditsSinceQueryArgument(defaultquery?.EditsSince)
				);
			}

			public static IQueryMeta GenerateQuery(IResolveFieldContext resolvefieldcontext, IQueryMeta? defaultquery = null)
			{
				IQueryMeta query = new IQueryMeta.Default
				{
					AdditionsSince = resolvefieldcontext.Arguments?.ContainsKey(ArgumentNames.QueryMeta.AdditionsSince) ?? false
						? resolvefieldcontext.Arguments[ArgumentNames.QueryMeta.AdditionsSince].Value as string
						: defaultquery?.AdditionsSince,

					EditsSince = resolvefieldcontext.Arguments?.ContainsKey(ArgumentNames.QueryMeta.EditsSince) ?? false
						? resolvefieldcontext.Arguments[ArgumentNames.QueryMeta.EditsSince].Value as string
						: defaultquery?.EditsSince,
				};

				return query;
			}

			public static string? QueryArgumentsAsString(IQueryMeta arguments)
			{
				bool hasprevious = false;

				StringBuilder stringbuilder = new();

				if (arguments.AdditionsSince is not null)
				{
					if (hasprevious is true) stringbuilder
						.Append(',');

					stringbuilder
						.AppendFormat("{0}: {1}", ArgumentNames.QueryMeta.AdditionsSince, arguments.AdditionsSince);

					hasprevious = true;
				}
				if (arguments.EditsSince is not null)
				{
					if (hasprevious is true) stringbuilder
						.Append(',');

					stringbuilder
						.AppendFormat("{0}: {1}", ArgumentNames.QueryMeta.EditsSince, arguments.EditsSince);

					hasprevious = true;
				}

				if (hasprevious is false)
					return null;

				return stringbuilder.ToString();
			}
		}
	}
}
