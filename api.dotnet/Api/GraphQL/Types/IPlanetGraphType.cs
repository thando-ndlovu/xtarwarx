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
	public class IPlanetGraphType : IStarWarsModelGraphType<IPlanet>
	{
		public new class FieldNames : IStarWarsModelGraphType<IPlanet>.FieldNames
		{
			public const string Climates = nameof(IPlanet.Climates);
			public const string Description = nameof(IPlanet.Description);
			public const string Diameter = nameof(IPlanet.Diameter);
			public const string Gravity = nameof(IPlanet.Gravity);
			public const string Name = nameof(IPlanet.Name);
			public const string OrbitalPeriod = nameof(IPlanet.OrbitalPeriod);
			public const string Population = nameof(IPlanet.Population);
			public const string ResidentIds = nameof(IPlanet.ResidentIds);
			public const string RotationalPeriod = nameof(IPlanet.RotationalPeriod);
			public const string SurfaceWater = nameof(IPlanet.SurfaceWater);
			public const string Terrains = nameof(IPlanet.Terrains);

			public const string Residents = "Residents";
		}

		public class IClimateGraphType : ObjectGraphType<IPlanet.IClimate>
		{
			public static void AsQueryString(StringBuilder stringbuilder, IPlanet.IClimate<bool> retriever)
			{
				bool hasprevious = false;

				if (retriever.Type)
				{
					stringbuilder
						.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Type);

					hasprevious = true;
				}
				if (retriever.Flags)
				{
					stringbuilder
						.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Flags);

					hasprevious = true;
				}
			}

			public class FieldNames
			{
				public const string Flags = nameof(IPlanet.IClimate.Flags);
				public const string Type = nameof(IPlanet.IClimate.Type);
			}

			public IClimateGraphType()
			{
				Field<StringGraphType>(FieldNames.Type).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Type);
				Field<ListGraphType<StringGraphType>>(FieldNames.Flags).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Flags);
			}
		}
		public class ITerrainGraphType : ObjectGraphType<IPlanet.ITerrain>
		{
			public static void AsQueryString(StringBuilder stringbuilder, IPlanet.ITerrain<bool> retriever)
			{
				bool hasprevious = false;

				if (retriever.Type)
				{
					stringbuilder
						.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Type);

					hasprevious = true;
				}
				if (retriever.Flags)
				{
					stringbuilder
						.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Flags);

					hasprevious = true;
				}
			}

			public class FieldNames
			{
				public const string Flags = nameof(IPlanet.ITerrain.Flags);
				public const string Type = nameof(IPlanet.ITerrain.Type);
			}

			public ITerrainGraphType()
			{
				Field<ListGraphType<StringGraphType>>(FieldNames.Flags).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Flags);
				Field<StringGraphType>(FieldNames.Type).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Type);
			}
		}

		public IPlanetGraphType() : base()
		{
			Field<ListGraphType<IClimateGraphType>>(FieldNames.Climates).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Climates);
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<IntGraphType>(FieldNames.Diameter).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Diameter);
			Field<DoubleGraphType>(FieldNames.Gravity).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Gravity);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<TimeSpanDaysGraphType>(FieldNames.OrbitalPeriod).Resolve(resolvefieldcontext => resolvefieldcontext.Source.OrbitalPeriod);
			Field<StringGraphType>(FieldNames.Population).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Population);
			Field<ListGraphType<IntGraphType>>(FieldNames.ResidentIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.ResidentIds);
			Field<TimeSpanHoursGraphType>(FieldNames.RotationalPeriod).Resolve(resolvefieldcontext => resolvefieldcontext.Source.RotationalPeriod);
			Field<DoubleGraphType>(FieldNames.SurfaceWater).Resolve(resolvefieldcontext => resolvefieldcontext.Source.SurfaceWater);
			Field<ListGraphType<ITerrainGraphType>>(FieldNames.Terrains).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Terrains);

			Field<CharactersQuery.Result>(FieldNames.Residents)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as IPlanet)?.ResidentIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
		}

		public static void AsQueryString(StringBuilder stringbuilder, IPlanetRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<IPlanet>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.Climates is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Climates);

				stringbuilder.Append('{');
				IClimateGraphType.AsQueryString(stringbuilder, retriever.Climates);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

				hasprevious = true;
			}
			if (retriever.Diameter)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Diameter);

				hasprevious = true;
			}
			if (retriever.Gravity)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Gravity);

				hasprevious = true;
			}
			if (retriever.Name)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Name);

				hasprevious = true;
			}
			if (retriever.OrbitalPeriod)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.OrbitalPeriod);

				hasprevious = true;
			}
			if (retriever.Population)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.OrbitalPeriod);

				hasprevious = true;
			}
			if (retriever.ResidentIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.ResidentIds);

				hasprevious = true;
			}
			if (retriever.Residents is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Residents);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.Residents, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.RotationalPeriod)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.RotationalPeriod);

				hasprevious = true;
			}
			if (retriever.SurfaceWater)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.SurfaceWater);

				hasprevious = true;
			}
			if (retriever.Terrains is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Terrains);

				stringbuilder.Append('{');
				ITerrainGraphType.AsQueryString(stringbuilder, retriever.Terrains);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
	}
}
