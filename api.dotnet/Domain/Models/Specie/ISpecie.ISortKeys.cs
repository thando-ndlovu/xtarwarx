using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface ISpecie 
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T AverageHeight { get; set; }
			T AverageLifespan { get; set; }
			T CharacterCount { get; set; }
			T Classification { get; set; }
			T Designation { get; set; }
			T EyeColorsCount { get; set; }
			T HairColorsCount { get; set; }
			T Language { get; set; }
			T Name { get; set; }
			T SkinColorsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.AverageHeight => AverageHeight,
					ISortKeys.Keys.AverageLifespan => AverageLifespan,
					ISortKeys.Keys.CharacterCount => CharacterCount,
					ISortKeys.Keys.Classification => Classification,
					ISortKeys.Keys.Designation => Designation,
					ISortKeys.Keys.EyeColorsCount => EyeColorsCount,
					ISortKeys.Keys.HairColorsCount => HairColorsCount,
					ISortKeys.Keys.Language => Language,
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.SkinColorsCount => SkinColorsCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(AverageHeight), AverageHeight).AppendLine()
						.AppendFormat("{0}: {1}", nameof(AverageLifespan), AverageLifespan).AppendLine()
						.AppendFormat("{0}: {1}", nameof(CharacterCount), CharacterCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Classification), Classification).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Designation), Designation).AppendLine()
						.AppendFormat("{0}: {1}", nameof(EyeColorsCount), EyeColorsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(HairColorsCount), HairColorsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Language), Language).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
						.AppendFormat("{0}: {1}", nameof(SkinColorsCount), SkinColorsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string AverageHeight = "AverageHeight";
				public const string AverageLifespan = "AverageLifespan";
				public const string CharacterCount = "CharacterCount";
				public const string Classification = "Classification";
				public const string Designation = "Designation";
				public const string EyeColorsCount = "EyeColorsCount";
				public const string HairColorsCount = "HairColorsCount";
				public const string Language = "Language";
				public const string Name = "Name";
				public const string SkinColorsCount = "SkinColorsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(AverageHeight)
						.Append(AverageLifespan)
						.Append(CharacterCount)
						.Append(Classification)
						.Append(Designation)
						.Append(EyeColorsCount)
						.Append(HairColorsCount)
						.Append(Language)
						.Append(Name)
						.Append(SkinColorsCount);
				}
				public static IOrderedEnumerable<ISpecie> Sort(IEnumerable<ISpecie> species, params Sorter[] sorters)
				{
					IOrderedEnumerable<ISpecie>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(AverageHeight, false) => 
								ordered?.ThenBy(specie => specie.AverageHeight) ?? 
								species.OrderBy(specie => specie.AverageHeight),
							(AverageHeight, true) => 
								ordered?.ThenByDescending(specie => specie.AverageHeight) ?? 
								species.OrderByDescending(specie => specie.AverageHeight),

							(AverageLifespan, false) => 
								ordered?.ThenBy(specie => specie.AverageHeight) ?? 
								species.OrderBy(specie => specie.AverageHeight),
							(AverageLifespan, true) => 
								ordered?.ThenByDescending(specie => specie.AverageHeight) ?? 
								species.OrderByDescending(specie => specie.AverageHeight),

							(CharacterCount, false) => 
								ordered?.ThenBy(specie => specie.CharacterIds?.Count()) ?? 
								species.OrderBy(specie => specie.CharacterIds?.Count()),
							(CharacterCount, true) => 
								ordered?.ThenByDescending(specie => specie.CharacterIds?.Count()) ?? 
								species.OrderByDescending(specie => specie.CharacterIds?.Count()),

							(Classification, false) => 
								ordered?.ThenBy(specie => specie.Classification) ?? 
								species.OrderBy(specie => specie.Classification),
							(Classification, true) => 
								ordered?.ThenByDescending(specie => specie.Classification) ?? 
								species.OrderByDescending(specie => specie.Classification),

							(Designation, false) => 
								ordered?.ThenBy(specie => specie.Classification) ?? 
								species.OrderBy(specie => specie.Classification),
							(Designation, true) => 
								ordered?.ThenByDescending(specie => specie.Classification) ?? 
								species.OrderByDescending(specie => specie.Classification),

							(EyeColorsCount, false) => 
								ordered?.ThenBy(specie => specie.EyeColors?.Count()) ?? 
								species.OrderBy(specie => specie.EyeColors?.Count()),
							(EyeColorsCount, true) => 
								ordered?.ThenByDescending(specie => specie.EyeColors?.Count()) ?? 
								species.OrderByDescending(specie => specie.EyeColors?.Count()),

							(HairColorsCount, false) => 
								ordered?.ThenBy(specie => specie.HairColors?.Count()) ?? 
								species.OrderBy(specie => specie.HairColors?.Count()),
							(HairColorsCount, true) => 
								ordered?.ThenByDescending(specie => specie.HairColors?.Count()) ?? 
								species.OrderByDescending(specie => specie.HairColors?.Count()),

							(Language, false) => 
								ordered?.ThenBy(specie => specie.Language) ?? 
								species.OrderBy(specie => specie.Language),
							(Language, true) => 
								ordered?.ThenByDescending(specie => specie.Language) ?? 
								species.OrderByDescending(specie => specie.Language),

							(Name, false) => 
								ordered?.ThenBy(specie => specie.Name) ?? 
								species.OrderBy(specie => specie.Name),
							(Name, true) => 
								ordered?.ThenByDescending(specie => specie.Name) ?? 
								species.OrderByDescending(specie => specie.Name),

							(SkinColorsCount, false) => 
								ordered?.ThenBy(specie => specie.SkinColors?.Count()) ?? 
								species.OrderBy(specie => specie.SkinColors?.Count()),
							(SkinColorsCount, true) => 
								ordered?.ThenByDescending(specie => specie.SkinColors?.Count()) ?? 
								species.OrderByDescending(specie => specie.SkinColors?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? species, sorters),
						};

					return ordered ?? species.OrderBy(specie => specie);
				}
				public static IOrderedQueryable<ISpecie> Sort(IQueryable<ISpecie> species, params Sorter[] sorters)
				{
					IOrderedQueryable<ISpecie>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(AverageHeight, false) => 
								ordered?.ThenBy(specie => specie.AverageHeight) ?? 
								species.OrderBy(specie => specie.AverageHeight),
							(AverageHeight, true) => 
								ordered?.ThenByDescending(specie => specie.AverageHeight) ?? 
								species.OrderByDescending(specie => specie.AverageHeight),

							(AverageLifespan, false) => 
								ordered?.ThenBy(specie => specie.AverageHeight) ??
								species.OrderBy(specie => specie.AverageHeight),
							(AverageLifespan, true) => 
								ordered?.ThenByDescending(specie => specie.AverageHeight) ?? 
								species.OrderByDescending(specie => specie.AverageHeight),

							(CharacterCount, false) => 
								ordered?.ThenBy(specie => specie.CharacterIds != null ? specie.CharacterIds.Count() : 0) ?? 
								species.OrderBy(specie => specie.CharacterIds != null ? specie.CharacterIds.Count() : 0),
							(CharacterCount, true) => 
								ordered?.ThenByDescending(specie => specie.CharacterIds != null ? specie.CharacterIds.Count() : 0) ?? 
								species.OrderByDescending(specie => specie.CharacterIds != null ? specie.CharacterIds.Count() : 0),

							(Classification, false) => 
								ordered?.ThenBy(specie => specie.Classification) ?? 
								species.OrderBy(specie => specie.Classification),
							(Classification, true) => 
								ordered?.ThenByDescending(specie => specie.Classification) ?? 
								species.OrderByDescending(specie => specie.Classification),

							(Designation, false) => 
								ordered?.ThenBy(specie => specie.Classification) ?? 
								species.OrderBy(specie => specie.Classification),
							(Designation, true) => 
								ordered?.ThenByDescending(specie => specie.Classification) ?? 
								species.OrderByDescending(specie => specie.Classification),

							(EyeColorsCount, false) => 
								ordered?.ThenBy(specie => specie.EyeColors != null ? specie.EyeColors.Count() : 0) ?? 
								species.OrderBy(specie => specie.EyeColors != null ? specie.EyeColors.Count() : 0),
							(EyeColorsCount, true) => 
								ordered?.ThenByDescending(specie => specie.EyeColors != null ? specie.EyeColors.Count() : 0) ?? 
								species.OrderByDescending(specie => specie.EyeColors != null ? specie.EyeColors.Count() : 0),

							(HairColorsCount, false) => 
								ordered?.ThenBy(specie => specie.HairColors != null ? specie.HairColors.Count() : 0) ?? 
								species.OrderBy(specie => specie.HairColors != null ? specie.HairColors.Count() : 0),
							(HairColorsCount, true) => 
								ordered?.ThenByDescending(specie => specie.HairColors != null ? specie.HairColors.Count() : 0) ?? 
								species.OrderByDescending(specie => specie.HairColors != null ? specie.HairColors.Count() : 0),

							(Language, false) => 
								ordered?.ThenBy(specie => specie.Language) ?? 
								species.OrderBy(specie => specie.Language),
							(Language, true) => 
								ordered?.ThenByDescending(specie => specie.Language) ?? 
								species.OrderByDescending(specie => specie.Language),

							(Name, false) => 
								ordered?.ThenBy(specie => specie.Name) ?? 
								species.OrderBy(specie => specie.Name),
							(Name, true) => 
								ordered?.ThenByDescending(specie => specie.Name) ?? 
								species.OrderByDescending(specie => specie.Name),

							(SkinColorsCount, false) => 
								ordered?.ThenBy(specie => specie.SkinColors != null ? specie.SkinColors.Count() : 0) ?? 
								species.OrderBy(specie => specie.SkinColors != null ? specie.SkinColors.Count() : 0),
							(SkinColorsCount, true) => 
								ordered?.ThenByDescending(specie => specie.SkinColors != null ? specie.SkinColors.Count() : 0) ??
								species.OrderByDescending(specie => specie.SkinColors != null ? specie.SkinColors.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? species, sorters),
						};

					return ordered ?? species.OrderBy(specie => specie);
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
					AverageHeight = defaultvalue;
					AverageLifespan = defaultvalue;
					CharacterCount = defaultvalue;
					Classification = defaultvalue;
					Designation = defaultvalue;
					EyeColorsCount = defaultvalue;
					HairColorsCount = defaultvalue;
					Language = defaultvalue;
					Name = defaultvalue;
					SkinColorsCount = defaultvalue;
				}

				public T AverageHeight { get; set; }
				public T AverageLifespan { get; set; }
				public T CharacterCount { get; set; }
				public T Classification { get; set; }
				public T Designation { get; set; }
				public T EyeColorsCount { get; set; }
				public T HairColorsCount { get; set; }
				public T Language { get; set; }
				public T Name { get; set; }
				public T SkinColorsCount { get; set; }
			}
		}
	}
}
