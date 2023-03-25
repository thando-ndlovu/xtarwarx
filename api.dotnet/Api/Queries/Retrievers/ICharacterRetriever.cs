using Domain.Models;

using Newtonsoft.Json.Linq;

using System;

namespace Api.Queries.Retrievers
{
	public interface ICharacterRetriever<T> : IStarWarsModelRetriever<T>, ICharacter<T> 
	{
		T Homeworld { get; set; }
	}					 
	public interface ICharacterRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, ICharacterTyped<T> 
	{
		IPlanetRetrieverTyped<T>? Homeworld { get; set; }
	}
	public interface ICharacterRetriever : IStarWarsModelRetriever, ICharacterRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, ICharacter<T> 
		{
			T Homeworld { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, ICharacter
		{
			IPlanetRetriever.IRetrieved? Homeworld { get; set; }

			public new class Default : ICharacter.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					if (jobject.GetValue(nameof(Homeworld), StringComparison.OrdinalIgnoreCase) is JToken homeworld && homeworld.Value<int?>(nameof(Id)) is int homeworldid)
						Homeworld = new IPlanetRetriever.IRetrieved.Default(homeworldid, JObject.FromObject(homeworld));
				}
				public Default(ICharacter character) : base(character.Id)
				{
					BirthYear = character.BirthYear;
					Description = character.Description;
					EyeColors = character.EyeColors;
					HairColors = character.HairColors;
					Height = character.Height;
					HomeworldId = character.HomeworldId;
					Mass = character.Mass;
					Name = character.Name;
					Sex = character.Sex;
					SkinColors = character.SkinColors;
				}

				public IPlanetRetriever.IRetrieved? Homeworld { get; set; }
			}
			public new class Default<T> : ICharacter.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Homeworld = defaultvalue;
				}

				public T Homeworld { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, ICharacterRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : ICharacter.Default<T>, ICharacterRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Homeworld = defaultvalue;
			}

			public T Homeworld { get; set; }
		}	
		public new class DefaultTyped<T> : ICharacter.DefaultTyped<T>, ICharacterRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public IPlanetRetrieverTyped<T>? Homeworld { get; set; }
		}
	}
}
