using GraphQL;
using GraphQL.Types;
using GraphQL.Resolvers;

using System;
using System.Threading.Tasks;

namespace Api.GraphQL.Queries
{
	public partial class IntrospectionQuery : BaseQuery<ObjectGraphType> 
	{
		public new class Arguments : BaseQuery<ObjectGraphType>.Arguments 
		{
			public static QueryArguments QueryArguments()
			{
				return new QueryArguments { };
			}
		}

		public IntrospectionQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider)
		{
			return resolvefieldcontext => resolvefieldcontext.Schema;
		}
	}
}
