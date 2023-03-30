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
	public class IWeaponGraphType : IStarWarsModelGraphType<IWeapon>
	{
		public static void AsQueryString(StringBuilder stringbuilder, IWeaponRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<IWeapon>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

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

			containsprevious = hasprevious;
		}

		public new class FieldNames : IStarWarsModelGraphType<IWeapon>.FieldNames
		{
			public const string Description = nameof(IWeapon.Description);
			public const string ManufacturerIds = nameof(IWeapon.ManufacturerIds);
			public const string Model = nameof(IWeapon.Model);
			public const string Name = nameof(IWeapon.Name);
			public const string WeaponClass = nameof(IWeapon.WeaponClass);

			public const string Manufacturers = "Manufacturers";
		}
		public class IWeaponClassGraphType : ObjectGraphType<IWeapon.IWeaponClass>
		{
			public static void AsQueryString(StringBuilder stringbuilder, IWeapon.IWeaponClass<bool> retriever)
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
				public const string Class = nameof(IWeapon.IWeaponClass.Class);
				public const string Flags = nameof(IWeapon.IWeaponClass.Flags);
			}
			public IWeaponClassGraphType()
			{
				Field<StringGraphType>(FieldNames.Class)
					.Resolve(resolvefieldcontext => resolvefieldcontext.Source.Class);
				Field<ListGraphType<StringGraphType>>(FieldNames.Flags)
					.Resolve(resolvefieldcontext => resolvefieldcontext.Source.Flags);
			}
		}

		public IWeaponGraphType() : base()
		{
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<ListGraphType<IntGraphType>>(FieldNames.ManufacturerIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.ManufacturerIds);
			Field<StringGraphType>(FieldNames.Model).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Model);
			Field<StringGraphType>(FieldNames.Name).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Name);
			Field<IWeaponClassGraphType>(FieldNames.WeaponClass).Resolve(resolvefieldcontext => resolvefieldcontext.Source.WeaponClass);

			Field<ManufacturersQuery.Result>(FieldNames.Manufacturers)
				.Arguments(ManufacturersQuery.Arguments.QueryArguments(ManufacturersQuery.Arguments.DefaultQuery))
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = ManufacturersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = ManufacturersQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IWeapon)?.ManufacturerIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
		}
	}
}
