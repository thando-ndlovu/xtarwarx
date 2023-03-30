using Api.Queries;
using Api.Queries.Retrievers;

using Domain.Enums;

using GraphQL.Types;

using System;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IQuerySearchResultGraphType : ObjectGraphType<IQuerySearchResult> 
	{
		public class FieldNames
		{
			public const string Id = nameof(IQuerySearchResult.Id);
			public const string MatchCount = nameof(IQuerySearchResult.MatchCount);
			public const string StarWarsType = nameof(IQuerySearchResult.StarWarsType);
		}

		public IQuerySearchResultGraphType()
		{
			Field<IntGraphType>(FieldNames.Id).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Id);
			Field<IntGraphType>(FieldNames.MatchCount).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MatchCount);
			Field<EnumerationGraphType<StarWarsTypes>>(FieldNames.StarWarsType).Resolve(resolvefieldcontext => resolvefieldcontext.Source.StarWarsType);
		}

		public static void AsQueryString(StringBuilder stringbuilder, IQuerySearchResultRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			if (retriever.Id)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Id);

				hasprevious = true;
			}
			if (retriever.MatchCount)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MatchCount);

				hasprevious = true;
			}
			if (retriever.StarWarsType)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.StarWarsType);
			}

			containsprevious = hasprevious;
		}
	}
}
