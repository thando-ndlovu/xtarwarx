using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface ICharacter 
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T BirthYear { get; set; }
			T EyeColorsCount { get; set; }
			T HairColorsCount { get; set; }
			T Height { get; set; }
			T Mass { get; set; }
			T Name { get; set; }
			T Sex { get; set; }
			T SkinColorsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.BirthYear => BirthYear,
					ISortKeys.Keys.EyeColorsCount => EyeColorsCount,
					ISortKeys.Keys.HairColorsCount => HairColorsCount,
					ISortKeys.Keys.Height => Height,
					ISortKeys.Keys.Mass => Mass,
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.Sex => Sex,
					ISortKeys.Keys.SkinColorsCount => SkinColorsCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(BirthYear), BirthYear).AppendLine()
						.AppendFormat("{0}: {1}", nameof(EyeColorsCount), EyeColorsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(HairColorsCount), HairColorsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Height), Height).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Mass), Mass).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Sex), Sex).AppendLine()
						.AppendFormat("{0}: {1}", nameof(SkinColorsCount), SkinColorsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string BirthYear = "BirthYear";
				public const string EyeColorsCount = "EyeColorsCount";
				public const string HairColorsCount = "HairColorsCount";
				public const string Height = "Height";
				public const string Mass = "Mass";
				public const string Name = "Name";
				public const string Sex = "Sex";
				public const string SkinColorsCount = "SkinColorsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(BirthYear)
						.Append(EyeColorsCount)
						.Append(HairColorsCount)
						.Append(Height)
						.Append(Mass)
						.Append(Name)
						.Append(Sex)
						.Append(SkinColorsCount);
				}
				public static IOrderedEnumerable<ICharacter> Sort(IEnumerable<ICharacter> characters, params Sorter[] sorters)
				{
					IOrderedEnumerable<ICharacter>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(BirthYear, false) => ordered?.OrderBy(character => character.BirthYear) ?? characters.OrderBy(character => character.BirthYear),
							(BirthYear, true) => ordered?.OrderByDescending(character => character.BirthYear) ?? characters.OrderByDescending(character => character.BirthYear),

							(EyeColorsCount, false) => ordered?.OrderBy(character => character.EyeColors?.Count()) ?? characters.OrderBy(character => character.EyeColors?.Count()),
							(EyeColorsCount, true) => ordered?.OrderByDescending(character => character.EyeColors?.Count()) ?? characters.OrderByDescending(character => character.EyeColors?.Count()),

							(HairColorsCount, false) => ordered?.OrderBy(character => character.HairColors?.Count()) ?? characters.OrderBy(character => character.HairColors?.Count()),
							(HairColorsCount, true) => ordered?.OrderByDescending(character => character.HairColors?.Count()) ?? characters.OrderByDescending(character => character.HairColors?.Count()),

							(Height, false) => ordered?.OrderBy(character => character.Height) ?? characters.OrderBy(character => character.Height),
							(Height, true) => ordered?.OrderByDescending(character => character.Height) ?? characters.OrderByDescending(character => character.Height),

							(Mass, false) => ordered?.OrderBy(character => character.Mass) ?? characters.OrderBy(character => character.Mass),
							(Mass, true) => ordered?.OrderByDescending(character => character.Mass) ?? characters.OrderByDescending(character => character.Mass),

							(Name, false) => ordered?.OrderBy(character => character.Name) ?? characters.OrderBy(character => character.Name),
							(Name, true) => ordered?.OrderByDescending(character => character.Name) ?? characters.OrderByDescending(character => character.Name),

							(Sex, false) => ordered?.OrderBy(character => character.Sex) ?? characters.OrderBy(character => character.Sex),
							(Sex, true) => ordered?.OrderByDescending(character => character.Sex) ?? characters.OrderByDescending(character => character.Sex),

							(SkinColorsCount, false) => ordered?.OrderBy(character => character.SkinColors?.Count()) ?? characters.OrderBy(character => character.SkinColors?.Count()),
							(SkinColorsCount, true) => ordered?.OrderByDescending(character => character.SkinColors?.Count()) ?? characters.OrderByDescending(character => character.SkinColors?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? characters, sorters),
						};

					return ordered ?? characters.OrderBy(character => character);
				}
				public static IOrderedQueryable<ICharacter> Sort(IQueryable<ICharacter> characters, params Sorter[] sorters)
				{
					IOrderedQueryable<ICharacter>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(BirthYear, false) => 
								ordered?.OrderBy(character => character.BirthYear) ??
								characters.OrderBy(character => character.BirthYear),
							(BirthYear, true) => 
								ordered?.OrderByDescending(character => character.BirthYear) ??
								characters.OrderByDescending(character => character.BirthYear),

							(EyeColorsCount, false) => 
								ordered?.OrderBy(character => character.EyeColors != null ? character.EyeColors.Count() : 0) ??
								characters.OrderBy(character => character.EyeColors != null ? character.EyeColors.Count() : 0),
							(EyeColorsCount, true) => 
								ordered?.OrderByDescending(character => character.EyeColors != null ? character.EyeColors.Count() : 0) ??
								characters.OrderByDescending(character => character.EyeColors != null ? character.EyeColors.Count() : 0),

							(HairColorsCount, false) => 
								ordered?.OrderBy(character => character.HairColors != null ? character.HairColors.Count() : 0) ??
								characters.OrderBy(character => character.HairColors != null ? character.HairColors.Count() : 0),
							(HairColorsCount, true) => 
								ordered?.OrderByDescending(character => character.HairColors != null ? character.HairColors.Count() : 0) ??
								characters.OrderByDescending(character => character.HairColors != null ? character.HairColors.Count() : 0),

							(Height, false) => 
								ordered?.OrderBy(character => character.Height) ??
								characters.OrderBy(character => character.Height),
							(Height, true) => 
								ordered?.OrderByDescending(character => character.Height) ??
								characters.OrderByDescending(character => character.Height),

							(Mass, false) => 
								ordered?.OrderBy(character => character.Mass) ??
								characters.OrderBy(character => character.Mass),
							(Mass, true) => 
								ordered?.OrderByDescending(character => character.Mass) ??
								characters.OrderByDescending(character => character.Mass),

							(Name, false) => 
								ordered?.OrderBy(character => character.Name) ??
								characters.OrderBy(character => character.Name),
							(Name, true) => 
								ordered?.OrderByDescending(character => character.Name) ??
								characters.OrderByDescending(character => character.Name),

							(Sex, false) => 
								ordered?.OrderBy(character => character.Sex) ??
								characters.OrderBy(character => character.Sex),
							(Sex, true) => 
								ordered?.OrderByDescending(character => character.Sex) ??
								characters.OrderByDescending(character => character.Sex),

							(SkinColorsCount, false) => 
								ordered?.OrderBy(character => character.SkinColors != null ? character.SkinColors.Count() : 0) ??
								characters.OrderBy(character => character.SkinColors != null ? character.SkinColors.Count() : 0),
							(SkinColorsCount, true) => 
								ordered?.OrderByDescending(character => character.SkinColors != null ? character.SkinColors.Count() : 0) ?? 
								characters.OrderByDescending(character => character.SkinColors != null ? character.SkinColors.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? characters, sorters),
						};

					return ordered ?? characters.OrderBy(character => character);
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
					BirthYear = defaultvalue;
					EyeColorsCount = defaultvalue;
					HairColorsCount = defaultvalue;
					Height = defaultvalue;
					Mass = defaultvalue;
					Name = defaultvalue;
					Sex = defaultvalue;
					SkinColorsCount = defaultvalue;
				}

				public T BirthYear { get; set; }
				public T EyeColorsCount { get; set; }
				public T HairColorsCount { get; set; }
				public T Height { get; set; }
				public T Mass { get; set; }
				public T Name { get; set; }
				public T Sex { get; set; }
				public T SkinColorsCount { get; set; }
			}
		}
	}
}
