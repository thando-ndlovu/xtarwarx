using Domain.Models;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Api.Queries.Search
{
	public interface ICharactersSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T BirthYears { get; set; }
		T BirthYearRangeLower { get; set; }
		T BirthYearRangeUpper { get; set; }
		T Description { get; set; }
		T EyeColors { get; set; }
		T HairColors { get; set; }
		T Heights { get; set; }
		T HeightRangeLower { get; set; }
		T HeightRangeUpper { get; set; }
		T HomeworldDescription { get; set; }
		T HomeworldName { get; set; }
		T Masses { get; set; }
		T MassRangeLower { get; set; }
		T MassRangeUpper { get; set; }
		T Name { get; set; }
		T Sexes { get; set; }
		T SkinColors { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(BirthYears)
				.Append(BirthYearRangeLower)
				.Append(BirthYearRangeUpper)
				.Append(Description)
				.Append(EyeColors)
				.Append(HairColors)
				.Append(Heights)
				.Append(HeightRangeLower)
				.Append(HeightRangeUpper)
				.Append(HomeworldDescription)
				.Append(HomeworldName)
				.Append(Masses)
				.Append(MassRangeLower)
				.Append(MassRangeUpper)
				.Append(Name)
				.Append(Sexes)
				.Append(SkinColors);
		}
	}
	public interface ICharactersSearchQuery : IStarWarsModelSearchQuery
	{
		double?[]? BirthYears { get; set; }
		double? BirthYearRangeLower { get; set; }
		double? BirthYearRangeUpper { get; set; }
		bool? Description { get; set; }
		string[]? EyeColors { get; set; }
		string[]? HairColors { get; set; }
		int?[]? Heights { get; set; }
		int? HeightRangeLower { get; set; }
		int? HeightRangeUpper { get; set; }
		bool? HomeworldDescription { get; set; }
		bool? HomeworldName { get; set; }
		double?[]? Masses { get; set; }
		double? MassRangeLower { get; set; }
		double? MassRangeUpper { get; set; }
		bool? Name { get; set; }
		string[]? Sexes { get; set; }
		string[]? SkinColors { get; set; }

		public bool ShouldSearchHomeworld()
		{
			return
				(HomeworldDescription ?? false) ||
				(HomeworldName ?? false);
		}

		public ICharacter.ISearch AsCharacterSearch(string? searchstring = null)
		{
			return new ICharacter.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new ICharacter.ISearchContainables.Default
				{
					Description = Description ?? false,
					Name = Name ?? false,
				},

				BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(default)
				{
					Lower = BirthYearRangeLower,
					Upper = BirthYearRangeUpper,
					Values = BirthYears,
				},

				EyeColors = EyeColors?
					.Select(_ => Enum.TryParse(_, true, out KnownColor color) ? color : new KnownColor?())
					.OfType<KnownColor>()
					.ToList(),
				HairColors = HairColors?
					.Select(_ => Enum.TryParse(_, true, out KnownColor color) ? color : new KnownColor?())
					.OfType<KnownColor>()
					.ToList(),

				Heights = new IStarWarsModel.ISearchValues.Default<int?>(default)
				{
					Lower = HeightRangeLower,
					Upper = HeightRangeUpper,
					Values = Heights,
				},

				Homeworld = new IPlanet.ISearchContainables.Default
				{
					Description = HomeworldDescription ?? false,
					Name = HomeworldName ?? false,
				},

				Masses = new IStarWarsModel.ISearchValues.Default<double?>(default)
				{
					Lower = MassRangeLower,
					Upper = MassRangeUpper,
					Values = Masses,
				},

				Sexes = Sexes?.ToList(),

				SkinColors = SkinColors?
					.Select(_ => Enum.TryParse(_, true, out KnownColor color) ? color : new KnownColor?())
					.OfType<KnownColor>()
					.ToList(),
			};
		}
		public IEnumerable<string> AsQueryData(ICharactersSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (BirthYears != null)
				querydata = querydata.Concat(BirthYears.Select(birthyear => string.Format("{0}={1}", keys?.BirthYears ?? nameof(BirthYears).ToLower(), birthyear)));

			if (BirthYearRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.BirthYearRangeLower ?? nameof(BirthYearRangeLower).ToLower(), BirthYearRangeLower.Value));

			if (BirthYearRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.BirthYearRangeUpper ?? nameof(SearchString).ToLower(), BirthYearRangeUpper.Value));

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (EyeColors != null)
				querydata = querydata.Concat(EyeColors.Select(eyecolor => string.Format("{0}={1}", keys?.EyeColors ?? nameof(EyeColors).ToLower(), eyecolor)));

			if (HairColors != null)
				querydata = querydata.Concat(HairColors.Select(haircolor => string.Format("{0}={1}", keys?.HairColors ?? nameof(HairColors).ToLower(), haircolor)));

			if (Heights != null)
				querydata = querydata.Concat(Heights.Select(height => string.Format("{0}={1}", keys?.Heights ?? nameof(Heights).ToLower(), height)));

			if (HeightRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HeightRangeLower ?? nameof(HeightRangeLower).ToLower(), HeightRangeLower.Value));

			if (HeightRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HeightRangeUpper ?? nameof(SearchString).ToLower(), HeightRangeUpper.Value));

			if (HomeworldDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HomeworldDescription ?? nameof(HomeworldDescription).ToLower(), HomeworldDescription.Value));

			if (HomeworldName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HomeworldName ?? nameof(HomeworldName).ToLower(), HomeworldName.Value));

			if (Masses != null)
				querydata = querydata.Concat(Masses.Select(mass => string.Format("{0}={1}", keys?.Masses ?? nameof(Masses).ToLower(), mass)));

			if (MassRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MassRangeLower ?? nameof(MassRangeLower).ToLower(), MassRangeLower.Value));

			if (MassRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MassRangeUpper ?? nameof(SearchString).ToLower(), MassRangeUpper.Value));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (Sexes != null)
				querydata = querydata.Concat(Sexes.Select(sex => string.Format("{0}={1}", keys?.Sexes ?? nameof(Sexes).ToLower(), sex)));

			if (SkinColors != null)
				querydata = querydata.Concat(SkinColors.Select(skincolor => string.Format("{0}={1}", keys?.SkinColors ?? nameof(SkinColors).ToLower(), skincolor)));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, ICharactersSearchQuery
		{
			public Default() : base() { }
			public Default(ICharacter.ISearch charactersearch) : base(charactersearch)
			{
				Description = charactersearch.SearchContainables?.Description;
				Name = charactersearch.SearchContainables?.Name;

				BirthYears = charactersearch.BirthYears?.Values?.ToArray();
				BirthYearRangeLower = charactersearch.BirthYears?.Lower;
				BirthYearRangeUpper = charactersearch.BirthYears?.Upper;

				EyeColors = charactersearch.EyeColors?
					.Select(_ => _.ToString())
					.ToArray();
				HairColors = charactersearch.HairColors?
					.Select(_ => _.ToString())
					.ToArray();

				Heights = charactersearch.Heights?.Values?.ToArray();
				HeightRangeLower = charactersearch.Heights?.Lower;
				HeightRangeUpper = charactersearch.Heights?.Upper;

				HomeworldDescription = charactersearch.Homeworld?.Description;
				HomeworldName = charactersearch.Homeworld?.Name;

				Masses = charactersearch.Masses?.Values?.ToArray();
				MassRangeLower = charactersearch.Masses?.Lower;
				MassRangeUpper = charactersearch.Masses?.Upper;

				Sexes = charactersearch.Sexes?.ToArray();

				SkinColors = charactersearch.SkinColors?
					.Select(_ => _.ToString())
					.ToArray();
			}

			public double?[]? BirthYears { get; set; }
			public double? BirthYearRangeLower { get; set; }
			public double? BirthYearRangeUpper { get; set; }
			public bool? Description { get; set; }
			public string[]? EyeColors { get; set; }
			public string[]? HairColors { get; set; }
			public int?[]? Heights { get; set; }
			public int? HeightRangeLower { get; set; }
			public int? HeightRangeUpper { get; set; }
			public bool? HomeworldDescription { get; set; }
			public bool? HomeworldName { get; set; }
			public double?[]? Masses { get; set; }
			public double? MassRangeLower { get; set; }
			public double? MassRangeUpper { get; set; }
			public bool? Name { get; set; }
			public string[]? Sexes { get; set; }
			public string[]? SkinColors { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, ICharactersSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				BirthYears = defaultvalue;
				BirthYearRangeLower = defaultvalue;
				BirthYearRangeUpper = defaultvalue;
				Description = defaultvalue;
				EyeColors = defaultvalue;
				HairColors = defaultvalue;
				Heights = defaultvalue;
				HeightRangeLower = defaultvalue;
				HeightRangeUpper = defaultvalue;
				HomeworldDescription = defaultvalue;
				HomeworldName = defaultvalue;
				Masses = defaultvalue;
				MassRangeLower = defaultvalue;
				MassRangeUpper = defaultvalue;
				Name = defaultvalue;
				Sexes = defaultvalue;
				SkinColors = defaultvalue;
			}
			public T BirthYears { get; set; }
			public T BirthYearRangeLower { get; set; }
			public T BirthYearRangeUpper { get; set; }
			public T Description { get; set; }
			public T EyeColors { get; set; }
			public T HairColors { get; set; }
			public T Heights { get; set; }
			public T HeightRangeLower { get; set; }
			public T HeightRangeUpper { get; set; }
			public T HomeworldDescription { get; set; }
			public T HomeworldName { get; set; }
			public T Masses { get; set; }
			public T MassRangeLower { get; set; }
			public T MassRangeUpper { get; set; }
			public T Name { get; set; }
			public T Sexes { get; set; }
			public T SkinColors { get; set; }
		}
	}
}
