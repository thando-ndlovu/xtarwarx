using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class CharactersQuery
	{
		public class Result : StarWarsModelQuery.Result<ICharacterGraphType, ICharacter>
		{
			public Result() : base()
			{
				Name = "CharactersQueryResult";
			}
		}
	}
}
