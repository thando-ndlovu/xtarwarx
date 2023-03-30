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
	public class ITransporterGraphType<TTransporter> : IStarWarsModelGraphType<TTransporter> where TTransporter : ITransporter 
	{
		public new class FieldNames : IStarWarsModelGraphType<ITransporter>.FieldNames
		{
			public const string CargoCapacity = nameof(ITransporter.CargoCapacity);
			public const string Consumables = nameof(ITransporter.Consumables);
			public const string CostInCredits = nameof(ITransporter.CostInCredits);
			public const string Description = nameof(ITransporter.Description);
			public const string Length = nameof(ITransporter.Length);
			public const string ManufacturerIds = nameof(ITransporter.ManufacturerIds);
			public const string MaxAtmospheringSpeed = nameof(ITransporter.MaxAtmospheringSpeed);
			public const string MaxCrew = nameof(ITransporter.MaxCrew);
			public const string MinCrew = nameof(ITransporter.MinCrew);
			public const string Model = nameof(ITransporter.Model);
			public const string Name = nameof(ITransporter.Name);
			public const string Passengers = nameof(ITransporter.Passengers);
			public const string PilotIds = nameof(ITransporter.PilotIds);

			public const string Manufacturers = "Manufacturers";
			public const string Pilots = "Pilots";
		}

		public ITransporterGraphType() : base()
		{
			Field<LongGraphType>(FieldNames.CargoCapacity).Resolve(resolvefieldcontext => resolvefieldcontext.Source.CargoCapacity);
			Field<ITransporterConsumableGraphType>(FieldNames.Consumables).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Consumables);
			Field<LongGraphType>(FieldNames.CostInCredits).Resolve(resolvefieldcontext => resolvefieldcontext.Source.CostInCredits);
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<DoubleGraphType>(FieldNames.Length).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Length);
			Field<ListGraphType<IntGraphType>>(FieldNames.ManufacturerIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.ManufacturerIds);
			Field<IntGraphType>(FieldNames.MaxAtmospheringSpeed).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MaxAtmospheringSpeed);
			Field<IntGraphType>(FieldNames.MaxCrew).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MaxCrew);
			Field<IntGraphType>(FieldNames.MinCrew).Resolve(resolvefieldcontext => resolvefieldcontext.Source.MinCrew);
			Field<StringGraphType>(FieldNames.Model).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Model);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<IntGraphType>(FieldNames.Passengers).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Passengers);
			Field<ListGraphType<IntGraphType>>(FieldNames.PilotIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.PilotIds);

			Field<ManufacturersQuery.Result>(FieldNames.Manufacturers)
				.Arguments(ManufacturersQuery.Arguments.QueryArguments(ManufacturersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = ManufacturersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = ManufacturersQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as ITransporter)?.ManufacturerIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<CharactersQuery.Result>(FieldNames.Pilots)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as ITransporter)?.PilotIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
		}

		public static void AsQueryString(StringBuilder stringbuilder, ITransporterRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<TTransporter>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.CargoCapacity)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.CargoCapacity);

				hasprevious = true;
			}
			if (retriever.Consumables is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Consumables);

				stringbuilder.Append('{');
				ITransporterConsumableGraphType.AsQueryString(stringbuilder, retriever.Consumables);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.CostInCredits)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.CostInCredits);

				hasprevious = true;
			}
			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

				hasprevious = true;
			}
			if (retriever.Length)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Length);

				hasprevious = true;
			}
			if (retriever.ManufacturerIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.ManufacturerIds);

				hasprevious = true;
			}
			if (retriever.Manufacturers is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Manufacturers);

				stringbuilder.Append('{');
				IManufacturerGraphType.AsQueryString(stringbuilder, retriever.Manufacturers, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.MaxAtmospheringSpeed)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MaxAtmospheringSpeed);

				hasprevious = true;
			}
			if (retriever.MaxCrew)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MaxCrew);

				hasprevious = true;
			}
			if (retriever.MinCrew)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.MinCrew);

				hasprevious = true;
			}
			if (retriever.Model)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Model);

				hasprevious = true;
			}
			if (retriever.Name)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Name);

				hasprevious = true;
			}
			if (retriever.Passengers)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Passengers);

				hasprevious = true;
			}
			if (retriever.PilotIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.PilotIds);

				hasprevious = true;
			}
			if (retriever.Pilots is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Pilots);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.Pilots, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
	}
	public class ITransporterConsumableGraphType : ObjectGraphType<ITransporter.IConsumable>
	{
		public static void AsQueryString(StringBuilder stringbuilder, ITransporter.IConsumable<bool> retriever)
		{
			bool hasprevious = false;

			if (retriever.TimeUnit)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.TimeUnit);

				hasprevious = true;
			}
			if (retriever.Value)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Value);

				hasprevious = true;
			}
		}

		public class FieldNames
		{
			public const string TimeUnit = nameof(ITransporter.IConsumable.TimeUnit);
			public const string Value = nameof(ITransporter.IConsumable.Value);
		}

		public ITransporterConsumableGraphType()
		{
			Field<StringGraphType>(FieldNames.TimeUnit).Resolve(resolvefieldcontext => resolvefieldcontext.Source.TimeUnit);
			Field<IntGraphType>(FieldNames.Value).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Value);
		}
	}
}
