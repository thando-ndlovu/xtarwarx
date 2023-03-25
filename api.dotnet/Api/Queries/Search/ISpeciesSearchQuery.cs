using Domain.Models;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Api.Queries.Search
{
	public interface ISpeciesSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T AverageHeights { get; set; }
		T AverageHeightRangeLower { get; set; }
		T AverageHeightRangeUpper { get; set; }
		T AverageLifespans { get; set; }
		T AverageLifespanRangeLower { get; set; }
		T AverageLifespanRangeUpper { get; set; }
		T CharactersDescription { get; set; }
		T CharactersName { get; set; }
		T Classifications { get; set; }
		T Description { get; set; }
		T Designations { get; set; }
		T EyeColors { get; set; }
		T HairColors { get; set; }
		T HomeworldDescription { get; set; }
		T HomeworldName { get; set; }
		T Languages { get; set; }
		T Name { get; set; }
		T SkinColors { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(AverageHeights)
				.Append(AverageHeightRangeLower)
				.Append(AverageHeightRangeUpper)
				.Append(AverageLifespans)
				.Append(AverageLifespanRangeLower)
				.Append(AverageLifespanRangeUpper)
				.Append(CharactersDescription)
				.Append(CharactersName)
				.Append(Classifications)
				.Append(Description)
				.Append(Designations)
				.Append(EyeColors)
				.Append(HairColors)
				.Append(HomeworldDescription)
				.Append(HomeworldName)
				.Append(Languages)
				.Append(Name)
				.Append(SkinColors);
		}
	}
	public interface ISpeciesSearchQuery : IStarWarsModelSearchQuery
	{
		int?[]? AverageHeights { get; set; }
		int? AverageHeightRangeLower { get; set; }
		int? AverageHeightRangeUpper { get; set; }
		int?[]? AverageLifespans { get; set; }
		int? AverageLifespanRangeLower { get; set; }
		int? AverageLifespanRangeUpper { get; set; }
		bool? CharactersDescription { get; set; }
		bool? CharactersName { get; set; }
		string[]? Classifications { get; set; }
		bool? Description { get; set; }
		string[]? Designations { get; set; }
		string[]? EyeColors { get; set; }
		string[]? HairColors { get; set; }
		bool? HomeworldDescription { get; set; }
		bool? HomeworldName { get; set; }
		string[]? Languages { get; set; }
		bool? Name { get; set; }
		string[]? SkinColors { get; set; }

		public bool ShouldSearchCharacters()
		{
			return
				(CharactersDescription ?? false) ||
				(CharactersName ?? false);
		}
		public bool ShouldSearchHomeworld()
		{
			return
				(HomeworldDescription ?? false) ||
				(HomeworldName ?? false);
		}

		public ISpecie.ISearch AsSpecieSearch(string? searchstring = null)
		{
			return new ISpecie.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new ISpecie.ISearchContainables.Default
				{
					Description = Description ?? false,
					Name = Name ?? false,
				},

				AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(default)
				{
					Lower = AverageHeightRangeLower,
					Upper = AverageHeightRangeUpper,
					Values = AverageHeights,
				},

				AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(default)
				{
					Lower = AverageLifespanRangeLower,
					Upper = AverageLifespanRangeUpper,
					Values = AverageLifespans,
				},

				Characters = new ICharacter.ISearchContainables.Default
				{
					Description = CharactersDescription ?? false,
					Name = CharactersName ?? false,
				},

				Classifications = Classifications?.ToList(),

				Designations = Designations?.ToList(),

				EyeColors = EyeColors?
					.Select(_ => Enum.TryParse(_, true, out KnownColor color) ? color : new KnownColor?())
					.OfType<KnownColor>()
					.ToList(),

				HairColors = HairColors?
					.Select(_ => Enum.TryParse(_, true, out KnownColor color) ? color : new KnownColor?())
					.OfType<KnownColor>()
					.ToList(),

				Homeworld = new IPlanet.ISearchContainables.Default
				{
					Description = HomeworldDescription ?? false,
					Name = HomeworldName ?? false,
				},

				Languages = Languages?.ToList(),

				SkinColors = SkinColors?
					.Select(_ => Enum.TryParse(_, true, out KnownColor color) ? color : new KnownColor?())
					.OfType<KnownColor>()
					.ToList(),
			};
		}
		public IEnumerable<string> AsQueryData(ISpeciesSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (AverageHeights != null)
				querydata = querydata.Concat(AverageHeights.Select(averageheight => string.Format("{0}={1}", keys?.AverageHeights ?? nameof(AverageHeights).ToLower(), averageheight)));

			if (AverageHeightRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AverageHeightRangeLower ?? nameof(AverageHeightRangeLower).ToLower(), AverageHeightRangeLower.Value));

			if (AverageHeightRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AverageHeightRangeUpper ?? nameof(SearchString).ToLower(), AverageHeightRangeUpper.Value));

			if (AverageLifespans != null)
				querydata = querydata.Concat(AverageLifespans.Select(averagelifespan => string.Format("{0}={1}", keys?.AverageLifespans ?? nameof(AverageLifespans).ToLower(), averagelifespan)));

			if (AverageLifespanRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AverageLifespanRangeLower ?? nameof(AverageLifespanRangeLower).ToLower(), AverageLifespanRangeLower.Value));

			if (AverageLifespanRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AverageLifespanRangeUpper ?? nameof(AverageLifespanRangeUpper).ToLower(), AverageLifespanRangeUpper.Value));

			if (CharactersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CharactersDescription ?? nameof(CharactersDescription).ToLower(), CharactersDescription.Value));

			if (CharactersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CharactersName ?? nameof(CharactersName).ToLower(), CharactersName.Value));

			if (Classifications != null)
				querydata = querydata.Concat(Classifications.Select(classification => string.Format("{0}={1}", keys?.Classifications ?? nameof(Classifications).ToLower(), classification)));

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (Designations != null)
				querydata = querydata.Concat(Designations.Select(designation => string.Format("{0}={1}", keys?.Designations ?? nameof(Designations).ToLower(), designation)));

			if (EyeColors != null)
				querydata = querydata.Concat(EyeColors.Select(eyecolor => string.Format("{0}={1}", keys?.EyeColors ?? nameof(EyeColors).ToLower(), eyecolor)));

			if (HairColors != null)
				querydata = querydata.Concat(HairColors.Select(haircolor => string.Format("{0}={1}", keys?.HairColors ?? nameof(HairColors).ToLower(), haircolor)));

			if (HomeworldDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HomeworldDescription ?? nameof(HomeworldDescription).ToLower(), HomeworldDescription.Value));

			if (HomeworldName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HomeworldName ?? nameof(HomeworldName).ToLower(), HomeworldName.Value));

			if (Languages != null)
				querydata = querydata.Concat(Languages.Select(language => string.Format("{0}={1}", keys?.Languages ?? nameof(Languages).ToLower(), language)));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (SkinColors != null)
				querydata = querydata.Concat(SkinColors.Select(skincolor => string.Format("{0}={1}", keys?.SkinColors ?? nameof(SkinColors).ToLower(), skincolor)));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, ISpeciesSearchQuery
		{
			public Default() : base() { }
			public Default(ISpecie.ISearch speciesearch) : base(speciesearch)
			{
				Description = speciesearch.SearchContainables?.Description;
				Name = speciesearch.SearchContainables?.Name;

				AverageHeights = speciesearch.AverageHeights?.Values?.ToArray();
				AverageHeightRangeLower = speciesearch.AverageHeights?.Lower;
				AverageHeightRangeUpper = speciesearch.AverageHeights?.Upper;

				AverageLifespans = speciesearch.AverageLifespans?.Values?.ToArray();
				AverageLifespanRangeLower = speciesearch.AverageLifespans?.Lower;
				AverageLifespanRangeUpper = speciesearch.AverageLifespans?.Upper;

				CharactersDescription = speciesearch.Characters?.Description;
				CharactersName = speciesearch.Characters?.Name;

				Classifications = speciesearch.Classifications?.ToArray();

				Designations = speciesearch.Designations?.ToArray();

				EyeColors = speciesearch.EyeColors?
					.Select(_ => _.ToString())
					.ToArray();

				HairColors = speciesearch.HairColors?
					.Select(_ => _.ToString())
					.ToArray();

				HomeworldDescription = speciesearch.Homeworld?.Description;
				HomeworldName = speciesearch.Homeworld?.Name;

				Languages = speciesearch.Languages?.ToArray();

				SkinColors = speciesearch.SkinColors?
					.Select(_ => _.ToString())
					.ToArray();
			}

			public int?[]? AverageHeights { get; set; }
			public int? AverageHeightRangeLower { get; set; }
			public int? AverageHeightRangeUpper { get; set; }
			public int?[]? AverageLifespans { get; set; }
			public int? AverageLifespanRangeLower { get; set; }
			public int? AverageLifespanRangeUpper { get; set; }
			public bool? CharactersDescription { get; set; }
			public bool? CharactersName { get; set; }
			public string[]? Classifications { get; set; }
			public bool? Description { get; set; }
			public string[]? Designations { get; set; }
			public string[]? EyeColors { get; set; }
			public string[]? HairColors { get; set; }
			public bool? HomeworldDescription { get; set; }
			public bool? HomeworldName { get; set; }
			public string[]? Languages { get; set; }
			public bool? Name { get; set; }
			public string[]? SkinColors { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, ISpeciesSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				AverageHeights = defaultvalue;
				AverageHeightRangeLower = defaultvalue;
				AverageHeightRangeUpper = defaultvalue;
				AverageLifespans = defaultvalue;
				AverageLifespanRangeLower = defaultvalue;
				AverageLifespanRangeUpper = defaultvalue;
				CharactersDescription = defaultvalue;
				CharactersName = defaultvalue;
				Classifications = defaultvalue;
				Description = defaultvalue;
				Designations = defaultvalue;
				EyeColors = defaultvalue;
				HairColors = defaultvalue;
				HomeworldDescription = defaultvalue;
				HomeworldName = defaultvalue;
				Languages = defaultvalue;
				Name = defaultvalue;
				SkinColors = defaultvalue;
			}

			public T AverageHeights { get; set; }
			public T AverageHeightRangeLower { get; set; }
			public T AverageHeightRangeUpper { get; set; }
			public T AverageLifespans { get; set; }
			public T AverageLifespanRangeLower { get; set; }
			public T AverageLifespanRangeUpper { get; set; }
			public T CharactersDescription { get; set; }
			public T CharactersName { get; set; }
			public T Classifications { get; set; }
			public T Description { get; set; }
			public T Designations { get; set; }
			public T EyeColors { get; set; }
			public T HairColors { get; set; }
			public T HomeworldDescription { get; set; }
			public T HomeworldName { get; set; }
			public T Languages { get; set; }
			public T Name { get; set; }
			public T SkinColors { get; set; }
		}
	}
}
