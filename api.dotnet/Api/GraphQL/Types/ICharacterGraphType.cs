using Api.Queries;
using Api.Queries.Retrievers;
using Api.GraphQL.Queries;

using Domain.Models;

using GraphQL.Types;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Types
{
	public class ICharacterGraphType : IStarWarsModelGraphType<ICharacter>
	{
		public new class FieldNames : IStarWarsModelGraphType<ICharacter>.FieldNames
		{
			public const string BirthYear = nameof(ICharacter.BirthYear);
			public const string Description = nameof(ICharacter.Description);
			public const string EyeColors = nameof(ICharacter.EyeColors);
			public const string HairColors = nameof(ICharacter.HairColors);
			public const string Height = nameof(ICharacter.Height);
			public const string HomeworldId = nameof(ICharacter.HomeworldId);
			public const string Mass = nameof(ICharacter.Mass);
			public const string Name = nameof(ICharacter.Name);
			public const string Sex = nameof(ICharacter.Sex);
			public const string SkinColors = nameof(ICharacter.SkinColors);

			public const string Homeworld = "Homeworld";
		}

		public ICharacterGraphType() : base()
		{
			Field<DoubleGraphType>(FieldNames.BirthYear).Resolve(resolvefieldcontext => resolvefieldcontext.Source.BirthYear);
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<ListGraphType<EnumerationGraphType<KnownColor>>>(FieldNames.EyeColors).Resolve(resolvefieldcontext => resolvefieldcontext.Source.EyeColors);
			Field<ListGraphType<EnumerationGraphType<KnownColor>>>(FieldNames.HairColors).Resolve(resolvefieldcontext => resolvefieldcontext.Source.HairColors);
			Field<IntGraphType>(FieldNames.Height).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Height);
			Field<IntGraphType>(FieldNames.HomeworldId).Resolve(resolvefieldcontext => resolvefieldcontext.Source.HomeworldId);
			Field<DoubleGraphType>(FieldNames.Mass).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Mass);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<StringGraphType>(FieldNames.Sex).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Sex);
			Field<ListGraphType<EnumerationGraphType<KnownColor>>>(FieldNames.SkinColors).Resolve(resolvefieldcontext => resolvefieldcontext.Source.SkinColors);

			Field<IPlanetGraphType>(FieldNames.Homeworld).Resolve(resolvefieldcontext =>
			{
				if (resolvefieldcontext.Source.HomeworldId.HasValue)
				{
					return resolvefieldcontext.RequestServices?
						.GetService<IRepository>()?
						.Planets
						.AsQueryable()
						.FirstOrDefault(planet => planet.Id == resolvefieldcontext.Source.HomeworldId.Value);
				}

				return null;
			});
		}

		public static void AsQueryString(StringBuilder stringbuilder, ICharacterRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<ICharacter>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.BirthYear)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.BirthYear);

				hasprevious = true;
			}
			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

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
			if (retriever.Height)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Height);

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
			if (retriever.Mass)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Mass);

				hasprevious = true;
			}
			if (retriever.Name)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Name);

				hasprevious = true;
			}
			if (retriever.Sex)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Sex);

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
