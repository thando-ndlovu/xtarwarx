using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface IFactionRetriever<T> : IStarWarsModelRetriever<T>, IFaction<T> 
	{
		T AlliedCharacters { get; set; }
		T AlliedFactions { get; set; }
		T Leaders { get; set; }
		T MemberCharacters { get; set; }
		T MemberFactions { get; set; }
	}		   
	public interface IFactionRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, IFactionTyped<T> 
	{
		ICharacterRetrieverTyped<T>? AlliedCharacters { get; set; }
		IFactionRetrieverTyped<T>? AlliedFactions { get; set; }
		ICharacterRetrieverTyped<T>? Leaders { get; set; }
		ICharacterRetrieverTyped<T>? MemberCharacters { get; set; }
		IFactionRetrieverTyped<T>? MemberFactions { get; set; }
	}
	public interface IFactionRetriever : IStarWarsModelRetriever, IFactionRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, IFaction<T> 
		{
			T AlliedCharacters { get; set; }
			T AlliedFactions { get; set; }
			T Leaders { get; set; }
			T MemberCharacters { get; set; }
			T MemberFactions { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, IFaction
		{
			IEnumerable<ICharacterRetriever.IRetrieved>? AlliedCharacters { get; set; }
			IEnumerable<IFactionRetriever.IRetrieved>? AlliedFactions { get; set; }
			IEnumerable<ICharacterRetriever.IRetrieved>? Leaders { get; set; }
			IEnumerable<ICharacterRetriever.IRetrieved>? MemberCharacters { get; set; }
			IEnumerable<IFactionRetriever.IRetrieved>? MemberFactions { get; set; }

			public new class Default : IFaction.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					AlliedCharacters = jobject.GetValue(nameof(AlliedCharacters), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();
					AlliedFactions = jobject.GetValue(nameof(AlliedFactions), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IFactionRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IFactionRetriever.IRetrieved>();
					Leaders = jobject.GetValue(nameof(Leaders), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();
					MemberCharacters = jobject.GetValue(nameof(MemberCharacters), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();
					MemberFactions = jobject.GetValue(nameof(MemberFactions), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IFactionRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IFactionRetriever.IRetrieved>();
				}
				public Default(IFaction faction) : base(faction.Id)
				{
					AlliedCharacterIds = faction.AlliedCharacterIds;
					AlliedFactionIds = faction.AlliedFactionIds;
					Description = faction.Description;
					LeaderIds = faction.LeaderIds;
					MemberCharacterIds = faction.MemberCharacterIds;
					MemberFactionIds = faction.MemberFactionIds;
					Name = faction.Name;
					OrganizationTypes = faction.OrganizationTypes;
				}

				public IEnumerable<ICharacterRetriever.IRetrieved>? AlliedCharacters { get; set; }
				public IEnumerable<IFactionRetriever.IRetrieved>? AlliedFactions { get; set; }
				public IEnumerable<ICharacterRetriever.IRetrieved>? Leaders { get; set; }
				public IEnumerable<ICharacterRetriever.IRetrieved>? MemberCharacters { get; set; }
				public IEnumerable<IFactionRetriever.IRetrieved>? MemberFactions { get; set; }
			}
			public new class Default<T> : IFaction.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					AlliedCharacters = defaultvalue;
					AlliedFactions = defaultvalue;
					Leaders = defaultvalue;
					MemberCharacters = defaultvalue;
					MemberFactions = defaultvalue;
				}

				public T AlliedCharacters { get; set; }
				public T AlliedFactions { get; set; }
				public T Leaders { get; set; }
				public T MemberCharacters { get; set; }
				public T MemberFactions { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IFactionRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IFaction.Default<T>, IFactionRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				AlliedCharacters = defaultvalue;
				AlliedFactions = defaultvalue;
				Leaders = defaultvalue;
				MemberCharacters = defaultvalue;
				MemberFactions = defaultvalue;
			}

			public T AlliedCharacters { get; set; }
			public T AlliedFactions { get; set; }
			public T Leaders { get; set; }
			public T MemberCharacters { get; set; }
			public T MemberFactions { get; set; }
		}	
		public new class DefaultTyped<T> : IFaction.DefaultTyped<T>, IFactionRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public ICharacterRetrieverTyped<T>? AlliedCharacters { get; set; }
			public IFactionRetrieverTyped<T>? AlliedFactions { get; set; }
			public ICharacterRetrieverTyped<T>? Leaders { get; set; }
			public ICharacterRetrieverTyped<T>? MemberCharacters { get; set; }
			public IFactionRetrieverTyped<T>? MemberFactions { get; set; }
		}
	}
}
