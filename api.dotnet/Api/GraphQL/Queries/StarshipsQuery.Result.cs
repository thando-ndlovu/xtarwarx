using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class StarshipsQuery
	{
		public class Result : StarWarsModelQuery.Result<IStarshipGraphType, IStarship>
		{
			public Result() : base()
			{
				Name = "StarshipsQueryResult";
			}
		}
	}
}
