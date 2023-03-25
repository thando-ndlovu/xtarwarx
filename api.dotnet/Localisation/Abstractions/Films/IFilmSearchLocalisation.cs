using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Films
{
	public interface IFilmSearchLocalisation<T>	: IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T CharactersSearchContainables { get; set; }
		T DurationsList { get; set; }
		T DurationRange { get; set; }
		T EpisodeIdsList { get; set; }
		T EpisodeIdRange { get; set; }
		T FactionsSearchContainables { get; set; }
		T ManufacturersSearchContainables { get; set; }
		T PlanetsSearchContainables { get; set; }
		T ReleaseDatesList { get; set; }
		T ReleaseDateRange { get; set; }
		T SpeciesSearchContainables { get; set; }
		T StarshipsSearchContainables { get; set; }
		T VehiclesSearchContainables { get; set; }
		T WeaponsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CharactersSearchContainables), CharactersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(DurationRange), DurationRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(DurationsList), DurationsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(EpisodeIdRange), EpisodeIdRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(EpisodeIdsList), EpisodeIdsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(FactionsSearchContainables), FactionsSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ManufacturersSearchContainables), ManufacturersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PlanetsSearchContainables), PlanetsSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ReleaseDateRange), ReleaseDateRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ReleaseDatesList), ReleaseDatesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SpeciesSearchContainables), SpeciesSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(StarshipsSearchContainables), StarshipsSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(VehiclesSearchContainables), VehiclesSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(WeaponsSearchContainables), WeaponsSearchContainables).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}	
	public interface IFilmSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchItemLocalisation<T> CharactersSearchContainables { get; set; }
		ISearchListLocalisation<T> DurationsList { get; set; }
		ISearchRangeLocalisation<T> DurationRange { get; set; }
		ISearchListLocalisation<T> EpisodeIdsList { get; set; }
		ISearchRangeLocalisation<T> EpisodeIdRange { get; set; }
		ISearchItemLocalisation<T> FactionsSearchContainables { get; set; }
		ISearchItemLocalisation<T> ManufacturersSearchContainables { get; set; }
		ISearchItemLocalisation<T> PlanetsSearchContainables { get; set; }
		ISearchListLocalisation<T> ReleaseDatesList { get; set; }
		ISearchRangeLocalisation<T> ReleaseDateRange { get; set; }
		ISearchItemLocalisation<T> SpeciesSearchContainables { get; set; }
		ISearchItemLocalisation<T> StarshipsSearchContainables { get; set; }
		ISearchItemLocalisation<T> VehiclesSearchContainables { get; set; }
		ISearchItemLocalisation<T> WeaponsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(CharactersSearchContainables)).AppendLine(CharactersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(DurationRange)).AppendLine(DurationRange.ToString()).AppendLine()
				.AppendLine(nameof(DurationsList)).AppendLine(DurationsList.ToString()).AppendLine()
				.AppendLine(nameof(EpisodeIdRange)).AppendLine(EpisodeIdRange.ToString()).AppendLine()
				.AppendLine(nameof(EpisodeIdsList)).AppendLine(EpisodeIdsList.ToString()).AppendLine()
				.AppendLine(nameof(FactionsSearchContainables)).AppendLine(FactionsSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(ManufacturersSearchContainables)).AppendLine(ManufacturersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(PlanetsSearchContainables)).AppendLine(PlanetsSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(ReleaseDateRange)).AppendLine(ReleaseDateRange.ToString()).AppendLine()
				.AppendLine(nameof(ReleaseDatesList)).AppendLine(ReleaseDatesList.ToString()).AppendLine()
				.AppendLine(nameof(SpeciesSearchContainables)).AppendLine(SpeciesSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(StarshipsSearchContainables)).AppendLine(StarshipsSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(VehiclesSearchContainables)).AppendLine(VehiclesSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(WeaponsSearchContainables)).AppendLine(WeaponsSearchContainables.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IFilmSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchItemLocalisation? CharactersSearchContainables { get; set; }
		ISearchListLocalisation? DurationsList { get; set; }
		ISearchRangeLocalisation? DurationRange { get; set; }
		ISearchListLocalisation? EpisodeIdsList { get; set; }
		ISearchRangeLocalisation? EpisodeIdRange { get; set; }
		ISearchItemLocalisation? FactionsSearchContainables { get; set; }
		ISearchItemLocalisation? ManufacturersSearchContainables { get; set; }
		ISearchItemLocalisation? PlanetsSearchContainables { get; set; }
		ISearchListLocalisation? ReleaseDatesList { get; set; }
		ISearchRangeLocalisation? ReleaseDateRange { get; set; }
		ISearchItemLocalisation? SpeciesSearchContainables { get; set; }
		ISearchItemLocalisation? StarshipsSearchContainables { get; set; }
		ISearchItemLocalisation? VehiclesSearchContainables { get; set; }
		ISearchItemLocalisation? WeaponsSearchContainables { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IFilmSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(CharactersSearchContainables)).AppendLine(CharactersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(DurationRange)).AppendLine(DurationRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(DurationsList)).AppendLine(DurationsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(EpisodeIdRange)).AppendLine(EpisodeIdRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(EpisodeIdsList)).AppendLine(EpisodeIdsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(FactionsSearchContainables)).AppendLine(FactionsSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ManufacturersSearchContainables)).AppendLine(ManufacturersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(PlanetsSearchContainables)).AppendLine(PlanetsSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ReleaseDateRange)).AppendLine(ReleaseDateRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ReleaseDatesList)).AppendLine(ReleaseDatesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(SpeciesSearchContainables)).AppendLine(SpeciesSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(StarshipsSearchContainables)).AppendLine(StarshipsSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(VehiclesSearchContainables)).AppendLine(VehiclesSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(WeaponsSearchContainables)).AppendLine(WeaponsSearchContainables?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		#region Defaults

		public new class Default : IStarWarsModelSearchLocalisation.Default, IFilmSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchItemLocalisation? CharactersSearchContainables { get; set; }
			public ISearchListLocalisation? DurationsList { get; set; }
			public ISearchRangeLocalisation? DurationRange { get; set; }
			public ISearchListLocalisation? EpisodeIdsList { get; set; }
			public ISearchRangeLocalisation? EpisodeIdRange { get; set; }
			public ISearchItemLocalisation? FactionsSearchContainables { get; set; }
			public ISearchItemLocalisation? ManufacturersSearchContainables { get; set; }
			public ISearchItemLocalisation? PlanetsSearchContainables { get; set; }
			public ISearchListLocalisation? ReleaseDatesList { get; set; }
			public ISearchRangeLocalisation? ReleaseDateRange { get; set; }
			public ISearchItemLocalisation? SpeciesSearchContainables { get; set; }
			public ISearchItemLocalisation? StarshipsSearchContainables { get; set; }
			public ISearchItemLocalisation? VehiclesSearchContainables { get; set; }
			public ISearchItemLocalisation? WeaponsSearchContainables { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, IFilmSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				CharactersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				DurationsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				DurationRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				EpisodeIdsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				EpisodeIdRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				FactionsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				ManufacturersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				PlanetsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				ReleaseDatesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				ReleaseDateRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				SpeciesSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				StarshipsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				VehiclesSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				WeaponsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchItemLocalisation<T> CharactersSearchContainables { get; set; }
			public ISearchListLocalisation<T> DurationsList { get; set; }
			public ISearchRangeLocalisation<T> DurationRange { get; set; }
			public ISearchListLocalisation<T> EpisodeIdsList { get; set; }
			public ISearchRangeLocalisation<T> EpisodeIdRange { get; set; }
			public ISearchItemLocalisation<T> FactionsSearchContainables { get; set; }
			public ISearchItemLocalisation<T> ManufacturersSearchContainables { get; set; }
			public ISearchItemLocalisation<T> PlanetsSearchContainables { get; set; }
			public ISearchListLocalisation<T> ReleaseDatesList { get; set; }
			public ISearchRangeLocalisation<T> ReleaseDateRange { get; set; }
			public ISearchItemLocalisation<T> SpeciesSearchContainables { get; set; }
			public ISearchItemLocalisation<T> StarshipsSearchContainables { get; set; }
			public ISearchItemLocalisation<T> VehiclesSearchContainables { get; set; }
			public ISearchItemLocalisation<T> WeaponsSearchContainables { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, IFilmSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				CharactersSearchContainables = defaultvalue;
				DurationsList = defaultvalue;
				DurationRange = defaultvalue;
				EpisodeIdsList = defaultvalue;
				EpisodeIdRange = defaultvalue;
				FactionsSearchContainables = defaultvalue;
				ManufacturersSearchContainables = defaultvalue;
				PlanetsSearchContainables = defaultvalue;
				ReleaseDatesList = defaultvalue;
				ReleaseDateRange = defaultvalue;
				SpeciesSearchContainables = defaultvalue;
				StarshipsSearchContainables = defaultvalue;
				VehiclesSearchContainables = defaultvalue;
				WeaponsSearchContainables = defaultvalue;
			}

			public T Containables { get; set; }
			public T CharactersSearchContainables { get; set; }
			public T DurationsList { get; set; }
			public T DurationRange { get; set; }
			public T EpisodeIdsList { get; set; }
			public T EpisodeIdRange { get; set; }
			public T FactionsSearchContainables { get; set; }
			public T ManufacturersSearchContainables { get; set; }
			public T PlanetsSearchContainables { get; set; }
			public T ReleaseDatesList { get; set; }
			public T ReleaseDateRange { get; set; }
			public T SpeciesSearchContainables { get; set; }
			public T StarshipsSearchContainables { get; set; }
			public T VehiclesSearchContainables { get; set; }
			public T WeaponsSearchContainables { get; set; }
		}

		#endregion
	}
}
