using Localisation.Abstractions.StarWarsModels;
using Localisation.Abstractions.Transporters;

using System;
using System.Text;

namespace Localisation.Abstractions.Starships
{
	public interface IStarshipSearchLocalisation<T> : ITransporterSearchLocalisation<T>
	{
		T Containables { get; set; }
		T HyperdriveRatingsList { get; set; }
		T HyperdriveRatingRange { get; set; }
		T MGLTsList { get; set; }
		T MGLTRange { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HyperdriveRatingRange), HyperdriveRatingRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HyperdriveRatingsList), HyperdriveRatingsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MGLTRange), MGLTRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MGLTsList), MGLTsList).AppendLine();

			return (this as ITransporterSearchLocalisation<T>).ToString(stringbuilder);
		}
	} 
	public interface IStarshipSearchLocalisationTyped<T> : ITransporterSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchListLocalisation<T> HyperdriveRatingsList { get; set; }
		ISearchRangeLocalisation<T> HyperdriveRatingRange { get; set; }
		ISearchListLocalisation<T> MGLTsList { get; set; }
		ISearchRangeLocalisation<T> MGLTRange { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(HyperdriveRatingRange)).AppendLine(HyperdriveRatingRange.ToString()).AppendLine()
				.AppendLine(nameof(HyperdriveRatingsList)).AppendLine(HyperdriveRatingsList.ToString()).AppendLine()
				.AppendLine(nameof(MGLTRange)).AppendLine(MGLTRange.ToString()).AppendLine()
				.AppendLine(nameof(MGLTsList)).AppendLine(MGLTsList.ToString()).AppendLine();

			return (this as ITransporterSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IStarshipSearchLocalisation : ITransporterSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchListLocalisation? HyperdriveRatingsList { get; set; }
		ISearchRangeLocalisation? HyperdriveRatingRange { get; set; }
		ISearchListLocalisation? MGLTsList { get; set; }
		ISearchRangeLocalisation? MGLTRange { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IStarshipSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HyperdriveRatingRange)).AppendLine(HyperdriveRatingRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HyperdriveRatingsList)).AppendLine(HyperdriveRatingsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MGLTRange)).AppendLine(MGLTRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MGLTsList)).AppendLine(MGLTsList?.ToString(null, converter)).AppendLine();

			return (this as ITransporterSearchLocalisation).ToString(stringbuilder, converter);
		}

		#region Defaults

		public new class Default : ITransporterSearchLocalisation.Default, IStarshipSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchListLocalisation? HyperdriveRatingsList { get; set; }
			public ISearchRangeLocalisation? HyperdriveRatingRange { get; set; }
			public ISearchListLocalisation? MGLTsList { get; set; }
			public ISearchRangeLocalisation? MGLTRange { get; set; }
		}
		public new class DefaultTyped<T> : ITransporterSearchLocalisation.DefaultTyped<T>, IStarshipSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)															   
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				HyperdriveRatingsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				HyperdriveRatingRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				MGLTsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				MGLTRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchListLocalisation<T> HyperdriveRatingsList { get; set; }
			public ISearchRangeLocalisation<T> HyperdriveRatingRange { get; set; }
			public ISearchListLocalisation<T> MGLTsList { get; set; }
			public ISearchRangeLocalisation<T> MGLTRange { get; set; }
		}		   
		public new class Default<T> : ITransporterSearchLocalisation.Default<T>, IStarshipSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)															   
			{
				Containables = defaultvalue;
				HyperdriveRatingsList = defaultvalue;
				HyperdriveRatingRange = defaultvalue;
				MGLTsList = defaultvalue;
				MGLTRange = defaultvalue;
			}

			public T Containables { get; set; }
			public T HyperdriveRatingsList { get; set; }
			public T HyperdriveRatingRange { get; set; }
			public T MGLTsList { get; set; }
			public T MGLTRange { get; set; }
		}

		#endregion
	}
}
