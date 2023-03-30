using Api.Queries;

using GraphQL.Resolvers;
using GraphQL.Types;

namespace Api.GraphQL.Queries
{
	public partial class StarWarsModelQuery : BaseQuery
	{
		public class Result<TGraphType, IModelType> : BaseQuery.Result<IQuery.IResult<IModelType>> where TGraphType : IGraphType 
		{
			public new class FieldNames : BaseQuery.Result<TGraphType>.FieldNames
			{
				public const string Items = nameof(IQuery.IResult<TGraphType>.Items);
				public const string Page = nameof(IQuery.IResult<TGraphType>.Page);
				public const string Pages = nameof(IQuery.IResult<TGraphType>.Pages);
			}

			public Result() : base()
			{
				Field<IntGraphType>(FieldNames.Page)
					.Resolve(new FuncFieldResolver<IQuery.IResult<IModelType>, int?>(resolvefieldcontext => resolvefieldcontext.Source.Page));
				Field<IntGraphType>(FieldNames.Pages)
					.Resolve(new FuncFieldResolver<IQuery.IResult<IModelType>, int?>(resolvefieldcontext => resolvefieldcontext.Source.Pages));
				Field<ListGraphType<TGraphType>>(FieldNames.Items)
					.Resolve(new FuncFieldResolver<IQuery.IResult<IModelType>, object?>(resolvefieldcontext => resolvefieldcontext.Source.Items));
			}
		}
	}
}
