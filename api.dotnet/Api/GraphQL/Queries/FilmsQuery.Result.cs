using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class FilmsQuery
	{
		public class Result : StarWarsModelQuery.Result<IFilmGraphType, IFilm>
		{
			public Result() : base()
			{
				Name = "FilmsQueryResult";
			}
		}
	}
}
