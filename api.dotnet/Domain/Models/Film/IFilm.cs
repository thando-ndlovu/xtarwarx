using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface IFilm<T> : IStarWarsModel<T>
	{
		T CastMembers { get; set; }
		T CharacterIds { get; set; }
		T Description { get; set; }
		T Director { get; set; }
		T Duration { get; set; }
		T EpisodeId { get; set; }
		T FactionIds { get; set; }
		T ManufacturerIds { get; set; }
		T OpeningCrawl { get; set; }
		T PlanetIds { get; set; }
		T Producers { get; set; }
		T ReleaseDate { get; set; }
		T SpecieIds { get; set; }
		T StarshipIds { get; set; }
		T Title { get; set; }
		T VehicleIds { get; set; }
		T WeaponIds { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(CastMembers), CastMembers).AppendLine()
					.AppendFormat("{0}: {1}", nameof(CharacterIds), CharacterIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Director), Director).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Duration), Duration).AppendLine()
					.AppendFormat("{0}: {1}", nameof(EpisodeId), EpisodeId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(FactionIds), FactionIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(ManufacturerIds), ManufacturerIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(OpeningCrawl), OpeningCrawl).AppendLine()
					.AppendFormat("{0}: {1}", nameof(PlanetIds), PlanetIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Producers), Producers).AppendLine()
					.AppendFormat("{0}: {1}", nameof(ReleaseDate), ReleaseDate).AppendLine()
					.AppendFormat("{0}: {1}", nameof(StarshipIds), StarshipIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine()
					.AppendFormat("{0}: {1}", nameof(VehicleIds), VehicleIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(WeaponIds), WeaponIds).AppendLine());
		}
	}
	public interface IFilmTyped<T> : IFilm<T>, IStarWarsModelTyped<T> { }
	public partial interface IFilm : IStarWarsModel
	{
		IEnumerable<string>? CastMembers { get; set; }
		IEnumerable<int>? CharacterIds { get; set; }
		string? Description { get; set; }
		string? Director { get; set; }
		TimeSpan? Duration { get; set; }
		int? EpisodeId { get; set; }
		IEnumerable<int>? FactionIds { get; set; }
		IEnumerable<int>? ManufacturerIds { get; set; }
		string? OpeningCrawl { get; set; }
		IEnumerable<int>? PlanetIds { get; set; }
		IEnumerable<string>? Producers { get; set; }
		DateTime? ReleaseDate { get; set; }
		IEnumerable<int>? SpecieIds { get; set; }
		IEnumerable<int>? StarshipIds { get; set; }
		string? Title { get; set; }
		IEnumerable<int>? VehicleIds { get; set; }
		IEnumerable<int>? WeaponIds { get; set; }

		public new class Default : IStarWarsModel.Default, IFilm
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject) 
			{
				CastMembers = jobject.GetValue(nameof(CastMembers), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<string>()
					.OfType<string>();
				CharacterIds = jobject.GetValue(nameof(CharacterIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Director = jobject.GetValue(nameof(Director), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Duration = jobject.GetValue(nameof(Duration), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is not int durationvalue
					? new TimeSpan?()
					: TimeSpan.FromMinutes(durationvalue);
				EpisodeId = jobject.GetValue(nameof(EpisodeId), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				FactionIds = jobject.GetValue(nameof(FactionIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				ManufacturerIds = jobject.GetValue(nameof(ManufacturerIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				OpeningCrawl = jobject.GetValue(nameof(OpeningCrawl), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				PlanetIds = jobject.GetValue(nameof(PlanetIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				Producers = jobject.GetValue(nameof(Producers), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<string?>()
					.OfType<string>();
				ReleaseDate = jobject.GetValue(nameof(ReleaseDate), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is string releassedate && DateTime.TryParse(releassedate, out DateTime outreleasedate)
					? outreleasedate
					: new DateTime?();
				SpecieIds = jobject.GetValue(nameof(SpecieIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				StarshipIds = jobject.GetValue(nameof(StarshipIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				Title = jobject.GetValue(nameof(Title), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				VehicleIds = jobject.GetValue(nameof(VehicleIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				WeaponIds = jobject.GetValue(nameof(WeaponIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
			}

			public IEnumerable<string>? CastMembers { get; set; }
			public IEnumerable<int>? CharacterIds { get; set; }
			public string? Description { get; set; }
			public string? Director { get; set; }
			public TimeSpan? Duration { get; set; }
			public int? EpisodeId { get; set; }
			public IEnumerable<int>? FactionIds { get; set; }
			public IEnumerable<int>? ManufacturerIds { get; set; }
			public string? OpeningCrawl { get; set; }
			public IEnumerable<int>? PlanetIds { get; set; }
			public IEnumerable<string>? Producers { get; set; }
			public DateTime? ReleaseDate { get; set; }
			public IEnumerable<int>? SpecieIds { get; set; }
			public IEnumerable<int>? StarshipIds { get; set; }
			public string? Title { get; set; }
			public IEnumerable<int>? VehicleIds { get; set; }
			public IEnumerable<int>? WeaponIds { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, IFilm<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				CastMembers = defaultvalue;
				CharacterIds = defaultvalue;
				Description = defaultvalue;
				Director = defaultvalue;
				Duration = defaultvalue;
				EpisodeId = defaultvalue;
				FactionIds = defaultvalue;
				ManufacturerIds = defaultvalue;
				OpeningCrawl = defaultvalue;
				PlanetIds = defaultvalue;
				Producers = defaultvalue;
				ReleaseDate = defaultvalue;
				SpecieIds = defaultvalue;
				StarshipIds = defaultvalue;
				Title = defaultvalue;
				VehicleIds = defaultvalue;
				WeaponIds = defaultvalue;
			}

			public T CastMembers { get; set; }
			public T CharacterIds { get; set; }
			public T Description { get; set; }
			public T Director { get; set; }
			public T Duration { get; set; }
			public T EpisodeId { get; set; }
			public T FactionIds { get; set; }
			public T ManufacturerIds { get; set; }
			public T OpeningCrawl { get; set; }
			public T PlanetIds { get; set; }
			public T Producers { get; set; }
			public T ReleaseDate { get; set; }
			public T SpecieIds { get; set; }
			public T StarshipIds { get; set; }
			public T Title { get; set; }
			public T VehicleIds { get; set; }
			public T WeaponIds { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IFilmTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				BaseTyped = new IStarWarsModel.DefaultTyped<T>(defaultvalue);
			}

			private IStarWarsModelTyped<T> BaseTyped { get; set; }
			IURI<T>? IStarWarsModelTyped<T>.Uris
			{
				get => BaseTyped.Uris;
				set => BaseTyped.Uris = value;
			}
		}

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: ", nameof(CastMembers)).AppendJoin(", ", CastMembers ?? Enumerable.Empty<string>()).AppendLine()
					.AppendFormat("{0}: ", nameof(CharacterIds)).AppendJoin(", ", CharacterIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Director), Director).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Duration), Duration).AppendLine()
					.AppendFormat("{0}: {1}", nameof(EpisodeId), EpisodeId).AppendLine()
					.AppendFormat("{0}: ", nameof(FactionIds)).AppendJoin(", ", FactionIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(ManufacturerIds)).AppendJoin(", ", ManufacturerIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(OpeningCrawl), OpeningCrawl).AppendLine()
					.AppendFormat("{0}: ", nameof(PlanetIds)).AppendJoin(", ", PlanetIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(Producers)).AppendJoin(", ", Producers ?? Enumerable.Empty<string>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(ReleaseDate), ReleaseDate).AppendLine()
					.AppendFormat("{0}: ", nameof(StarshipIds)).AppendJoin(", ", StarshipIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine()
					.AppendFormat("{0}: ", nameof(VehicleIds)).AppendJoin(", ", VehicleIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(WeaponIds)).AppendJoin(", ", WeaponIds ?? Enumerable.Empty<int>()).AppendLine());
		}
	}
}
