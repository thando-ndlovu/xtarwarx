using Api.Queries;
using Api.Queries.Retrievers;
using Api.GraphQL.Queries;

using Domain.Models;

using GraphQL.Resolvers;
using GraphQL.Types;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IManufacturerGraphType : IStarWarsModelGraphType<IManufacturer>
	{
		public new class FieldNames : IStarWarsModelGraphType<IManufacturer>.FieldNames
		{
			public const string Description = nameof(IManufacturer.Description);
			public const string HeadquatersPlanetId = nameof(IManufacturer.HeadquatersPlanetId);
			public const string Name = nameof(IManufacturer.Name);
			public const string StarshipIds = nameof(IManufacturer.StarshipIds);
			public const string VehicleIds = nameof(IManufacturer.VehicleIds);
			public const string WeaponIds = nameof(IManufacturer.WeaponIds);

			public const string HeadquatersPlanet = "HeadquatersPlanet";
			public const string Starships = "Starships";
			public const string Vehicles = "Vehicles";
			public const string Weapons = "Weapons";
		}

		public IManufacturerGraphType() : base()
		{
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<IntGraphType>(FieldNames.HeadquatersPlanetId).Resolve(resolvefieldcontext => resolvefieldcontext.Source.HeadquatersPlanetId);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<ListGraphType<IntGraphType>>(FieldNames.StarshipIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.StarshipIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.VehicleIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.VehicleIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.WeaponIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.WeaponIds);

			Field<IPlanetGraphType>(FieldNames.HeadquatersPlanet).Resolve(resolvefieldcontext =>
			{
				if (resolvefieldcontext.Source.HeadquatersPlanetId.HasValue)
				{
					return resolvefieldcontext.RequestServices.GetService<IRepository>()?
						.Planets
						.AsQueryable()
						.FirstOrDefault(planet => planet.Id == resolvefieldcontext.Source.HeadquatersPlanetId.Value);
				}

				return null;
			});
			Field<StarshipsQuery.Result>(FieldNames.Starships)
				.Arguments(StarshipsQuery.Arguments.QueryArguments(StarshipsQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = StarshipsQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = StarshipsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IManufacturer)?.StarshipIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<VehiclesQuery.Result>(FieldNames.Vehicles)
				.Arguments(VehiclesQuery.Arguments.QueryArguments(VehiclesQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = VehiclesQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = VehiclesQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IManufacturer)?.VehicleIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<WeaponsQuery.Result>(FieldNames.Weapons)
				.Arguments(WeaponsQuery.Arguments.QueryArguments(WeaponsQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = WeaponsQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = WeaponsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IManufacturer)?.WeaponIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
		}

		public static void AsQueryString(StringBuilder stringbuilder, IManufacturerRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<IManufacturer>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

				hasprevious = true;
			}  
			if (retriever.HeadquatersPlanetId)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.HeadquatersPlanetId);

				hasprevious = true;
			}
			if (retriever.HeadquatersPlanet is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.HeadquatersPlanet);

				stringbuilder.Append('{');
				IPlanetGraphType.AsQueryString(stringbuilder, retriever.HeadquatersPlanet, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Name)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Name);

				hasprevious = true;
			}
			if (retriever.StarshipIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.StarshipIds);

				hasprevious = true;
			}
			if (retriever.Starships is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Starships);

				stringbuilder.Append('{');
				IStarshipGraphType.AsQueryString(stringbuilder, retriever.Starships, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.VehicleIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.VehicleIds);

				hasprevious = true;
			}
			if (retriever.Vehicles is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Vehicles);

				stringbuilder.Append('{');
				IVehicleGraphType.AsQueryString(stringbuilder, retriever.Vehicles, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.WeaponIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.WeaponIds);

				hasprevious = true;
			}
			if (retriever.Weapons is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Weapons);

				stringbuilder.Append('{');
				IWeaponGraphType.AsQueryString(stringbuilder, retriever.Weapons, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
	}
}
