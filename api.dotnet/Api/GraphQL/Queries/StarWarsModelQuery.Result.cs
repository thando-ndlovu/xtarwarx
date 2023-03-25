using Api.Queries;

using GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class StarWarsModelQuery : BaseQuery
	{
		public new class Result<TGraphType> : BaseQuery.Result<IQuery.IResult<object>> where TGraphType : IGraphType
		{
			public new class FieldNames : BaseQuery.Result<TGraphType>.FieldNames
			{
				public const string Items = nameof(IQuery.IResult<TGraphType>.Items);
				public const string Page = nameof(IQuery.IResult<TGraphType>.Page);
				public const string Pages = nameof(IQuery.IResult<TGraphType>.Pages);
			}

			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				//Field<ListGraphType<TGraphType>>(FieldNames.Items).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Items);
				//Field<IntGraphType>(FieldNames.Page).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Page);
				//Field<IntGraphType>(FieldNames.Pages).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Pages);
			}
		}
	}
}
