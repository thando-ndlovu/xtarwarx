using Api.Queries;
using Api.Queries.Retrievers;
using Api.GraphQL.Queries;

using Domain.Models;

using GraphQL.Resolvers;
using GraphQL.Types;

using System;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IFactionGraphType : IStarWarsModelGraphType<IFaction>
	{
		public new class FieldNames : IStarWarsModelGraphType<IFaction>.FieldNames
		{
			public const string AlliedCharacterIds = nameof(IFaction.AlliedCharacterIds);
			public const string AlliedFactionIds = nameof(IFaction.AlliedFactionIds);
			public const string Description = nameof(IFaction.Description);
			public const string LeaderIds = nameof(IFaction.LeaderIds);
			public const string Name = nameof(IFaction.Name);
			public const string MemberCharacterIds = nameof(IFaction.MemberCharacterIds);
			public const string MemberFactionIds = nameof(IFaction.MemberFactionIds);
			public const string OrganizationTypes = nameof(IFaction.OrganizationTypes);

			public const string AlliedCharacters = "AlliedCharacters";
			public const string AlliedFactions = "AlliedFactions";
			public const string Leaders = "Leaders";
			public const string MemberCharacters = "MemberCharacters";
			public const string MemberFactions = "MemberFactions";
		}

		public IFactionGraphType(IServiceProvider serviceprovider) : base(serviceprovider)
		{
			Field<ListGraphType<IntGraphType>>(FieldNames.AlliedCharacterIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.AlliedCharacterIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.AlliedFactionIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.AlliedFactionIds);
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<ListGraphType<IntGraphType>>(FieldNames.LeaderIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.LeaderIds);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<ListGraphType<IntGraphType>>(FieldNames.MemberCharacterIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MemberCharacterIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.MemberFactionIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MemberFactionIds);
			Field<ListGraphType<StringGraphType>>(FieldNames.OrganizationTypes).Resolve(resolvefieldcontext => resolvefieldcontext.Source.OrganizationTypes);

			Field<CharactersQuery.Result>(FieldNames.AlliedCharacters)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(serviceprovider, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as IFaction)?.AlliedCharacterIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<FactionsQuery.Result>(FieldNames.AlliedFactions)
				.Arguments(FactionsQuery.Arguments.QueryArguments(FactionsQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = FactionsQuery.Resolve(serviceprovider, resolvefieldcontext =>
						{
							IQuery factionsquery = FactionsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFaction)?.AlliedFactionIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<CharactersQuery.Result>(FieldNames.Leaders)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(serviceprovider, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as IFaction)?.LeaderIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<CharactersQuery.Result>(FieldNames.MemberCharacters)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(serviceprovider, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as IFaction)?.MemberCharacterIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<FactionsQuery.Result>(FieldNames.MemberFactions)
				.Arguments(FactionsQuery.Arguments.QueryArguments(FactionsQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = FactionsQuery.Resolve(serviceprovider, resolvefieldcontext =>
						{
							IQuery factionsquery = FactionsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFaction)?.MemberFactionIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
		}

		public static void AsQueryString(StringBuilder stringbuilder, IFactionRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<IFaction>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.AlliedCharacterIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.AlliedCharacterIds);

				hasprevious = true;
			}
			if (retriever.AlliedCharacters is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.AlliedCharacters);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.AlliedCharacters, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.AlliedFactionIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.AlliedFactionIds);

				hasprevious = true;
			}
			if (retriever.AlliedFactions is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.AlliedFactions);

				stringbuilder.Append('{');
				IFactionGraphType.AsQueryString(stringbuilder, retriever.AlliedFactions, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

				hasprevious = true;
			}
			if (retriever.LeaderIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.LeaderIds);

				hasprevious = true;
			}
			if (retriever.Leaders is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Leaders);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.Leaders, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Name)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Name);

				hasprevious = true;
			}
			if (retriever.MemberCharacterIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MemberCharacterIds);

				hasprevious = true;
			}
			if (retriever.MemberCharacters is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MemberCharacters);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.MemberCharacters, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.MemberFactionIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MemberFactionIds);

				hasprevious = true;
			}
			if (retriever.MemberFactions is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MemberFactions);

				stringbuilder.Append('{');
				IFactionGraphType.AsQueryString(stringbuilder, retriever.MemberFactions, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.OrganizationTypes)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.OrganizationTypes);

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
	}
}
