namespace Api.Queries.Retrievers
{
	public interface IQuerySearchResultRetriever<T> : IQuerySearchResult<T> { }
	public interface IQuerySearchResultRetrieverTyped<T> : IQuerySearchResultRetriever<T> { }
	public interface IQuerySearchResultRetriever : IQuerySearchResultRetrieverTyped<bool>
	{
		public interface IRetrieved<T> : IQuerySearchResult<T> { }
		public interface IRetrieved : IQuerySearchResult
		{
			public new class Default : IQuerySearchResult.Default, IRetrieved { }
			public new class Default<T> : IQuerySearchResult.Default<T>, IRetrieved<T> 
			{
				public Default(T defaultvalue) : base(defaultvalue) { }
			}
		}

		public class Default : DefaultTyped<bool>, IQuerySearchResultRetriever
		{
			public Default() : base(false) { }
			public Default(bool defaultvalue) : base(defaultvalue) { }
		}
		public class Default<T> : IQuerySearchResult.Default<T>, IQuerySearchResultRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) { }
		} 
		public class DefaultTyped<T> : IQuerySearchResult.DefaultTyped<T>, IQuerySearchResultRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}
}
