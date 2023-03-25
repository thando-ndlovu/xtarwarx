using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface IStarshipRetriever<T> : ITransporterRetriever<T>, IStarship<T> { }
	public interface IStarshipRetrieverTyped<T> : ITransporterRetrieverTyped<T>, IStarshipTyped<T> { }
	public interface IStarshipRetriever : IStarWarsModelRetriever, IStarshipRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : ITransporterRetriever.IRetrieved<T>, IStarship<T> { }
		public new interface IRetrieved : ITransporterRetriever.IRetrieved, IStarship
		{
			public new class Default : IStarship.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					Manufacturers = jobject.GetValue(nameof(Manufacturers), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IManufacturerRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IManufacturerRetriever.IRetrieved>();
					Pilots = jobject.GetValue(nameof(Pilots), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();
				}
				public Default(IStarship starship) : base(starship.Id)
				{
					CargoCapacity = starship.CargoCapacity;
					Consumables = starship.Consumables;
					CostInCredits = starship.CostInCredits;
					Description = starship.Description;
					Length = starship.Length;
					ManufacturerIds = starship.ManufacturerIds;
					MaxAtmospheringSpeed = starship.MaxAtmospheringSpeed;
					MaxCrew = starship.MaxCrew;
					MinCrew = starship.MinCrew;
					Model = starship.Model;
					Name = starship.Name;
					Passengers = starship.Passengers;
					PilotIds = starship.PilotIds;

					HyperdriveRating = starship.HyperdriveRating;
					MGLT = starship.MGLT;
					StarshipClass = starship.StarshipClass;
				}

				public IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }
				public IEnumerable<ICharacterRetriever.IRetrieved>? Pilots { get; set; }
			}
			public new class Default<T> : IStarship.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Manufacturers = defaultvalue;
					Pilots = defaultvalue;
				}

				public T Manufacturers { get; set; }
				public T Pilots { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IStarshipRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IStarship.Default<T>, IStarshipRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				Manufacturers = defaultvalue;
				Pilots = defaultvalue;
			}

			public T Manufacturers { get; set; }
			public T Pilots { get; set; }
		}	
		public new class DefaultTyped<T> : IStarship.DefaultTyped<T>, IStarshipRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
			public ICharacterRetrieverTyped<T>? Pilots { get; set; }
		}
	}
}
