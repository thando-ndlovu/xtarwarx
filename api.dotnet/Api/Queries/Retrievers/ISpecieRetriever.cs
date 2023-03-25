using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface ISpecieRetriever<T> : IStarWarsModelRetriever<T>, ISpecie<T>
	{
		T Characters { get; set; }
		T Homeworld { get; set; }
	}				 
	public interface ISpecieRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, ISpecieTyped<T>
	{
		ICharacterRetrieverTyped<T>? Characters { get; set; }
		IPlanetRetrieverTyped<T>? Homeworld { get; set; }
	}
	public interface ISpecieRetriever : IStarWarsModelRetriever, ISpecieRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, ISpecie<T> 
		{
			T Characters { get; set; }
			T Homeworld { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, ISpecie
		{
			IEnumerable<ICharacterRetriever.IRetrieved>? Characters { get; set; }
			IPlanetRetriever.IRetrieved? Homeworld { get; set; }

			public new class Default : ISpecie.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					Characters = jobject.GetValue(nameof(Characters), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();

					if (jobject.GetValue(nameof(Homeworld), StringComparison.OrdinalIgnoreCase) is JToken homeworld && homeworld.Value<int?>(nameof(Id)) is int homeworldid)
						Homeworld = new IPlanetRetriever.IRetrieved.Default(homeworldid, JObject.FromObject(homeworld));
				}
				public Default(ISpecie specie) : base(specie.Id) 
				{
					AverageHeight = specie.AverageHeight;
					AverageLifespan = specie.AverageLifespan;
					CharacterIds = specie.CharacterIds;
					Classification = specie.Classification;
					Description = specie.Description;
					Designation = specie.Designation;
					EyeColors = specie.EyeColors;
					HairColors = specie.HairColors;
					HomeworldId = specie.HomeworldId;
					Language = specie.Language;
					Name = specie.Name;
					SkinColors = specie.SkinColors;
				}

				public IEnumerable<ICharacterRetriever.IRetrieved>? Characters { get; set; }
				public IPlanetRetriever.IRetrieved? Homeworld { get; set; }
			}
			public new class Default<T> : ISpecie.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Characters = defaultvalue;
					Homeworld = defaultvalue;
				}

				public T Characters { get; set; }
				public T Homeworld { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, ISpecieRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : ISpecie.Default<T>, ISpecieRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Homeworld = defaultvalue;
				Characters = defaultvalue;
			}

			public T Characters { get; set; }
			public T Homeworld { get; set; }
		}	   
		public new class DefaultTyped<T> : ISpecie.DefaultTyped<T>, ISpecieRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public ICharacterRetrieverTyped<T>? Characters { get; set; }
			public IPlanetRetrieverTyped<T>? Homeworld { get; set; }
		}
	}
}
