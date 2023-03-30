using Api.Queries;
using Api.Queries.Retrievers;

using Domain.Enums;

using GraphQL.Types;

using System;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IQueryMetaResultGraphType : ObjectGraphType<IQueryMetaResult> 
	{
		public class FieldNames
		{
			public const string Id = nameof(IQueryMetaResult.Id);
			public const string StarWarsType = nameof(IQueryMetaResult.StarWarsType);
		}

		public IQueryMetaResultGraphType()
		{
			Field<IntGraphType>(FieldNames.Id).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Id);
			Field<EnumerationGraphType<StarWarsTypes>>(FieldNames.StarWarsType).Resolve(resolvefieldcontext => resolvefieldcontext.Source.StarWarsType);
		}

		public static void AsQueryString(StringBuilder stringbuilder, IQueryMetaResultRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			if (retriever.Id)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Id);

				hasprevious = true;
			}
			if (retriever.StarWarsType)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.StarWarsType);

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
	}
}
