using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Species
{
	public interface ISpecieSearchLocalisation<T> : IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T AverageHeightsList { get; set; }
		T AverageHeightRange { get; set; }
		T AverageLifespansList { get; set; }
		T AverageLifespanRange { get; set; }
		T CharactersSearchContainables { get; set; }
		T ClassificationsList { get; set; }
		T DesignationsList { get; set; }
		T EyeColorsList { get; set; }
		T HairColorsList { get; set; }
		T HomeworldSearchContainables { get; set; }
		T LanguagesList { get; set; }
		T SkinColorsList { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(AverageHeightRange), AverageHeightRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(AverageHeightsList), AverageHeightsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(AverageLifespanRange), AverageLifespanRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(AverageLifespansList), AverageLifespansList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CharactersSearchContainables), CharactersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ClassificationsList), ClassificationsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(DesignationsList), DesignationsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(EyeColorsList), EyeColorsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HairColorsList), HairColorsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HomeworldSearchContainables), HomeworldSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LanguagesList), LanguagesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SkinColorsList), SkinColorsList).AppendLine(); 

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}		 
	public interface ISpecieSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchListLocalisation<T> AverageHeightsList { get; set; }
		ISearchRangeLocalisation<T> AverageHeightRange { get; set; }
		ISearchListLocalisation<T> AverageLifespansList { get; set; }
		ISearchRangeLocalisation<T> AverageLifespanRange { get; set; }
		ISearchItemLocalisation<T> CharactersSearchContainables { get; set; }
		ISearchListLocalisation<T> ClassificationsList { get; set; }
		ISearchListLocalisation<T> DesignationsList { get; set; }
		ISearchListLocalisation<T> EyeColorsList { get; set; }
		ISearchListLocalisation<T> HairColorsList { get; set; }
		ISearchItemLocalisation<T> HomeworldSearchContainables { get; set; }
		ISearchListLocalisation<T> LanguagesList { get; set; }
		ISearchListLocalisation<T> SkinColorsList { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(AverageHeightRange)).AppendLine(AverageHeightRange.ToString()).AppendLine()
				.AppendLine(nameof(AverageHeightsList)).AppendLine(AverageHeightsList.ToString()).AppendLine()
				.AppendLine(nameof(AverageLifespanRange)).AppendLine(AverageLifespanRange.ToString()).AppendLine()
				.AppendLine(nameof(AverageLifespansList)).AppendLine(AverageLifespansList.ToString()).AppendLine()
				.AppendLine(nameof(CharactersSearchContainables)).AppendLine(CharactersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(ClassificationsList)).AppendLine(ClassificationsList.ToString()).AppendLine()
				.AppendLine(nameof(DesignationsList)).AppendLine(DesignationsList.ToString()).AppendLine()
				.AppendLine(nameof(EyeColorsList)).AppendLine(EyeColorsList.ToString()).AppendLine()
				.AppendLine(nameof(HairColorsList)).AppendLine(HairColorsList.ToString()).AppendLine()
				.AppendLine(nameof(HomeworldSearchContainables)).AppendLine(HomeworldSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(LanguagesList)).AppendLine(LanguagesList.ToString()).AppendLine()
				.AppendLine(nameof(SkinColorsList)).AppendLine(SkinColorsList.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface ISpecieSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchListLocalisation? AverageHeightsList { get; set; }
		ISearchRangeLocalisation? AverageHeightRange { get; set; }
		ISearchListLocalisation? AverageLifespansList { get; set; }
		ISearchRangeLocalisation? AverageLifespanRange { get; set; }
		ISearchItemLocalisation? CharactersSearchContainables { get; set; }
		ISearchListLocalisation? ClassificationsList { get; set; }
		ISearchListLocalisation? DesignationsList { get; set; }
		ISearchListLocalisation? EyeColorsList { get; set; }
		ISearchListLocalisation? HairColorsList { get; set; }
		ISearchItemLocalisation? HomeworldSearchContainables { get; set; }
		ISearchListLocalisation? LanguagesList { get; set; }
		ISearchListLocalisation? SkinColorsList { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, ISpecieSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(AverageHeightRange)).AppendLine(AverageHeightRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(AverageHeightsList)).AppendLine(AverageHeightsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(AverageLifespanRange)).AppendLine(AverageLifespanRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(AverageLifespansList)).AppendLine(AverageLifespansList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(CharactersSearchContainables)).AppendLine(CharactersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ClassificationsList)).AppendLine(ClassificationsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(DesignationsList)).AppendLine(DesignationsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(EyeColorsList)).AppendLine(EyeColorsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HairColorsList)).AppendLine(HairColorsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HomeworldSearchContainables)).AppendLine(HomeworldSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(LanguagesList)).AppendLine(LanguagesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(SkinColorsList)).AppendLine(SkinColorsList?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		#region Defaults

		public new class Default : IStarWarsModelSearchLocalisation.Default, ISpecieSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchListLocalisation? AverageHeightsList { get; set; }
			public ISearchRangeLocalisation? AverageHeightRange { get; set; }
			public ISearchListLocalisation? AverageLifespansList { get; set; }
			public ISearchRangeLocalisation? AverageLifespanRange { get; set; }
			public ISearchItemLocalisation? CharactersSearchContainables { get; set; }
			public ISearchListLocalisation? ClassificationsList { get; set; }
			public ISearchListLocalisation? DesignationsList { get; set; }
			public ISearchListLocalisation? EyeColorsList { get; set; }
			public ISearchListLocalisation? HairColorsList { get; set; }
			public ISearchItemLocalisation? HomeworldSearchContainables { get; set; }
			public ISearchListLocalisation? LanguagesList { get; set; }
			public ISearchListLocalisation? SkinColorsList { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, ISpecieSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				AverageHeightsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				AverageHeightRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				AverageLifespansList = new ISearchListLocalisation.Default<T>(defaultvalue);
				AverageLifespanRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				CharactersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				ClassificationsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				DesignationsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				EyeColorsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				HairColorsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				HomeworldSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				LanguagesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				SkinColorsList = new ISearchListLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchListLocalisation<T> AverageHeightsList { get; set; }
			public ISearchRangeLocalisation<T> AverageHeightRange { get; set; }
			public ISearchListLocalisation<T> AverageLifespansList { get; set; }
			public ISearchRangeLocalisation<T> AverageLifespanRange { get; set; }
			public ISearchItemLocalisation<T> CharactersSearchContainables { get; set; }
			public ISearchListLocalisation<T> ClassificationsList { get; set; }
			public ISearchListLocalisation<T> DesignationsList { get; set; }
			public ISearchListLocalisation<T> EyeColorsList { get; set; }
			public ISearchListLocalisation<T> HairColorsList { get; set; }
			public ISearchItemLocalisation<T> HomeworldSearchContainables { get; set; }
			public ISearchListLocalisation<T> LanguagesList { get; set; }
			public ISearchListLocalisation<T> SkinColorsList { get; set; }
		}	 
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, ISpecieSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				AverageHeightsList = defaultvalue;
				AverageHeightRange = defaultvalue;
				AverageLifespansList = defaultvalue;
				AverageLifespanRange = defaultvalue;
				CharactersSearchContainables = defaultvalue;
				ClassificationsList = defaultvalue;
				DesignationsList = defaultvalue;
				EyeColorsList = defaultvalue;
				HairColorsList = defaultvalue;
				HomeworldSearchContainables = defaultvalue;
				LanguagesList = defaultvalue;
				SkinColorsList = defaultvalue;
			}

			public T Containables { get; set; }
			public T AverageHeightsList { get; set; }
			public T AverageHeightRange { get; set; }
			public T AverageLifespansList { get; set; }
			public T AverageLifespanRange { get; set; }
			public T CharactersSearchContainables { get; set; }
			public T ClassificationsList { get; set; }
			public T DesignationsList { get; set; }
			public T EyeColorsList { get; set; }
			public T HairColorsList { get; set; }
			public T HomeworldSearchContainables { get; set; }
			public T LanguagesList { get; set; }
			public T SkinColorsList { get; set; }
		}

		#endregion
	}
}
