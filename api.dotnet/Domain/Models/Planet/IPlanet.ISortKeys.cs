using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IPlanet 
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T ClimatesCount { get; set; }
			T Diameter { get; set; }
			T Gravity { get; set; }
			T Name { get; set; }
			T OrbitalPeriod { get; set; }
			T Population { get; set; }
			T ResidentsCount { get; set; }
			T RotationalPeriod { get; set; }
			T SurfaceWater { get; set; }
			T TerrainsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.ClimatesCount => ClimatesCount,
					ISortKeys.Keys.Diameter => Diameter,
					ISortKeys.Keys.Gravity => Gravity,
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.OrbitalPeriod => OrbitalPeriod,
					ISortKeys.Keys.Population => Population,
					ISortKeys.Keys.ResidentsCount => ResidentsCount,
					ISortKeys.Keys.RotationalPeriod => RotationalPeriod,
					ISortKeys.Keys.SurfaceWater => SurfaceWater,
					ISortKeys.Keys.TerrainsCount => TerrainsCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(ClimatesCount), ClimatesCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Diameter), Diameter).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Gravity), Gravity).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
						.AppendFormat("{0}: {1}", nameof(OrbitalPeriod), OrbitalPeriod).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Population), Population).AppendLine()
						.AppendFormat("{0}: {1}", nameof(ResidentsCount), ResidentsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(RotationalPeriod), RotationalPeriod).AppendLine()
						.AppendFormat("{0}: {1}", nameof(SurfaceWater), SurfaceWater).AppendLine()
						.AppendFormat("{0}: {1}", nameof(TerrainsCount), TerrainsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string ClimatesCount = "ClimatesCount";
				public const string Diameter = "Diameter";
				public const string Gravity = "Gravity";
				public const string Name = "Name";
				public const string OrbitalPeriod = "OrbitalPeriod";
				public const string Population = "Population";
				public const string ResidentsCount = "ResidentsCount";
				public const string RotationalPeriod = "RotationalPeriod";
				public const string SurfaceWater = "SurfaceWater";
				public const string TerrainsCount = "TerrainsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(ClimatesCount)
						.Append(Diameter)
						.Append(Gravity)
						.Append(Name)
						.Append(OrbitalPeriod)
						.Append(Population)
						.Append(ResidentsCount)
						.Append(RotationalPeriod)
						.Append(SurfaceWater)
						.Append(TerrainsCount);
				}

				public static IOrderedEnumerable<IPlanet> Sort(IEnumerable<IPlanet> planets, params Sorter[] sorters)
				{
					IOrderedEnumerable<IPlanet>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(ClimatesCount, false) => 
								ordered?.ThenBy(planet => planet.Climates?.Count()) ?? 
								planets.OrderBy(planet => planet.Climates?.Count()),
							(ClimatesCount, true) => 
								ordered?.ThenByDescending(planet => planet.Climates?.Count()) ?? 
								planets.OrderByDescending(planet => planet.Climates?.Count()),

							(Diameter, false) => 
								ordered?.ThenBy(planet => planet.Diameter) ?? 
								planets.OrderBy(planet => planet.Diameter),
							(Diameter, true) => 
								ordered?.ThenByDescending(planet => planet.Diameter) ?? 
								planets.OrderByDescending(planet => planet.Diameter),

							(Gravity, false) => 
								ordered?.ThenBy(planet => planet.Gravity) ?? 
								planets.OrderBy(planet => planet.Gravity),
							(Gravity, true) => 
								ordered?.ThenByDescending(planet => planet.Gravity) ?? 
								planets.OrderByDescending(planet => planet.Gravity),

							(Name, false) => 
								ordered?.ThenBy(planet => planet.Name) ?? 
								planets.OrderBy(planet => planet.Name),
							(Name, true) => 
								ordered?.ThenByDescending(planet => planet.Name) ?? 
								planets.OrderByDescending(planet => planet.Name),

							(OrbitalPeriod, false) => 
								ordered?.ThenBy(planet => planet.OrbitalPeriod) ?? 
								planets.OrderBy(planet => planet.OrbitalPeriod),
							(OrbitalPeriod, true) => 
								ordered?.ThenByDescending(planet => planet.OrbitalPeriod) ?? 
								planets.OrderByDescending(planet => planet.OrbitalPeriod),

							(Population, false) => 
								ordered?.ThenBy(planet => planet.Population) ?? 
								planets.OrderBy(planet => planet.Population),
							(Population, true) => 
								ordered?.ThenByDescending(planet => planet.Population) ?? 
								planets.OrderByDescending(planet => planet.Population),

							(ResidentsCount, false) => 
								ordered?.ThenBy(planet => planet.ResidentIds?.Count()) ?? 
								planets.OrderBy(planet => planet.ResidentIds?.Count()),
							(ResidentsCount, true) => 
								ordered?.ThenByDescending(planet => planet.ResidentIds?.Count()) ?? 
								planets.OrderByDescending(planet => planet.ResidentIds?.Count()),

							(RotationalPeriod, false) => 
								ordered?.ThenBy(planet => planet.RotationalPeriod) ?? 
								planets.OrderBy(planet => planet.RotationalPeriod),
							(RotationalPeriod, true) => 
								ordered?.ThenByDescending(planet => planet.RotationalPeriod) ?? 
								planets.OrderByDescending(planet => planet.RotationalPeriod),

							(SurfaceWater, false) => 
								ordered?.ThenBy(planet => planet.SurfaceWater) ?? 
								planets.OrderBy(planet => planet.SurfaceWater),
							(SurfaceWater, true) => 
								ordered?.ThenByDescending(planet => planet.SurfaceWater) ?? 
								planets.OrderByDescending(planet => planet.SurfaceWater),

							(TerrainsCount, false) => 
								ordered?.ThenBy(planet => planet.Terrains?.Count()) ?? 
								planets.OrderBy(planet => planet.Terrains?.Count()),
							(TerrainsCount, true) => 
								ordered?.ThenByDescending(planet => planet.Terrains?.Count()) ?? 
								planets.OrderByDescending(planet => planet.Terrains?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? planets, sorter),
						};

					return ordered ?? planets.OrderBy(planet => planet);
				}
				public static IOrderedQueryable<IPlanet> Sort(IQueryable<IPlanet> planets, params Sorter[] sorters)
				{
					IOrderedQueryable<IPlanet>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(ClimatesCount, false) => 
								ordered?.ThenBy(planet => planet.Climates != null ? planet.Climates.Count() : 0) ??
								planets.OrderBy(planet => planet.Climates != null ? planet.Climates.Count() : 0),
							(ClimatesCount, true) => 
								ordered?.ThenByDescending(planet => planet.Climates != null ? planet.Climates.Count() : 0) ??
								planets.OrderByDescending(planet => planet.Climates != null ? planet.Climates.Count() : 0),

							(Diameter, false) => 
								ordered?.ThenBy(planet => planet.Diameter) ??
								planets.OrderBy(planet => planet.Diameter),
							(Diameter, true) => 
								ordered?.ThenByDescending(planet => planet.Diameter) ??
								planets.OrderByDescending(planet => planet.Diameter),

							(Gravity, false) => 
								ordered?.ThenBy(planet => planet.Gravity) ??
								planets.OrderBy(planet => planet.Gravity),
							(Gravity, true) => 
								ordered?.ThenByDescending(planet => planet.Gravity) ??
								planets.OrderByDescending(planet => planet.Gravity),

							(Name, false) => 
								ordered?.ThenBy(planet => planet.Name) ??
								planets.OrderBy(planet => planet.Name),
							(Name, true) => 
								ordered?.ThenByDescending(planet => planet.Name) ??
								planets.OrderByDescending(planet => planet.Name),

							(OrbitalPeriod, false) => 
								ordered?.ThenBy(planet => planet.OrbitalPeriod) ??
								planets.OrderBy(planet => planet.OrbitalPeriod),
							(OrbitalPeriod, true) => 
								ordered?.ThenByDescending(planet => planet.OrbitalPeriod) ??
								planets.OrderByDescending(planet => planet.OrbitalPeriod),

							(Population, false) => 
								ordered?.ThenBy(planet => planet.Population) ??
								planets.OrderBy(planet => planet.Population),
							(Population, true) => 
								ordered?.ThenByDescending(planet => planet.Population) ??
								planets.OrderByDescending(planet => planet.Population),

							(ResidentsCount, false) => 
								ordered?.ThenBy(planet => planet.ResidentIds != null ? planet.ResidentIds.Count() : 0) ??
								planets.OrderBy(planet => planet.ResidentIds != null ? planet.ResidentIds.Count() : 0),
							(ResidentsCount, true) => 
								ordered?.ThenByDescending(planet => planet.ResidentIds != null ? planet.ResidentIds.Count() : 0) ??
								planets.OrderByDescending(planet => planet.ResidentIds != null ? planet.ResidentIds.Count() : 0),

							(RotationalPeriod, false) => 
								ordered?.ThenBy(planet => planet.RotationalPeriod) ??
								planets.OrderBy(planet => planet.RotationalPeriod),
							(RotationalPeriod, true) => 
								ordered?.ThenByDescending(planet => planet.RotationalPeriod) ??
								planets.OrderByDescending(planet => planet.RotationalPeriod),

							(SurfaceWater, false) => 
								ordered?.ThenBy(planet => planet.SurfaceWater) ??
								planets.OrderBy(planet => planet.SurfaceWater),
							(SurfaceWater, true) => 
								ordered?.ThenByDescending(planet => planet.SurfaceWater) ??
								planets.OrderByDescending(planet => planet.SurfaceWater),

							(TerrainsCount, false) => 
								ordered?.ThenBy(planet => planet.Terrains != null ? planet.Terrains.Count() : 0) ??
								planets.OrderBy(planet => planet.Terrains != null ? planet.Terrains.Count() : 0),
							(TerrainsCount, true) => 
								ordered?.ThenByDescending(planet => planet.Terrains != null ? planet.Terrains.Count() : 0) ??
								planets.OrderByDescending(planet => planet.Terrains != null ? planet.Terrains.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? planets, sorters),
						};

					return ordered ?? planets.OrderBy(planet => planet);
				}
			}

			public new class Default : Default<string?>, ISortKeys
			{
				public Default() : base(null) { }
			}
			public new class Default<T> : IStarWarsModel.ISortKeys.Default<T>, ISortKeys<T>
			{
				public Default(T defaultvalue) : base(defaultvalue) 
				{
					ClimatesCount = defaultvalue;
					Diameter = defaultvalue;
					Gravity = defaultvalue;
					Name = defaultvalue;
					OrbitalPeriod = defaultvalue;
					Population = defaultvalue;
					ResidentsCount = defaultvalue;
					RotationalPeriod = defaultvalue;
					SurfaceWater = defaultvalue;
					TerrainsCount = defaultvalue;
				}

				public T ClimatesCount { get; set; }
				public T Diameter { get; set; }
				public T Gravity { get; set; }
				public T Name { get; set; }
				public T OrbitalPeriod { get; set; }
				public T Population { get; set; }
				public T ResidentsCount { get; set; }
				public T RotationalPeriod { get; set; }
				public T SurfaceWater { get; set; }
				public T TerrainsCount { get; set; }
			}
		}
	}
}
