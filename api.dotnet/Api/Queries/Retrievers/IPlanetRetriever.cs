using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface IPlanetRetriever<T> : IStarWarsModelRetriever<T>, IPlanet<T> 
	{
		T Residents { get; set; }
	}								
	public interface IPlanetRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, IPlanetTyped<T> 
	{
		ICharacterRetrieverTyped<T>? Residents { get; set; }
	}
	public interface IPlanetRetriever : IStarWarsModelRetriever, IPlanetRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, IPlanet<T>
		{
			public T Residents { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, IPlanet
		{
			IEnumerable<ICharacterRetriever.IRetrieved>? Residents { get; set; }

			public new class Default : IPlanet.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					Residents = jobject.GetValue(nameof(Residents), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();
				}
				public Default(IPlanet planet) : base(planet.Id) 
				{
					Climates = planet.Climates;
					Description = planet.Description;
					Diameter = planet.Diameter;
					Gravity = planet.Gravity;
					Name = planet.Name;
					OrbitalPeriod = planet.OrbitalPeriod;
					Population = planet.Population;
					ResidentIds = planet.ResidentIds;
					RotationalPeriod = planet.RotationalPeriod;
					SurfaceWater = planet.SurfaceWater;
					Terrains = planet.Terrains;
				}

				public IEnumerable<ICharacterRetriever.IRetrieved>? Residents { get; set; }
			}
			public new class Default<T> : IPlanet.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Residents = defaultvalue;
				}

				public T Residents { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IPlanetRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IPlanet.Default<T>, IPlanetRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				Residents = defaultvalue;
			}

			public T Residents { get; set; }
		}  
		public new class DefaultTyped<T> : IPlanet.DefaultTyped<T>, IPlanetRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public ICharacterRetrieverTyped<T>? Residents { get; set; }
		}
	}
}
