using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IManufacturersSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T Description { get; set; }
		T HeadquatersPlanetDescription { get; set; }
		T HeadquatersPlanetName { get; set; }
		T Name { get; set; }
		T StarshipsDescription { get; set; }
		T StarshipsModel { get; set; }
		T StarshipsName { get; set; }
		T StarshipsStarshipClass { get; set; }
		T StarshipsStarshipClassFlags { get; set; }
		T VehiclesDescription { get; set; }
		T VehiclesModel { get; set; }
		T VehiclesName { get; set; }
		T VehiclesVehicleClass { get; set; }
		T VehiclesVehicleClassFlags { get; set; }
		T WeaponsDescription { get; set; }
		T WeaponsModel { get; set; }
		T WeaponsName { get; set; }
		T WeaponsWeaponClass { get; set; }
		T WeaponsWeaponClassFlags { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(Description)
				.Append(HeadquatersPlanetDescription)
				.Append(HeadquatersPlanetName)
				.Append(Name)
				.Append(StarshipsDescription)
				.Append(StarshipsModel)
				.Append(StarshipsName)
				.Append(StarshipsStarshipClass)
				.Append(StarshipsStarshipClassFlags)
				.Append(VehiclesDescription)
				.Append(VehiclesModel)
				.Append(VehiclesName)
				.Append(VehiclesVehicleClass)
				.Append(VehiclesVehicleClassFlags)
				.Append(WeaponsDescription)
				.Append(WeaponsModel)
				.Append(WeaponsName)
				.Append(WeaponsWeaponClass)
				.Append(WeaponsWeaponClassFlags);
		}
	}
	public interface IManufacturersSearchQuery : IStarWarsModelSearchQuery
	{
		bool? Description { get; set; }
		bool? HeadquatersPlanetDescription { get; set; }
		bool? HeadquatersPlanetName { get; set; }
		bool? Name { get; set; }
		bool? StarshipsDescription { get; set; }
		bool? StarshipsModel { get; set; }
		bool? StarshipsName { get; set; }
		bool? StarshipsStarshipClass { get; set; }
		bool? StarshipsStarshipClassFlags { get; set; }
		bool? VehiclesDescription { get; set; }
		bool? VehiclesModel { get; set; }
		bool? VehiclesName { get; set; }
		bool? VehiclesVehicleClass { get; set; }
		bool? VehiclesVehicleClassFlags { get; set; }
		bool? WeaponsDescription { get; set; }
		bool? WeaponsModel { get; set; }
		bool? WeaponsName { get; set; }
		bool? WeaponsWeaponClass { get; set; }
		bool? WeaponsWeaponClassFlags { get; set; }

		public bool ShouldSearchHeadquatersPlanet()
		{
			return
				(HeadquatersPlanetDescription ?? false) ||
				(HeadquatersPlanetName ?? false);
		}
		public bool ShouldSearchStarships()
		{
			return
				(StarshipsDescription ?? false) ||
				(StarshipsModel ?? false) ||
				(StarshipsName ?? false) ||
				(StarshipsStarshipClass ?? false) ||
				(StarshipsStarshipClassFlags ?? false);
		}
		public bool ShouldSearchVehicles()
		{
			return
				(VehiclesDescription ?? false) ||
				(VehiclesModel ?? false) ||
				(VehiclesName ?? false) ||
				(VehiclesVehicleClass ?? false) ||
				(VehiclesVehicleClassFlags ?? false);
		}
		public bool ShouldSearchWeapons()
		{
			return
				(WeaponsDescription ?? false) ||
				(WeaponsModel ?? false) ||
				(WeaponsName ?? false) ||
				(WeaponsWeaponClass ?? false) ||
				(WeaponsWeaponClassFlags ?? false);
		}

		public IManufacturer.ISearch AsManufacturerSearch(string? searchstring = null)
		{
			return new IManufacturer.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new IManufacturer.ISearchContainables.Default
				{
					Description = Description ?? false,
					Name = Name ?? false,
				},

				HeadquatersPlanet = new IPlanet.ISearchContainables.Default
				{
					Description = HeadquatersPlanetDescription ?? false,
					Name = HeadquatersPlanetName ?? false,
				},

				Starships = new IStarship.ISearchContainables.Default
				{
					Description = StarshipsDescription ?? false,
					Model = StarshipsModel ?? false,
					Name = StarshipsName ?? false,
					StarshipClass = StarshipsStarshipClass ?? false,
					StarshipClassFlags = StarshipsStarshipClassFlags ?? false,
				},

				Vehicles = new IVehicle.ISearchContainables.Default
				{
					Description = VehiclesDescription ?? false,
					Model = VehiclesModel ?? false,
					Name = VehiclesName ?? false,
					VehicleClass = VehiclesVehicleClass ?? false,
					VehicleClassFlags = VehiclesVehicleClassFlags ?? false,
				},

				Weapons = new IWeapon.ISearchContainables.Default
				{
					Description = WeaponsDescription ?? false,
					Model = WeaponsModel ?? false,
					Name = WeaponsName ?? false,
					WeaponClass = WeaponsWeaponClass ?? false,
					WeaponClassFlags = WeaponsWeaponClassFlags ?? false,
				},

			};
		}
		public IEnumerable<string> AsQueryData(IManufacturersSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (HeadquatersPlanetDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HeadquatersPlanetDescription ?? nameof(HeadquatersPlanetDescription).ToLower(), HeadquatersPlanetDescription.Value));

			if (HeadquatersPlanetName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HeadquatersPlanetName ?? nameof(HeadquatersPlanetName).ToLower(), HeadquatersPlanetName.Value));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (StarshipsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsDescription ?? nameof(StarshipsDescription).ToLower(), StarshipsDescription.Value));

			if (StarshipsModel.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsModel ?? nameof(StarshipsModel).ToLower(), StarshipsModel.Value));

			if (StarshipsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsName ?? nameof(StarshipsName).ToLower(), StarshipsName.Value));

			if (StarshipsStarshipClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsStarshipClass ?? nameof(StarshipsStarshipClass).ToLower(), StarshipsStarshipClass.Value));

			if (StarshipsStarshipClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsStarshipClassFlags ?? nameof(StarshipsStarshipClassFlags).ToLower(), StarshipsStarshipClassFlags.Value));

			if (VehiclesDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesDescription ?? nameof(VehiclesDescription).ToLower(), VehiclesDescription.Value));

			if (VehiclesModel.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesModel ?? nameof(VehiclesModel).ToLower(), VehiclesModel.Value));

			if (VehiclesName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesName ?? nameof(VehiclesName).ToLower(), VehiclesName.Value));

			if (VehiclesVehicleClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesVehicleClass ?? nameof(VehiclesVehicleClass).ToLower(), VehiclesVehicleClass.Value));

			if (VehiclesVehicleClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesVehicleClassFlags ?? nameof(VehiclesVehicleClassFlags).ToLower(), VehiclesVehicleClassFlags.Value));

			if (WeaponsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsDescription ?? nameof(WeaponsDescription).ToLower(), WeaponsDescription.Value));

			if (WeaponsModel.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsModel ?? nameof(WeaponsModel).ToLower(), WeaponsModel.Value));

			if (WeaponsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsName ?? nameof(WeaponsName).ToLower(), WeaponsName.Value));

			if (WeaponsWeaponClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsWeaponClass ?? nameof(WeaponsWeaponClass).ToLower(), WeaponsWeaponClass.Value));

			if (WeaponsWeaponClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsWeaponClassFlags ?? nameof(WeaponsWeaponClassFlags).ToLower(), WeaponsWeaponClassFlags.Value));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, IManufacturersSearchQuery
		{
			public Default() : base() { }
			public Default(IManufacturer.ISearch manufacturersearch) : base(manufacturersearch)
			{
				HeadquatersPlanetDescription = manufacturersearch.HeadquatersPlanet?.Description;
				HeadquatersPlanetName = manufacturersearch.HeadquatersPlanet?.Name;

				StarshipsDescription = manufacturersearch.Starships?.Description;
				StarshipsModel = manufacturersearch.Starships?.Model;
				StarshipsName = manufacturersearch.Starships?.Name;
				StarshipsStarshipClass = manufacturersearch.Starships?.StarshipClass;
				StarshipsStarshipClassFlags = manufacturersearch.Starships?.StarshipClassFlags;

				VehiclesDescription = manufacturersearch.Vehicles?.Description;
				VehiclesModel = manufacturersearch.Vehicles?.Model;
				VehiclesName = manufacturersearch.Vehicles?.Name;
				VehiclesVehicleClass = manufacturersearch.Vehicles?.VehicleClass;
				VehiclesVehicleClassFlags = manufacturersearch.Vehicles?.VehicleClassFlags;

				WeaponsDescription = manufacturersearch.Weapons?.Description;
				WeaponsModel = manufacturersearch.Weapons?.Model;
				WeaponsName = manufacturersearch.Weapons?.Name;
				WeaponsWeaponClass = manufacturersearch.Weapons?.WeaponClass;
				WeaponsWeaponClassFlags = manufacturersearch.Weapons?.WeaponClassFlags;
			}

			public bool? Description { get; set; }
			public bool? HeadquatersPlanetDescription { get; set; }
			public bool? HeadquatersPlanetName { get; set; }
			public bool? Name { get; set; }
			public bool? StarshipsDescription { get; set; }
			public bool? StarshipsModel { get; set; }
			public bool? StarshipsName { get; set; }
			public bool? StarshipsStarshipClass { get; set; }
			public bool? StarshipsStarshipClassFlags { get; set; }
			public bool? VehiclesDescription { get; set; }
			public bool? VehiclesModel { get; set; }
			public bool? VehiclesName { get; set; }
			public bool? VehiclesVehicleClass { get; set; }
			public bool? VehiclesVehicleClassFlags { get; set; }
			public bool? WeaponsDescription { get; set; }
			public bool? WeaponsModel { get; set; }
			public bool? WeaponsName { get; set; }
			public bool? WeaponsWeaponClass { get; set; }
			public bool? WeaponsWeaponClassFlags { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, IManufacturersSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Description = defaultvalue;
				HeadquatersPlanetDescription = defaultvalue;
				HeadquatersPlanetName = defaultvalue;
				Name = defaultvalue;
				StarshipsDescription = defaultvalue;
				StarshipsModel = defaultvalue;
				StarshipsName = defaultvalue;
				StarshipsStarshipClass = defaultvalue;
				StarshipsStarshipClassFlags = defaultvalue;
				VehiclesDescription = defaultvalue;
				VehiclesModel = defaultvalue;
				VehiclesName = defaultvalue;
				VehiclesVehicleClass = defaultvalue;
				VehiclesVehicleClassFlags = defaultvalue;
				WeaponsDescription = defaultvalue;
				WeaponsModel = defaultvalue;
				WeaponsName = defaultvalue;
				WeaponsWeaponClass = defaultvalue;
				WeaponsWeaponClassFlags = defaultvalue;
			}

			public T Description { get; set; }
			public T HeadquatersPlanetDescription { get; set; }
			public T HeadquatersPlanetName { get; set; }
			public T Name { get; set; }
			public T StarshipsDescription { get; set; }
			public T StarshipsModel { get; set; }
			public T StarshipsName { get; set; }
			public T StarshipsStarshipClass { get; set; }
			public T StarshipsStarshipClassFlags { get; set; }
			public T VehiclesDescription { get; set; }
			public T VehiclesModel { get; set; }
			public T VehiclesName { get; set; }
			public T VehiclesVehicleClass { get; set; }
			public T VehiclesVehicleClassFlags { get; set; }
			public T WeaponsDescription { get; set; }
			public T WeaponsModel { get; set; }
			public T WeaponsName { get; set; }
			public T WeaponsWeaponClass { get; set; }
			public T WeaponsWeaponClassFlags { get; set; }
		}
	}
}
