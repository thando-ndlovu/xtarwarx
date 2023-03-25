namespace Api.Queries.Retrievers
{
	public interface IQueryMetaResultRetriever<T> : IQueryMetaResult<T> { }
	public interface IQueryMetaResultRetrieverTyped<T> : IQueryMetaResultRetriever<T> { }
	public interface IQueryMetaResultRetriever : IQueryMetaResultRetrieverTyped<bool>
	{
		public interface IRetrieved<T> : IQueryMetaResult<T> { }
		public interface IRetrieved : IQueryMetaResult
		{
			public new class Default : IQueryMetaResult.Default, IRetrieved { }
			public new class Default<T> : IQueryMetaResult.Default<T>, IRetrieved<T> 
			{
				public Default(T defaultvalue) : base(defaultvalue) { }
			}
		}

		public class Default : DefaultTyped<bool>, IQueryMetaResultRetriever
		{
			public Default() : base(false) { }
			public Default(bool defaultvalue) : base(defaultvalue) { }
		}
		public class Default<T> : IQueryMetaResult.Default<T>, IQueryMetaResultRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) { }
		} 
		public class DefaultTyped<T> : IQueryMetaResult.DefaultTyped<T>, IQueryMetaResultRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}
}
