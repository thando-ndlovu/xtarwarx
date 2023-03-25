using Domain.Models;

using Newtonsoft.Json.Linq;

using System;

namespace Api.Queries.Retrievers
{
	public interface IStarWarsModelRetriever<T> : IStarWarsModel<T> { }
	public interface IStarWarsModelRetrieverTyped<T> : IStarWarsModelTyped<T> { }
	public interface IStarWarsModelRetriever : IStarWarsModelRetrieverTyped<bool>
	{
		IPagination? Pagination { get; set; }

		public interface IRetrieved<T> : IStarWarsModel<T> { }
		public interface IRetrieved : IStarWarsModel
		{
			public new class Default : IStarWarsModel.Default, IStarWarsModel
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) { }
				public Default(IStarWarsModel starWarsModel) : base(starWarsModel.Id)
				{
					Created = starWarsModel.Created;
					Edited = starWarsModel.Edited;
					Uris = starWarsModel.Uris;
				}
			}
			public new class Default<T> : IStarWarsModel.Default<T>, IStarWarsModel<T>
			{
				public Default(T defaultvalue) : base(defaultvalue) { }
			}
		}

		public class Default : IStarWarsModel.Default, IStarWarsModel
		{
			public Default(int id) : base(id) { }

			public IPagination? Pagination { get; set; }
		}
		public class Default<T> : IStarWarsModel.Default<T>, IStarWarsModel<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) { }
		}
		public class DefaultTyped<T> : IStarWarsModel.DefaultTyped<T>, IStarWarsModelRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}
}
