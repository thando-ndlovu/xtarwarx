using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Characters
{
	public interface ICharacterSearchLocalisation<T> : IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T BirthYearsList { get; set; }
		T BirthYearRange { get; set; }
		T EyeColorsList { get; set; }
		T HairColorsList { get; set; }
		T HeightsList { get; set; }
		T HeightRange { get; set; }
		T HomeworldSearchContainables { get; set; }
		T MassesList { get; set; }
		T MassRange { get; set; }
		T SexesList { get; set; }
		T SkinColorsList { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(BirthYearRange), BirthYearRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(BirthYearsList), BirthYearsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(EyeColorsList), EyeColorsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HairColorsList), HairColorsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HeightRange), HeightRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HeightsList), HeightsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HomeworldSearchContainables), HomeworldSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MassRange), MassRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MassesList), MassesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SexesList), SexesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SkinColorsList), SkinColorsList).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface ICharacterSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchListLocalisation<T> BirthYearsList { get; set; }
		ISearchRangeLocalisation<T> BirthYearRange { get; set; }
		ISearchListLocalisation<T> EyeColorsList { get; set; }
		ISearchListLocalisation<T> HairColorsList { get; set; }
		ISearchListLocalisation<T> HeightsList { get; set; }
		ISearchRangeLocalisation<T> HeightRange { get; set; }
		ISearchItemLocalisation<T> HomeworldSearchContainables { get; set; }
		ISearchListLocalisation<T> MassesList { get; set; }
		ISearchRangeLocalisation<T> MassRange { get; set; }
		ISearchListLocalisation<T> SexesList { get; set; }
		ISearchListLocalisation<T> SkinColorsList { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(BirthYearRange)).AppendLine(BirthYearRange.ToString()).AppendLine()
				.AppendLine(nameof(BirthYearsList)).AppendLine(BirthYearsList.ToString()).AppendLine()
				.AppendLine(nameof(EyeColorsList)).AppendLine(EyeColorsList.ToString()).AppendLine()
				.AppendLine(nameof(HairColorsList)).AppendLine(HairColorsList.ToString()).AppendLine()
				.AppendLine(nameof(HeightRange)).AppendLine(HeightRange.ToString()).AppendLine()
				.AppendLine(nameof(HeightsList)).AppendLine(HeightsList.ToString()).AppendLine()
				.AppendLine(nameof(HomeworldSearchContainables)).AppendLine(HomeworldSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(MassesList)).AppendLine(MassesList.ToString()).AppendLine()
				.AppendLine(nameof(MassRange)).AppendLine(MassRange.ToString()).AppendLine()
				.AppendLine(nameof(SexesList)).AppendLine(SexesList.ToString()).AppendLine()
				.AppendLine(nameof(SkinColorsList)).AppendLine(SkinColorsList.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface ICharacterSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchListLocalisation? BirthYearsList { get; set; }
		ISearchRangeLocalisation? BirthYearRange { get; set; }
		ISearchListLocalisation? EyeColorsList { get; set; }
		ISearchListLocalisation? HairColorsList { get; set; }
		ISearchListLocalisation? HeightsList { get; set; }
		ISearchRangeLocalisation? HeightRange { get; set; }
		ISearchItemLocalisation? HomeworldSearchContainables { get; set; }
		ISearchListLocalisation? MassesList { get; set; }
		ISearchRangeLocalisation? MassRange { get; set; }
		ISearchListLocalisation? SexesList { get; set; }
		ISearchListLocalisation? SkinColorsList { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, ICharacterSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(BirthYearRange)).AppendLine(BirthYearRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(BirthYearsList)).AppendLine(BirthYearsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(EyeColorsList)).AppendLine(EyeColorsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HairColorsList)).AppendLine(HairColorsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HeightRange)).AppendLine(HeightRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HeightsList)).AppendLine(HeightsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HomeworldSearchContainables)).AppendLine(HomeworldSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MassesList)).AppendLine(MassesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MassRange)).AppendLine(MassRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(SexesList)).AppendLine(SexesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(SkinColorsList)).AppendLine(SkinColorsList?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : IStarWarsModelSearchLocalisation.Default, ICharacterSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchListLocalisation? BirthYearsList { get; set; }
			public ISearchRangeLocalisation? BirthYearRange { get; set; }
			public ISearchListLocalisation? EyeColorsList { get; set; }
			public ISearchListLocalisation? HairColorsList { get; set; }
			public ISearchListLocalisation? HeightsList { get; set; }
			public ISearchRangeLocalisation? HeightRange { get; set; }
			public ISearchItemLocalisation? HomeworldSearchContainables { get; set; }
			public ISearchListLocalisation? MassesList { get; set; }
			public ISearchRangeLocalisation? MassRange { get; set; }
			public ISearchListLocalisation? SexesList { get; set; }
			public ISearchListLocalisation? SkinColorsList { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, ICharacterSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				BirthYearRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				BirthYearsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				EyeColorsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				HairColorsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				HeightRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				HeightsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				HomeworldSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				MassesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				MassRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				SexesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				SkinColorsList = new ISearchListLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchListLocalisation<T> BirthYearsList { get; set; }
			public ISearchRangeLocalisation<T> BirthYearRange { get; set; }
			public ISearchListLocalisation<T> EyeColorsList { get; set; }
			public ISearchListLocalisation<T> HairColorsList { get; set; }
			public ISearchListLocalisation<T> HeightsList { get; set; }
			public ISearchRangeLocalisation<T> HeightRange { get; set; }
			public ISearchItemLocalisation<T> HomeworldSearchContainables { get; set; }
			public ISearchListLocalisation<T> MassesList { get; set; }
			public ISearchRangeLocalisation<T> MassRange { get; set; }
			public ISearchListLocalisation<T> SexesList { get; set; }
			public ISearchListLocalisation<T> SkinColorsList { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, ICharacterSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				BirthYearsList = defaultvalue;
				BirthYearRange = defaultvalue;
				EyeColorsList = defaultvalue;
				HairColorsList = defaultvalue;
				HeightsList = defaultvalue;
				HeightRange = defaultvalue;
				HomeworldSearchContainables = defaultvalue;
				MassesList = defaultvalue;
				MassRange = defaultvalue;
				SexesList = defaultvalue;
				SkinColorsList = defaultvalue;
			}
			public T Containables { get; set; }
			public T BirthYearsList { get; set; }
			public T BirthYearRange { get; set; }
			public T EyeColorsList { get; set; }
			public T HairColorsList { get; set; }
			public T HeightsList { get; set; }
			public T HeightRange { get; set; }
			public T HomeworldSearchContainables { get; set; }
			public T MassesList { get; set; }
			public T MassRange { get; set; }
			public T SexesList { get; set; }
			public T SkinColorsList { get; set; }
		}
	}
}
