using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class WeaponsQuery
	{
		public class Result : StarWarsModelQuery.Result<IWeaponGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "WeaponsQueryResult";
			}
		}
	}
}
