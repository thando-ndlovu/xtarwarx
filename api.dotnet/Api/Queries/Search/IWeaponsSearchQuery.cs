using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IWeaponsSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T Description { get; set; }
		T ManufacturersDescription { get; set; }
		T ManufacturersName { get; set; }
		T Model { get; set; }
		T Name { get; set; }
		T WeaponClass { get; set; }
		T WeaponClassFlags { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(Description)
				.Append(ManufacturersDescription)
				.Append(ManufacturersName)
				.Append(Model)
				.Append(Name)
				.Append(WeaponClass)
				.Append(WeaponClassFlags)
				.Append(SearchString);
		}
	}
	public interface IWeaponsSearchQuery : IStarWarsModelSearchQuery
	{
		bool? Description { get; set; }
		bool? ManufacturersDescription { get; set; }
		bool? ManufacturersName { get; set; }
		bool? Model { get; set; }
		bool? Name { get; set; }
		bool? WeaponClass { get; set; }
		bool? WeaponClassFlags { get; set; }

		public bool ShouldSearchManufacturers()
		{
			return
				(ManufacturersDescription ?? false) ||
				(ManufacturersName ?? false);
		}

		public IWeapon.ISearch AsWeaponSearch(string? searchstring = null)
		{
			return new IWeapon.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new IWeapon.ISearchContainables.Default
				{
					Description = Description ?? false,
					Model = Model ?? false,
					Name = Name ?? false,
					WeaponClass = WeaponClass ?? false,
					WeaponClassFlags = WeaponClassFlags ?? false,
				},

				Manufacturers = new IManufacturer.ISearchContainables.Default
				{
					Description = ManufacturersDescription ?? false,
					Name = ManufacturersName ?? false,
				},
			};
		}
		public IEnumerable<string> AsQueryData(IWeaponsSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (ManufacturersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ManufacturersDescription ?? nameof(ManufacturersDescription).ToLower(), ManufacturersDescription.Value));

			if (ManufacturersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ManufacturersName ?? nameof(ManufacturersName).ToLower(), ManufacturersName.Value));

			if (Model.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Model ?? nameof(Model).ToLower(), Model.Value));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (WeaponClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponClass ?? nameof(WeaponClass).ToLower(), WeaponClass.Value));

			if (WeaponClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponClassFlags ?? nameof(WeaponClassFlags).ToLower(), WeaponClassFlags.Value));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, IWeaponsSearchQuery
		{
			public Default() : base() { }
			public Default(IWeapon.ISearch weaponsearch) : base(weaponsearch)
			{
				Description = weaponsearch.SearchContainables?.Description;
				Model = weaponsearch.SearchContainables?.Model;
				Name = weaponsearch.SearchContainables?.Name;
				WeaponClass = weaponsearch.SearchContainables?.WeaponClass;
				WeaponClassFlags = weaponsearch.SearchContainables?.WeaponClassFlags;

				ManufacturersDescription = weaponsearch.Manufacturers?.Description;
				ManufacturersName = weaponsearch.Manufacturers?.Name;
			}

			public bool? Description { get; set; }
			public bool? ManufacturersDescription { get; set; }
			public bool? ManufacturersName { get; set; }
			public bool? Model { get; set; }
			public bool? Name { get; set; }
			public bool? WeaponClass { get; set; }
			public bool? WeaponClassFlags { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, IWeaponsSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Description = defaultvalue;
				ManufacturersDescription = defaultvalue;
				ManufacturersName = defaultvalue;
				Model = defaultvalue;
				Name = defaultvalue;
				WeaponClass = defaultvalue;
				WeaponClassFlags = defaultvalue;
			}

			public T Description { get; set; }
			public T ManufacturersDescription { get; set; }
			public T ManufacturersName { get; set; }
			public T Model { get; set; }
			public T Name { get; set; }
			public T WeaponClass { get; set; }
			public T WeaponClassFlags { get; set; }
		}
	}
}
