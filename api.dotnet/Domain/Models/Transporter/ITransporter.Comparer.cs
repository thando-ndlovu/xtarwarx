using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface ITransporter
    {
        public new class Comparer<T> : IStarWarsModel.Comparer<T> where T : ITransporter
		{
			public new class Keys : IStarWarsModel.Comparer<T>.Keys
			{
				public const string CargoCapacity = "CargoCapacity";
				public const string Consumables = "Consumables";
				public const string CostInCredits = "CostInCredits";
				public const string Length = "Length";
				public const string Manufacturers = "Manufacturers";
				public const string ManufacturerCount = "ManufacturerCount";
				public const string MaxAtmospheringSpeed = "MaxAtmospheringSpeed";
				public const string MaxCrew = "MaxCrew";
				public const string MinCrew = "MinCrew";
				public const string Model = "Model";
				public const string Name = "Name";
				public const string Passengers = "Passengers";
				public const string Pilots = "Pilots";
				public const string PilotCount = "PilotCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.Comparer<T>.Keys.AsEnumerable()
						.Append(CargoCapacity)
						.Append(Consumables)
						.Append(CostInCredits)
						.Append(Length)
						.Append(Manufacturers)
						.Append(ManufacturerCount)
						.Append(MaxAtmospheringSpeed)
						.Append(MaxCrew)
						.Append(MinCrew)
						.Append(Model)
						.Append(Name)
						.Append(Passengers)
						.Append(Pilots)
						.Append(PilotCount);
				}
			}

			public override int Compare(T? x, T? y)
			{
				return ComparerKey switch
				{
					Keys.CargoCapacity => ((IComparer<long?>)(KeyComparer ??= System.Collections.Generic.Comparer<long?>.Default))
						.Compare(x?.CargoCapacity, y?.CargoCapacity),

					Keys.Consumables => ((IConsumable.Comparer)(KeyComparer ??= new IConsumable.Comparer()))
						.Compare(x?.Consumables, y?.Consumables),

					Keys.CostInCredits => ((IComparer<long?>)(KeyComparer ??= System.Collections.Generic.Comparer<long?>.Default))
						.Compare(x?.CostInCredits, y?.CostInCredits),

					Keys.Length => ((IComparer<double?>)(KeyComparer ??= System.Collections.Generic.Comparer<double?>.Default))
						.Compare(x?.Length, y?.Length),

					Keys.ManufacturerCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.ManufacturerIds?.Count(), y?.ManufacturerIds?.Count()),

					Keys.MaxAtmospheringSpeed => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.MaxAtmospheringSpeed, y?.MaxAtmospheringSpeed),

					Keys.MaxCrew => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.MaxCrew, y?.MaxCrew),

					Keys.MinCrew => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.MinCrew, y?.MinCrew),

					Keys.Model => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Model, y?.Model),

					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					Keys.Passengers => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Passengers, y?.Passengers),

					Keys.PilotCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.PilotIds?.Count(), y?.PilotIds?.Count()),


					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(T? x, T? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.CargoCapacity => (x.CargoCapacity is null && y.CargoCapacity is null) || Equals(x.CargoCapacity, y.CargoCapacity),
						Keys.Consumables => (x.Consumables is null && y.Consumables is null) || new IConsumable.Comparer().Equals(x.Consumables, y.Consumables),
						Keys.CostInCredits => (x.CostInCredits is null && y.CostInCredits is null) || Equals(x.CostInCredits, y.CostInCredits),
						Keys.Length => (x.Length is null && y.Length is null) || Equals(x.Length, y.Length),
						Keys.Manufacturers => x.ManufacturerIds != null && y.ManufacturerIds != null && x.ManufacturerIds.SequenceEqual(y.ManufacturerIds),
						Keys.ManufacturerCount => (x.ManufacturerIds is null && y.ManufacturerIds is null) || Equals(x.ManufacturerIds?.Count(), y.ManufacturerIds?.Count()),
						Keys.MaxAtmospheringSpeed => (x.MaxAtmospheringSpeed is null && y.MaxAtmospheringSpeed is null) || Equals(x.MaxAtmospheringSpeed, y.MaxAtmospheringSpeed),
						Keys.MaxCrew => (x.MaxCrew is null && y.MaxCrew is null) || Equals(x.MaxCrew, y.MaxCrew),
						Keys.MinCrew => (x.MinCrew is null && y.MinCrew is null) || Equals(x.MinCrew, y.MinCrew),
						Keys.Model => (x.Model is null && y.Model is null) || Equals(x.Model, y.Model),
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),
						Keys.Passengers => (x.Passengers is null && y.Passengers is null) || Equals(x.Passengers, y.Passengers),
						Keys.Pilots => x.PilotIds != null && y.PilotIds != null && x.PilotIds.SequenceEqual(y.PilotIds),
						Keys.PilotCount => (x.PilotIds is null && y.PilotIds is null) || Equals(x.PilotIds?.Count(), y.PilotIds?.Count()),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(T obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
