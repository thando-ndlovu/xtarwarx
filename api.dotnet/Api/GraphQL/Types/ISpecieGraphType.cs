using Api.Queries;
using Api.Queries.Retrievers;
using Api.GraphQL.Queries;

using Domain.Models;

using GraphQL.Resolvers;
using GraphQL.Types;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Types
{
	public class ISpecieGraphType : IStarWarsModelGraphType<ISpecie>
	{
		public new class FieldNames : IStarWarsModelGraphType<ISpecie>.FieldNames
		{
			public const string AverageHeight = nameof(ISpecie.AverageHeight);
			public const string AverageLifespan = nameof(ISpecie.AverageLifespan);
			public const string CharacterIds = nameof(ISpecie.CharacterIds);
			public const string Classification = nameof(ISpecie.Classification);
			public const string Description = nameof(ISpecie.Description);
			public const string Designation = nameof(ISpecie.Designation);
			public const string EyeColors = nameof(ISpecie.EyeColors);
			public const string HairColors = nameof(ISpecie.HairColors);
			public const string HomeworldId = nameof(ISpecie.HomeworldId);
			public const string Language = nameof(ISpecie.Language);
			public const string Name = nameof(ISpecie.Name);
			public const string SkinColors = nameof(ISpecie.SkinColors);

			public const string Characters = "Characters";
			public const string Homeworld = "Homeworld";
		}

		public ISpecieGraphType() : base()
		{
			Field<IntGraphType>(FieldNames.AverageHeight).Resolve(resolvefieldcontext => resolvefieldcontext.Source.AverageHeight);
			Field<IntGraphType>(FieldNames.AverageLifespan).Resolve(resolvefieldcontext => resolvefieldcontext.Source.AverageLifespan);
			Field<ListGraphType<IntGraphType>>(FieldNames.CharacterIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.CharacterIds);
			Field<StringGraphType>(FieldNames.Classification).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Classification);
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<StringGraphType>(FieldNames.Designation).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Designation);
			Field<ListGraphType<EnumerationGraphType<KnownColor>>>(FieldNames.EyeColors).Resolve(resolvefieldcontext => resolvefieldcontext.Source.EyeColors);
			Field<ListGraphType<EnumerationGraphType<KnownColor>>>(FieldNames.HairColors).Resolve(resolvefieldcontext => resolvefieldcontext.Source.HairColors);
			Field<IntGraphType>(FieldNames.HomeworldId).Resolve(resolvefieldcontext => resolvefieldcontext.Source.HomeworldId);
			Field<StringGraphType>(FieldNames.Language).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Language);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<ListGraphType<EnumerationGraphType<KnownColor>>>(FieldNames.SkinColors).Resolve(resolvefieldcontext => resolvefieldcontext.Source.SkinColors);

			Field<CharactersQuery.Result>(FieldNames.Characters)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as ISpecie)?.CharacterIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<IPlanetGraphType>(FieldNames.Homeworld).Resolve(resolvefieldcontext =>
			{
				if (resolvefieldcontext.Source.HomeworldId.HasValue)
				{
					return resolvefieldcontext.RequestServices?.GetService<IRepository>()?
						.Planets
						.AsQueryable()
						.FirstOrDefault(planet => planet.Id == resolvefieldcontext.Source.HomeworldId.Value);
				}

				return null;
			});
		}

		public static void AsQueryString(StringBuilder stringbuilder, ISpecieRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<ISpecie>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.AverageHeight)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.AverageHeight);

				hasprevious = true;
			}																						  
			if (retriever.AverageLifespan)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.AverageLifespan);

				hasprevious = true;
			}																						  
			if (retriever.CharacterIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.CharacterIds);

				hasprevious = true;
			}
			if (retriever.Characters is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Characters);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.Characters, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Classification)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Classification);

				hasprevious = true;
			}
			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

				hasprevious = true;
			}
			if (retriever.Designation)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Designation);

				hasprevious = true;
			}
			if (retriever.EyeColors)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.EyeColors);

				hasprevious = true;
			}
			if (retriever.HairColors)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.HairColors);

				hasprevious = true;
			}
			if (retriever.HomeworldId)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.HomeworldId);

				hasprevious = true;
			}
			if (retriever.Homeworld is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Homeworld);

				stringbuilder.Append('{');
				IPlanetGraphType.AsQueryString(stringbuilder, retriever.Homeworld, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Language)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Language);

				hasprevious = true;
			}
			if (retriever.Name)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Name);

				hasprevious = true;
			}
			if (retriever.SkinColors)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.SkinColors);

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
	}
}
