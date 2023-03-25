using Api.Queries;

using GraphQL.Types;
using GraphQL.Resolvers;

namespace Api.GraphQL
{
	public partial class StarWarsQuery 
	{
		public class Result<T> : ObjectGraphType<IQuery.IResult<T>> where T : IGraphType
		{
			public class FieldNames
			{
				public const string Items = nameof(IQuery.IResult<T>.Items);
				public const string Page = nameof(IQuery.IResult<T>.Page);
				public const string Pages = nameof(IQuery.IResult<T>.Pages);
			}

			public Result()
			{
				AddField(new FieldType
				{
					Name = FieldNames.Items,
					Type = typeof(ListGraphType<T>),
					Resolver = new FuncFieldResolver<object?>(resolvefieldcontext => (resolvefieldcontext.Source as IQuery.IResult<T>)?.Items),
				});

				AddField(new FieldType
				{
					Name = FieldNames.Page,
					Type = typeof(IntGraphType),
					Resolver = new FuncFieldResolver<object?>(resolvefieldcontext => (resolvefieldcontext.Source as IQuery.IResult<T>)?.Page),
				});

				AddField(new FieldType
				{
					Name = FieldNames.Pages,
					Type = typeof(IntGraphType),
					Resolver = new FuncFieldResolver<object?>(resolvefieldcontext => (resolvefieldcontext.Source as IQuery.IResult<T>)?.Pages),
				});
			}
		}
	}
}
