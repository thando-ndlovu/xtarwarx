using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface IManufacturerRetriever<T> : IStarWarsModelRetriever<T>, IManufacturer<T> 
	{
		T HeadquatersPlanet { get; set; }
		T Starships { get; set; }
		T Vehicles { get; set; }
		T Weapons { get; set; }
	}
	public interface IManufacturerRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, IManufacturerTyped<T> 
	{
		IPlanetRetrieverTyped<T>? HeadquatersPlanet { get; set; }
		IStarshipRetrieverTyped<T>? Starships { get; set; }
		IVehicleRetrieverTyped<T>? Vehicles { get; set; }
		IWeaponRetrieverTyped<T>? Weapons { get; set; }
	}
	public interface IManufacturerRetriever : IStarWarsModelRetriever, IManufacturerRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, IManufacturer<T> 
		{
			T HeadquatersPlanet { get; set; }
			T Starships { get; set; }
			T Vehicles { get; set; }
			T Weapons { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, IManufacturer
		{
			IPlanetRetriever.IRetrieved? HeadquatersPlanet { get; set; }
			IEnumerable<IStarshipRetriever.IRetrieved>? Starships { get; set; }
			IEnumerable<IVehicleRetriever.IRetrieved>? Vehicles { get; set; }
			IEnumerable<IWeaponRetriever.IRetrieved>? Weapons { get; set; }

			public new class Default : IManufacturer.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					if (jobject.GetValue(nameof(HeadquatersPlanet), StringComparison.OrdinalIgnoreCase) is JToken headquatersplanet && headquatersplanet.Value<int?>(nameof(Id)) is int headquatersplanetid)
						HeadquatersPlanet = new IPlanetRetriever.IRetrieved.Default(headquatersplanetid, JObject.FromObject(headquatersplanet));

					Starships = jobject.GetValue(nameof(Starships), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IStarshipRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IStarshipRetriever.IRetrieved>();
					Vehicles = jobject.GetValue(nameof(Vehicles), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IVehicleRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IVehicleRetriever.IRetrieved>();
					Weapons = jobject.GetValue(nameof(Weapons), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IWeaponRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IWeaponRetriever.IRetrieved>();
				}
				public Default(IManufacturer manufacturer) : base(manufacturer.Id)
				{
					Description = manufacturer.Description;
					HeadquatersPlanetId = manufacturer.HeadquatersPlanetId;
					Name = manufacturer.Name;
					StarshipIds = manufacturer.StarshipIds;
					VehicleIds = manufacturer.VehicleIds;
					WeaponIds = manufacturer.WeaponIds;
				}

				public IPlanetRetriever.IRetrieved? HeadquatersPlanet { get; set; }
				public IEnumerable<IStarshipRetriever.IRetrieved>? Starships { get; set; }
				public IEnumerable<IVehicleRetriever.IRetrieved>? Vehicles { get; set; }
				public IEnumerable<IWeaponRetriever.IRetrieved>? Weapons { get; set; }
			}
			public new class Default<T> : IManufacturer.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					HeadquatersPlanet = defaultvalue;
					Starships = defaultvalue;
					Vehicles = defaultvalue;
					Weapons = defaultvalue;
				}

				public T HeadquatersPlanet { get; set; }
				public T Starships { get; set; }
				public T Vehicles { get; set; }
				public T Weapons { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IManufacturerRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IManufacturer.Default<T>, IManufacturerRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				HeadquatersPlanet = defaultvalue;
				Starships = defaultvalue;
				Vehicles = defaultvalue;
				Weapons = defaultvalue;
			}

			public T HeadquatersPlanet { get; set; }
			public T Starships { get; set; }
			public T Vehicles { get; set; }
			public T Weapons { get; set; }
		} 
		public new class DefaultTyped<T> : IManufacturer.DefaultTyped<T>, IManufacturerRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public IPlanetRetrieverTyped<T>? HeadquatersPlanet { get; set; }
			public IStarshipRetrieverTyped<T>? Starships { get; set; }
			public IVehicleRetrieverTyped<T>? Vehicles { get; set; }
			public IWeaponRetrieverTyped<T>? Weapons { get; set; }
		}
	}
}
