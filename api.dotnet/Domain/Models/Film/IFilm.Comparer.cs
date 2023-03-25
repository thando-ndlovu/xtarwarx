using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IFilm
    {
        public class Comparer : Comparer<IFilm>
        {
			public new class Keys : Comparer<IFilm>.Keys
			{
				public const string CastMembers = "CastMembers";
				public const string CastMemberCount = "CastMemberCount";
				public const string Characters = "Characters";
				public const string CharacterCount = "CharacterCount";
				public const string Director = "Director";
				public const string Duration = "Duration";
				public const string EpisodeId = "EpisodeId";
				public const string Factions = "Factions";
				public const string FactionCount = "FactionCount";
				public const string Manufacturers = "Manufacturers";
				public const string ManufacturerCount = "ManufacturerCount";
				public const string Planets = "Planets";
				public const string PlanetCount = "PlanetCount";
				public const string Producers = "Producers";
				public const string ProducerCount = "ProducerCount";
				public const string ReleaseDate = "ReleaseDate";
				public const string Species = "Species";
				public const string SpecieCount = "SpecieCount";
				public const string Starships = "Starships";
				public const string StarshipCount = "StarshipCount";
				public const string Title = "Title";
				public const string Vehicles = "Vehicles";
				public const string VehicleCount = "VehicleCount";
				public const string Weapons = "Weapons";
				public const string WeaponCount = "WeaponCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IFilm>.Keys.AsEnumerable()
						.Append(CastMembers)
						.Append(CastMemberCount)
						.Append(Characters)
						.Append(CharacterCount)
						.Append(Director)
						.Append(Duration)
						.Append(EpisodeId)
						.Append(Factions)
						.Append(FactionCount)
						.Append(Manufacturers)
						.Append(ManufacturerCount)
						.Append(Planets)
						.Append(PlanetCount)
						.Append(Producers)
						.Append(ProducerCount)
						.Append(ReleaseDate)
						.Append(Species)
						.Append(SpecieCount)
						.Append(Starships)
						.Append(StarshipCount)
						.Append(Title)
						.Append(Vehicles)
						.Append(VehicleCount)
						.Append(Weapons)
						.Append(WeaponCount);
				}
			}

			public override int Compare(IFilm? x, IFilm? y)
			{
				return ComparerKey switch
				{
					Keys.CastMemberCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.CastMembers?.Count(), y?.CastMembers?.Count()),

					Keys.CharacterCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.CharacterIds?.Count(), y?.CharacterIds?.Count()),

					Keys.Duration => ((IComparer<TimeSpan?>)(KeyComparer ??= System.Collections.Generic.Comparer<TimeSpan?>.Default))
						.Compare(x?.Duration, y?.Duration),

					Keys.EpisodeId => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.EpisodeId, y?.EpisodeId),

					Keys.FactionCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.FactionIds?.Count(), y?.FactionIds?.Count()),

					Keys.ManufacturerCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.ManufacturerIds?.Count(), y?.ManufacturerIds?.Count()),

					Keys.PlanetCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.PlanetIds?.Count(), y?.PlanetIds?.Count()),

					Keys.ProducerCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Producers?.Count(), y?.Producers?.Count()),

					Keys.ReleaseDate => ((IComparer<DateTime?>)(KeyComparer ??= System.Collections.Generic.Comparer<DateTime?>.Default))
						.Compare(x?.ReleaseDate, y?.ReleaseDate),

					Keys.SpecieCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.SpecieIds?.Count(), y?.SpecieIds?.Count()),

					Keys.StarshipCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.StarshipIds?.Count(), y?.StarshipIds?.Count()),

					Keys.Title => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Title, y?.Title),

					Keys.VehicleCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.VehicleIds?.Count(), y?.VehicleIds?.Count()),

					Keys.WeaponCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.WeaponIds?.Count(), y?.WeaponIds?.Count()),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IFilm? x, IFilm? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.CastMembers => x.CastMembers != null && y.CastMembers != null && x.CastMembers.SequenceEqual(y.CastMembers),
						Keys.CastMemberCount => (x.CastMembers is null && y.CastMembers is null) || Equals(x.CastMembers?.Count(), y.CastMembers?.Count()),
						Keys.Characters => x.CharacterIds != null && y.CharacterIds != null && x.CharacterIds.SequenceEqual(y.CharacterIds),
						Keys.CharacterCount => (x.CharacterIds is null && y.CharacterIds is null) || Equals(x.CharacterIds?.Count(), y.CharacterIds?.Count()),
						Keys.Director => (x.Director is null && y.Director is null) || Equals(x.Director, y.Director),
						Keys.Duration => (x.Duration is null && y.Duration is null) || Equals(x.Duration, y.Duration),
						Keys.EpisodeId => (x.EpisodeId is null && y.EpisodeId is null) || Equals(x.EpisodeId, y.EpisodeId),
						Keys.Factions => x.FactionIds != null && y.FactionIds != null && x.FactionIds.SequenceEqual(y.FactionIds),
						Keys.FactionCount => (x.FactionIds is null && y.FactionIds is null) || Equals(x.FactionIds?.Count(), y.FactionIds?.Count()),
						Keys.Manufacturers => x.ManufacturerIds != null && y.ManufacturerIds != null && x.ManufacturerIds.SequenceEqual(y.ManufacturerIds),
						Keys.ManufacturerCount => (x.ManufacturerIds is null && y.ManufacturerIds is null) || Equals(x.ManufacturerIds?.Count(), y.ManufacturerIds?.Count()),
						Keys.Planets => x.PlanetIds != null && y.PlanetIds != null && x.PlanetIds.SequenceEqual(y.PlanetIds),
						Keys.PlanetCount => (x.PlanetIds is null && y.PlanetIds is null) || Equals(x.PlanetIds?.Count(), y.PlanetIds?.Count()),
						Keys.Producers => x.Producers != null && y.Producers != null && x.Producers.SequenceEqual(y.Producers),
						Keys.ProducerCount => (x.Producers is null && y.Producers is null) || Equals(x.Producers?.Count(), y.Producers?.Count()),
						Keys.ReleaseDate => (x.ReleaseDate is null && y.ReleaseDate is null) || Equals(x.ReleaseDate, y.ReleaseDate),
						Keys.Species => x.SpecieIds != null && y.SpecieIds != null && x.SpecieIds.SequenceEqual(y.SpecieIds),
						Keys.SpecieCount => (x.SpecieIds is null && y.SpecieIds is null) || Equals(x.SpecieIds?.Count(), y.SpecieIds?.Count()),
						Keys.Starships => x.StarshipIds != null && y.StarshipIds != null && x.StarshipIds.SequenceEqual(y.StarshipIds),
						Keys.StarshipCount => (x.StarshipIds is null && y.StarshipIds is null) || Equals(x.StarshipIds?.Count(), y.StarshipIds?.Count()),
						Keys.Title => (x.Title is null && y.Title is null) || Equals(x.Title, y.Title),
						Keys.Vehicles => x.VehicleIds != null && y.VehicleIds != null && x.VehicleIds.SequenceEqual(y.VehicleIds),
						Keys.VehicleCount => (x.VehicleIds is null && y.VehicleIds is null) || Equals(x.VehicleIds?.Count(), y.VehicleIds?.Count()),
						Keys.Weapons => x.WeaponIds != null && y.WeaponIds != null && x.WeaponIds.SequenceEqual(y.WeaponIds),
						Keys.WeaponCount => (x.WeaponIds is null && y.WeaponIds is null) || Equals(x.WeaponIds?.Count(), y.WeaponIds?.Count()),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IFilm obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
