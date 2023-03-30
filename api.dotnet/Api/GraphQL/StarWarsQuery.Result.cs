using Api.Queries;

using GraphQL.Types;
using GraphQL.Resolvers;

namespace Api.GraphQL
{
	public partial class StarWarsQuery 
	{
		public class Result<TGraphType> : ObjectGraphType<IQuery.IResult<TGraphType>> where TGraphType : IGraphType
		{
			public class FieldNames
			{
				public const string Items = nameof(IQuery.IResult<TGraphType>.Items);
				public const string Page = nameof(IQuery.IResult<TGraphType>.Page);
				public const string Pages = nameof(IQuery.IResult<TGraphType>.Pages);
			}

			public Result()
			{
				Field<IntGraphType>(FieldNames.Page)
					.Resolve(new FuncFieldResolver<IQuery.IResult<TGraphType>, int?>(resolvefieldcontext => resolvefieldcontext.Source.Page));
				Field<IntGraphType>(FieldNames.Pages)
					.Resolve(new FuncFieldResolver<IQuery.IResult<TGraphType>, int?>(resolvefieldcontext => resolvefieldcontext.Source.Pages));
				Field<ListGraphType<TGraphType>>(FieldNames.Items)
					.Resolve(new FuncFieldResolver<IQuery.IResult<TGraphType>, object?>(resolvefieldcontext => resolvefieldcontext.Source.Items));
			}
		}
	}
}
