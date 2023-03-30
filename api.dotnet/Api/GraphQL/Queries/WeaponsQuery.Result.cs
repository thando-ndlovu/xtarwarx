using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class WeaponsQuery
	{
		public class Result : StarWarsModelQuery.Result<IWeaponGraphType, IWeapon>
		{
			public Result() : base()
			{
				Name = "WeaponsQueryResult";
			}
		}
	}
}
