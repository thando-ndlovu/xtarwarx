using System;
using System.Threading.Tasks;

namespace GraphQL.Resolvers
{
	public class FieldResolver : IFieldResolver
	{
		public Func<IResolveFieldContext, ValueTask<object?>>? ResolveAsyncFunc { get; set; }

		public ValueTask<object?> ResolveAsync(IResolveFieldContext resolvefieldcontext)
		{
			return
				ResolveAsyncFunc?.Invoke(resolvefieldcontext) ??
				ValueTask.FromResult<object?>(resolvefieldcontext.Schema); 
		}
	}
	public class FieldResolver<TSource> : IFieldResolver
	{
		public Func<IResolveFieldContext<TSource>, ValueTask<object?>>? ResolveAsyncFunc { get; set; }

		public ValueTask<object?> ResolveAsync(IResolveFieldContext resolvefieldcontext)
		{
			IResolveFieldContext<TSource> context =
				resolvefieldcontext as IResolveFieldContext<TSource> ??
				throw new ArgumentException();

			return
				ResolveAsyncFunc?.Invoke(context) ??
				ValueTask.FromResult<object?>(resolvefieldcontext.Schema); 
		}
	}
}
