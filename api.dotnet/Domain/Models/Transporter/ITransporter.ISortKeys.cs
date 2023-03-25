using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface ITransporter : IStarWarsModel
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T>
		{
			T CargoCapacity { get; set; }
			T Consumables { get; set; }
			T CostInCredits { get; set; }
			T Length { get; set; }
			T ManufacturerCount { get; set; }
			T MaxAtmospheringSpeed { get; set; }
			T MaxCrew { get; set; }
			T MinCrew { get; set; }
			T Model { get; set; }
			T Name { get; set; }
			T Passengers { get; set; }
			T PilotCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.CargoCapacity => CargoCapacity,
					ISortKeys.Keys.Consumables => Consumables,
					ISortKeys.Keys.CostInCredits => CostInCredits,
					ISortKeys.Keys.Length => Length,
					ISortKeys.Keys.ManufacturerCount => ManufacturerCount,
					ISortKeys.Keys.MaxAtmospheringSpeed => MaxAtmospheringSpeed,
					ISortKeys.Keys.MaxCrew => MaxCrew,
					ISortKeys.Keys.MinCrew => MinCrew,
					ISortKeys.Keys.Model => Model,
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.Passengers => Passengers,
					ISortKeys.Keys.PilotCount => PilotCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(CargoCapacity), CargoCapacity).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Consumables), Consumables).AppendLine()
						.AppendFormat("{0}: {1}", nameof(CostInCredits), CostInCredits).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Length), Length).AppendLine()
						.AppendFormat("{0}: {1}", nameof(ManufacturerCount), ManufacturerCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(MaxAtmospheringSpeed), MaxAtmospheringSpeed).AppendLine()
						.AppendFormat("{0}: {1}", nameof(MaxCrew), MaxCrew).AppendLine()
						.AppendFormat("{0}: {1}", nameof(MinCrew), MinCrew).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Model), Model).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Passengers), Passengers).AppendLine()
						.AppendFormat("{0}: {1}", nameof(PilotCount), PilotCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string CargoCapacity = "CargoCapacity";
				public const string Consumables = "Consumables";
				public const string CostInCredits = "CostInCredits";
				public const string Length = "Length";
				public const string ManufacturerCount = "ManufacturerCount";
				public const string MaxAtmospheringSpeed = "MaxAtmospheringSpeed";
				public const string MaxCrew = "MaxCrew";
				public const string MinCrew = "MinCrew";
				public const string Model = "Model";
				public const string Name = "Name";
				public const string Passengers = "Passengers";
				public const string PilotCount = "PilotCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(CargoCapacity)
						.Append(Consumables)
						.Append(CostInCredits)
						.Append(Length)
						.Append(ManufacturerCount)
						.Append(MaxAtmospheringSpeed)
						.Append(MaxCrew)
						.Append(MinCrew)
						.Append(Model)
						.Append(Name)
						.Append(Passengers)
						.Append(PilotCount);
				}

				public new static IOrderedEnumerable<TTransporter> Sort<TTransporter>(IEnumerable<TTransporter> transporters, params Sorter[] sorters) where TTransporter : ITransporter
				{
					IOrderedEnumerable<TTransporter>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(CargoCapacity, false) => 
								ordered?.ThenBy(transporter => transporter.CargoCapacity) ??
								transporters.OrderBy(transporter => transporter.CargoCapacity),
							(CargoCapacity, true) => 
								ordered?.ThenByDescending(transporter => transporter.CargoCapacity) ??
								transporters.OrderByDescending(transporter => transporter.CargoCapacity),

							(Consumables, false) => 
								ordered?.ThenBy(transporter => transporter.Consumables, new IConsumable.Comparer()) ??
								transporters.OrderBy(transporter => transporter.Consumables, new IConsumable.Comparer()),
							(Consumables, true) => 
								ordered?.ThenByDescending(transporter => transporter.Consumables, new IConsumable.Comparer()) ??
								transporters.OrderByDescending(transporter => transporter.Consumables, new IConsumable.Comparer()),

							(CostInCredits, false) => 
								ordered?.ThenBy(transporter => transporter.CostInCredits) ??
								transporters.OrderBy(transporter => transporter.CostInCredits),
							(CostInCredits, true) => 
								ordered?.ThenByDescending(transporter => transporter.CostInCredits) ??
								transporters.OrderByDescending(transporter => transporter.CostInCredits),

							(Length, false) => 
								ordered?.ThenBy(transporter => transporter.Length) ??
								transporters.OrderBy(transporter => transporter.Length),
							(Length, true) => 
								ordered?.ThenByDescending(transporter => transporter.Length) ??
								transporters.OrderByDescending(transporter => transporter.Length),

							(ManufacturerCount, false) => 
								ordered?.ThenBy(transporter => transporter.ManufacturerIds?.Count()) ??
								transporters.OrderBy(transporter => transporter.ManufacturerIds?.Count()),
							(ManufacturerCount, true) => 
								ordered?.ThenByDescending(transporter => transporter.ManufacturerIds?.Count()) ??
								transporters.OrderByDescending(transporter => transporter.ManufacturerIds?.Count()),

							(MaxAtmospheringSpeed, false) => 
								ordered?.ThenBy(transporter => transporter.MaxAtmospheringSpeed) ??
								transporters.OrderBy(transporter => transporter.MaxAtmospheringSpeed),
							(MaxAtmospheringSpeed, true) => 
								ordered?.ThenByDescending(transporter => transporter.MaxAtmospheringSpeed) ??
								transporters.OrderByDescending(transporter => transporter.MaxAtmospheringSpeed),

							(MaxCrew, false) => 
								ordered?.ThenBy(transporter => transporter.MaxCrew) ??
								transporters.OrderBy(transporter => transporter.MaxCrew),
							(MaxCrew, true) => 
								ordered?.ThenByDescending(transporter => transporter.MaxCrew) ??
								transporters.OrderByDescending(transporter => transporter.MaxCrew),

							(MinCrew, false) => 
								ordered?.ThenBy(transporter => transporter.MinCrew) ??
								transporters.OrderBy(transporter => transporter.MinCrew),
							(MinCrew, true) => 
								ordered?.ThenByDescending(transporter => transporter.MinCrew) ??
								transporters.OrderByDescending(transporter => transporter.MinCrew),

							(Model, false) => 
								ordered?.ThenBy(transporter => transporter.Model) ??
								transporters.OrderBy(transporter => transporter.Model),
							(Model, true) => 
								ordered?.ThenByDescending(transporter => transporter.Model) ??
								transporters.OrderByDescending(transporter => transporter.Model),

							(Name, false) => 
								ordered?.ThenBy(transporter => transporter.Name) ??
								transporters.OrderBy(transporter => transporter.Name),
							(Name, true) => 
								ordered?.ThenByDescending(transporter => transporter.Name) ??
								transporters.OrderByDescending(transporter => transporter.Name),

							(Passengers, false) => 
								ordered?.ThenBy(transporter => transporter.Passengers) ??
								transporters.OrderBy(transporter => transporter.Passengers),
							(Passengers, true) => 
								ordered?.ThenByDescending(transporter => transporter.Passengers) ??
								transporters.OrderByDescending(transporter => transporter.Passengers),

							(PilotCount, false) => 
								ordered?.ThenBy(transporter => transporter.PilotIds?.Count()) ??
								transporters.OrderBy(transporter => transporter.PilotIds?.Count()),
							(PilotCount, true) => 
								ordered?.ThenByDescending(transporter => transporter.PilotIds?.Count()) ??
								transporters.OrderByDescending(transporter => transporter.PilotIds?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? transporters, sorters),
						};

					return ordered ?? transporters.OrderBy(transporter => transporter);
				}
				public new static IOrderedQueryable<TTransporter> Sort<TTransporter>(IQueryable<TTransporter> transporters, params Sorter[] sorters) where TTransporter : ITransporter
				{
					IOrderedQueryable<TTransporter>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(CargoCapacity, false) => 
								ordered?.ThenBy(transporter => transporter.CargoCapacity) ??
								transporters.OrderBy(transporter => transporter.CargoCapacity),
							(CargoCapacity, true) => 
								ordered?.ThenByDescending(transporter => transporter.CargoCapacity) ??
								transporters.OrderByDescending(transporter => transporter.CargoCapacity),

							(Consumables, false) => 
								ordered?.ThenBy(transporter => transporter.Consumables, new IConsumable.Comparer()) ??
								transporters.OrderBy(transporter => transporter.Consumables, new IConsumable.Comparer()),
							(Consumables, true) => 
								ordered?.ThenByDescending(transporter => transporter.Consumables, new IConsumable.Comparer()) ??
								transporters.OrderByDescending(transporter => transporter.Consumables, new IConsumable.Comparer()),

							(CostInCredits, false) => 
								ordered?.ThenBy(transporter => transporter.CostInCredits) ??
								transporters.OrderBy(transporter => transporter.CostInCredits),
							(CostInCredits, true) => 
								ordered?.ThenByDescending(transporter => transporter.CostInCredits) ??
								transporters.OrderByDescending(transporter => transporter.CostInCredits),

							(Length, false) => 
								ordered?.ThenBy(transporter => transporter.Length) ??
								transporters.OrderBy(transporter => transporter.Length),
							(Length, true) => 
								ordered?.ThenByDescending(transporter => transporter.Length) ??
								transporters.OrderByDescending(transporter => transporter.Length),

							(ManufacturerCount, false) => 
								ordered?.ThenBy(transporter => transporter.ManufacturerIds != null ? transporter.ManufacturerIds.Count() : 0) ??
								transporters.OrderBy(transporter => transporter.ManufacturerIds != null ? transporter.ManufacturerIds.Count() : 0),
							(ManufacturerCount, true) => 
								ordered?.ThenByDescending(transporter => transporter.ManufacturerIds != null ? transporter.ManufacturerIds.Count() : 0) ??
								transporters.OrderByDescending(transporter => transporter.ManufacturerIds != null ? transporter.ManufacturerIds.Count() : 0),

							(MaxAtmospheringSpeed, false) => 
								ordered?.ThenBy(transporter => transporter.MaxAtmospheringSpeed) ??
								transporters.OrderBy(transporter => transporter.MaxAtmospheringSpeed),
							(MaxAtmospheringSpeed, true) => 
								ordered?.ThenByDescending(transporter => transporter.MaxAtmospheringSpeed) ??
								transporters.OrderByDescending(transporter => transporter.MaxAtmospheringSpeed),

							(MaxCrew, false) => 
								ordered?.ThenBy(transporter => transporter.MaxCrew) ??
								transporters.OrderBy(transporter => transporter.MaxCrew),
							(MaxCrew, true) => 
								ordered?.ThenByDescending(transporter => transporter.MaxCrew) ??
								transporters.OrderByDescending(transporter => transporter.MaxCrew),

							(MinCrew, false) => 
								ordered?.ThenBy(transporter => transporter.MinCrew) ??
								transporters.OrderBy(transporter => transporter.MinCrew),
							(MinCrew, true) => 
								ordered?.ThenByDescending(transporter => transporter.MinCrew) ??
								transporters.OrderByDescending(transporter => transporter.MinCrew),

							(Model, false) => 
								ordered?.ThenBy(transporter => transporter.Model) ??
								transporters.OrderBy(transporter => transporter.Model),
							(Model, true) => 
								ordered?.ThenByDescending(transporter => transporter.Model) ??
								transporters.OrderByDescending(transporter => transporter.Model),

							(Name, false) => 
								ordered?.ThenBy(transporter => transporter.Name) ??
								transporters.OrderBy(transporter => transporter.Name),
							(Name, true) => 
								ordered?.ThenByDescending(transporter => transporter.Name) ??
								transporters.OrderByDescending(transporter => transporter.Name),

							(Passengers, false) => 
								ordered?.ThenBy(transporter => transporter.Passengers) ??
								transporters.OrderBy(transporter => transporter.Passengers),
							(Passengers, true) => 
								ordered?.ThenByDescending(transporter => transporter.Passengers) ??
								transporters.OrderByDescending(transporter => transporter.Passengers),

							(PilotCount, false) => 
								ordered?.ThenBy(transporter => transporter.PilotIds != null ? transporter.PilotIds.Count() : 0) ??
								transporters.OrderBy(transporter => transporter.PilotIds != null ? transporter.PilotIds.Count() : 0),
							(PilotCount, true) => 
								ordered?.ThenByDescending(transporter => transporter.PilotIds != null ? transporter.PilotIds.Count() : 0) ??
								transporters.OrderByDescending(transporter => transporter.PilotIds != null ? transporter.PilotIds.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? transporters, sorters),
						};

					return ordered ?? transporters.OrderBy(transporter => transporter);
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
					CargoCapacity = defaultvalue;
					Consumables = defaultvalue;
					CostInCredits = defaultvalue;
					Length = defaultvalue;
					ManufacturerCount = defaultvalue;
					MaxAtmospheringSpeed = defaultvalue;
					MaxCrew = defaultvalue;
					MinCrew = defaultvalue;
					Model = defaultvalue;
					Name = defaultvalue;
					Passengers = defaultvalue;
					PilotCount = defaultvalue;
				}

				public T CargoCapacity { get; set; }
				public T Consumables { get; set; }
				public T CostInCredits { get; set; }
				public T Length { get; set; }
				public T ManufacturerCount { get; set; }
				public T MaxAtmospheringSpeed { get; set; }
				public T MaxCrew { get; set; }
				public T MinCrew { get; set; }
				public T Model { get; set; }
				public T Name { get; set; }
				public T Passengers { get; set; }
				public T PilotCount { get; set; }
			}
		}
	}
}
