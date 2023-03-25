using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface IWeaponRetriever<T> : IStarWarsModelRetriever<T>, IWeapon<T> 
	{
		T Manufacturers { get; set; }
	}		 
	public interface IWeaponRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, IWeaponTyped<T> 
	{
		IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
	}
	public interface IWeaponRetriever : IStarWarsModelRetriever, IWeaponRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, IWeapon<T> 
		{
			T Manufacturers { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, IWeapon
		{
			IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }

			public new class Default : IWeapon.Default, IRetrieved
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
				}
				public Default(IWeapon weapon) : base(weapon.Id) 
				{
					Description = weapon.Description;
					ManufacturerIds = weapon.ManufacturerIds;
					Model = weapon.Model;
					Name = weapon.Name;
					WeaponClass = weapon.WeaponClass;
				}

				public IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }
			}	
			public new class Default<T> : IWeapon.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Manufacturers = defaultvalue;
				}

				public T Manufacturers { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IWeaponRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IWeapon.Default<T>, IWeaponRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Manufacturers = defaultvalue;
			}

			public T Manufacturers { get; set; }
		} 
		public new class DefaultTyped<T> : IWeapon.DefaultTyped<T>, IWeaponRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
		}
	}
}
