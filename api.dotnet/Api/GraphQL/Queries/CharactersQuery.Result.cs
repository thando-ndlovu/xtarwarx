using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class CharactersQuery
	{
		public class Result : StarWarsModelQuery.Result<ICharacterGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider) 
			{
				Name = "CharactersQueryResult";
			}
		}
	}
}
