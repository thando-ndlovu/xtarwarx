using Api.Queries.Retrievers;

using Domain.Models;

using GraphQL;
using GraphQL.Types;
using GraphQL.Resolvers;

using System;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IStarWarsModelGraphType<TStarWarsModel> : ObjectGraphType<TStarWarsModel> where TStarWarsModel : IStarWarsModel
	{
		public static void AsQueryString(StringBuilder stringbuilder, IStarWarsModelRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			if (retriever.Created)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Created);

				hasprevious = true;
			}
			if (retriever.Edited)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Edited);

				hasprevious = true;
			}
			if (retriever.Id)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Id);

				hasprevious = true;
			}
			if (retriever.Uris is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Uris);

				stringbuilder.Append('{');
				IStarWarsModelURIGraphType .AsQueryString(stringbuilder, retriever.Uris);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}

		public class FieldNames
		{
			public const string Id = nameof(IStarWarsModel.Id);
			public const string Created = nameof(IStarWarsModel.Created);
			public const string Edited = nameof(IStarWarsModel.Edited);
			public const string Uris = nameof(IStarWarsModel.Uris);
		}
		

		public IStarWarsModelGraphType()
		{
			Field<IntGraphType>(FieldNames.Id).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Id);
			Field<DateTimeGraphType>(FieldNames.Created).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Created);
			Field<DateTimeGraphType>(FieldNames.Edited).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Edited);
			Field<ListGraphType<IStarWarsModelURIGraphType>>(FieldNames.Uris).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Uris);
		}
	}

	public class IStarWarsModelURIGraphType : ObjectGraphType<IStarWarsModel.IURI>
	{
		public static void AsQueryString(StringBuilder stringbuilder, IStarWarsModel.IURI<bool> retriever)
		{
			bool hasprevious = false;

			if (retriever.Key)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Key);

				hasprevious = true;
			}
			if (retriever.Uri)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Uri);
			}
		}

		public class FieldNames
		{
			public const string Key = nameof(IStarWarsModel.IURI.Key);
			public const string Uri = nameof(IStarWarsModel.IURI.Uri);
		}
		public IStarWarsModelURIGraphType ()
		{
			Field<StringGraphType>(FieldNames.Key).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Key);
			Field<UriGraphType>(FieldNames.Uri).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Uri);
		}
	}
}
