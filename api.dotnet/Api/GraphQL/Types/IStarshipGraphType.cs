using Api.Queries;
using Api.Queries.Retrievers;
using Api.GraphQL.Queries;

using Domain.Models;

using GraphQL.Types;

using System;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IStarshipGraphType : ITransporterGraphType<IStarship>
	{
		public static void AsQueryString(StringBuilder stringbuilder, IStarshipRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			ITransporterGraphType<IStarship>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.HyperdriveRating)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.HyperdriveRating);

				hasprevious = true;
			}																							 
			if (retriever.MGLT)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MGLT);

				hasprevious = true;
			}
			if (retriever.StarshipClass is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.StarshipClass);

				stringbuilder.Append('{');
				IStarshipClassGraphType.AsQueryString(stringbuilder, retriever.StarshipClass);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}

		public new class FieldNames : ITransporterGraphType<IStarship>.FieldNames
		{
			public const string HyperdriveRating = nameof(IStarship.HyperdriveRating);
			public const string MGLT = nameof(IStarship.MGLT);
			public const string StarshipClass = nameof(IStarship.StarshipClass);
		}

		public class IStarshipClassGraphType : ObjectGraphType<IStarship.IStarshipClass>
		{
			public static void AsQueryString(StringBuilder stringbuilder, IStarship.IStarshipClass<bool> retriever)
			{
				bool hasprevious = false;

				if (retriever.Class)
				{
					stringbuilder
						.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Class);

					hasprevious = true;
				}
				if (retriever.Flags)
				{
					stringbuilder
						.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Flags);
				}
			}

			public class FieldNames
			{
				public const string Class = nameof(IStarship.IStarshipClass.Class);
				public const string Flags = nameof(IStarship.IStarshipClass.Flags);
			}

			public IStarshipClassGraphType()
			{
				Field<StringGraphType>(FieldNames.Class).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Class);
				Field<ListGraphType<StringGraphType>>(FieldNames.Flags).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Flags);
			}
		}

		public IStarshipGraphType(IServiceProvider serviceprovider) : base(serviceprovider)
		{
			Field<DoubleGraphType>(FieldNames.HyperdriveRating).Resolve(resolvefieldcontext => resolvefieldcontext.Source.HyperdriveRating);
			Field<IntGraphType>(FieldNames.MGLT).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MGLT);
			Field<IStarshipClassGraphType>(FieldNames.StarshipClass).Resolve(resolvefieldcontext => resolvefieldcontext.Source.StarshipClass);
		}
	}
}
