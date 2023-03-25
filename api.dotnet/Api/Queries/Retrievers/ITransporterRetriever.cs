using Domain.Models;

using System.Collections.Generic;

namespace Api.Queries.Retrievers
{
	public interface ITransporterRetriever<T> : IStarWarsModelRetriever<T>, ITransporter<T> 
	{
		T Manufacturers { get; set; }
		T Pilots { get; set; }
	}
	public interface ITransporterRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, ITransporterTyped<T> 
	{
		IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
		ICharacterRetrieverTyped<T>? Pilots { get; set; }
	}
	public interface ITransporterRetriever : IStarWarsModelRetriever, ITransporterRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, ITransporter<T> 
		{
			T Manufacturers { get; set; }
			T Pilots { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, ITransporter
		{
			IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }
			IEnumerable<ICharacterRetriever.IRetrieved>? Pilots { get; set; }
		}
	}
}
