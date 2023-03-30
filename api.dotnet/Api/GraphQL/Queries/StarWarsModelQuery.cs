using Api.Queries;

using Domain.Models;

using GraphQL;
using GraphQL.Types;

using System;
using System.Text;

namespace Api.GraphQL.Queries
{
	public partial class StarWarsModelQuery<TGraphType> : BaseQuery<TGraphType> where TGraphType : IGraphType
	{
		public new class Arguments : BaseQuery<TGraphType>.Arguments
		{
			public new class ArgumentNames : BaseQuery<TGraphType>.Arguments.ArgumentNames
			{
				public static readonly IQuery<string> Query = new IQuery.Default<string>(string.Empty)
				{
					Ids = nameof(IQuery.Ids).ToCamelCase(),
					IdsToSkip = nameof(IQuery.IdsToSkip).ToCamelCase(),
					ItemsPerPage = nameof(IQuery.ItemsPerPage).ToCamelCase(),
					OrderBy = nameof(IQuery.OrderBy).ToCamelCase(),
					Page = nameof(IQuery.Page).ToCamelCase(),
				};
			}

			public static IQuery DefaultQuery => new IQuery.Default
			{
				Ids = null,
				IdsToSkip = null,
				ItemsPerPage = 10,
				OrderBy = IStarWarsModel.ISortKeys.Keys.Id,
				Page = 1
			};

			public static QueryArgument IdsQueryArgument(int[]? defaultvalue = null) => new(new ArrayGraphType<int>())
			{
				Name = ArgumentNames.Query.Ids,
				DefaultValue = defaultvalue,
			};					 
			public static QueryArgument IdsToSkipQueryArgument(int[]? defaultvalue = null) => new(new ArrayGraphType<int>())
			{
				Name = ArgumentNames.Query.IdsToSkip,
				DefaultValue = defaultvalue,
			};
			public static QueryArgument ItemsPerPageQueryArgument(int? defaultvalue = null) => new(new IntGraphType())
			{
				Name = ArgumentNames.Query.ItemsPerPage,
				DefaultValue = defaultvalue,
			};
			public static QueryArgument OrderByArgument(string? defaultvalue = null) => new(new StringGraphType())
			{
				Name = ArgumentNames.Query.OrderBy,
				DefaultValue = defaultvalue,
			};
			public static QueryArgument PageQueryArgument(int? defaultvalue = null) => new(new IntGraphType())
			{
				Name = ArgumentNames.Query.Page,
				DefaultValue = defaultvalue,
			};
			public static QueryArguments QueryArguments(IQuery? defaultquery = null)
			{
				return new QueryArguments
				(
					IdsQueryArgument(defaultquery?.Ids),
					IdsToSkipQueryArgument(defaultquery?.IdsToSkip),
					ItemsPerPageQueryArgument(defaultquery?.ItemsPerPage),
					OrderByArgument(defaultquery?.OrderBy),
					PageQueryArgument(defaultquery?.Page)
				);
			}

			public static IQuery GenerateQuery(IResolveFieldContext resolvefieldcontext, IQuery? defaultquery = null)
			{
				IQuery query = new IQuery.Default
				{
					Ids = resolvefieldcontext.Variables.ValueFor(ArgumentNames.Query.Ids, null) as int[],
					IdsToSkip = resolvefieldcontext.Variables.ValueFor(ArgumentNames.Query.IdsToSkip, null) as int[],
					ItemsPerPage = resolvefieldcontext.Variables.ValueFor(ArgumentNames.Query.ItemsPerPage, null) as int?,  
					OrderBy = resolvefieldcontext.Variables.ValueFor(ArgumentNames.Query.OrderBy, null) as string,
					Page = resolvefieldcontext.Variables.ValueFor(ArgumentNames.Query.Page, null) as int?,
				};

				if (resolvefieldcontext.Arguments != null) 
				{
					query.Ids ??= resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.Query.Ids)
						? resolvefieldcontext.Arguments[ArgumentNames.Query.Ids].Value as int[]
						: defaultquery?.Ids;
					query.IdsToSkip ??= resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.Query.IdsToSkip) 
						? resolvefieldcontext.Arguments[ArgumentNames.Query.IdsToSkip].Value as int[]
						: defaultquery?.IdsToSkip;
					query.ItemsPerPage ??= resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.Query.ItemsPerPage)
						? resolvefieldcontext.Arguments[ArgumentNames.Query.ItemsPerPage].Value as int?
						: defaultquery?.ItemsPerPage;
					query.OrderBy ??= resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.Query.OrderBy) 
						? resolvefieldcontext.Arguments[ArgumentNames.Query.OrderBy].Value as string
						: defaultquery?.OrderBy;
					query.Page ??= resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.Query.Page) 
						? resolvefieldcontext.Arguments[ArgumentNames.Query.Page].Value as int?
						: defaultquery?.Page;
				}

				return query;
			}

			public static string? QueryArgumentsAsString(IQuery arguments)
			{
				bool hasprevious = false;

				StringBuilder stringbuilder = new();

				if (arguments.Ids is not null)
				{
					if (hasprevious is true) stringbuilder
						.Append(',');

					stringbuilder
						.AppendFormat("{0}: {1}", ArgumentNames.Query.Ids, arguments.Ids);

					hasprevious = true;
				}	   
				if (arguments.IdsToSkip is not null)
				{
					if (hasprevious is true) stringbuilder
						.Append(',');

					stringbuilder
						.AppendFormat("{0}: {1}", ArgumentNames.Query.IdsToSkip, arguments.IdsToSkip);

					hasprevious = true;
				}
				if (arguments.ItemsPerPage is not null)
				{
					if (hasprevious is true) stringbuilder
						.Append(',');

					stringbuilder
						.AppendFormat("{0}: {1}", ArgumentNames.Query.ItemsPerPage , arguments.ItemsPerPage);

					hasprevious = true;
				}
				if (arguments.OrderBy is not null)
				{
					if (hasprevious is true) stringbuilder
							.Append(',');

					stringbuilder
						.AppendFormat("{0}: \"{1}\"", ArgumentNames.Query.OrderBy, arguments.OrderBy);

					hasprevious = true;
				}
				if (arguments.Page is not null)
				{
					if (hasprevious is true) stringbuilder
							.Append(',');

					stringbuilder
						.AppendFormat("{0}: {1}", ArgumentNames.Query.Page, arguments.Page);

					hasprevious = true;
				}

				if (hasprevious is false)
					return null;

				return stringbuilder.ToString();
			}
		}

		public StarWarsModelQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }
	}
}
