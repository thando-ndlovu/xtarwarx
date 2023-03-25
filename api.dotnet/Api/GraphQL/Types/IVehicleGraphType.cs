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
	public class IVehicleGraphType : ITransporterGraphType<IVehicle>
	{
		public static void AsQueryString(StringBuilder stringbuilder, IVehicleRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			ITransporterGraphType<IVehicle>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;
			if (retriever.VehicleClass is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.VehicleClass);

				stringbuilder.Append('{');
				IVehicleClassGraphType.AsQueryString(stringbuilder, retriever.VehicleClass);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}

		public new class FieldNames : ITransporterGraphType<IVehicle>.FieldNames
		{
			public const string VehicleClass = nameof(IVehicle.VehicleClass);
		}

		public class IVehicleClassGraphType : ObjectGraphType<IVehicle.IVehicleClass>
		{
			public static void AsQueryString(StringBuilder stringbuilder, IVehicle.IVehicleClass<bool> retriever)
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
				public const string Class = nameof(IVehicle.IVehicleClass.Class);
				public const string Flags = nameof(IVehicle.IVehicleClass.Flags);
			}

			public IVehicleClassGraphType()
			{
				Field<StringGraphType>(FieldNames.Class).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Class);
				Field<ListGraphType<StringGraphType>>(FieldNames.Flags).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Flags);
			}
		}

		public IVehicleGraphType(IServiceProvider serviceprovider) : base(serviceprovider)
		{
			Field<IVehicleClassGraphType>(FieldNames.VehicleClass).Resolve(resolvefieldcontext => resolvefieldcontext.Source.VehicleClass);
		}
	}
}
