using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface ICharacter
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T BirthYears { get; set; }
			T EyeColors { get; set; }
			T HairColors { get; set; }
			T Heights { get; set; }
			T Homeworld { get; set; }
			T Masses { get; set; }
			T Sexes { get; set; }
			T SkinColors { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearch : IStarWarsModel.ISearch
		{
			new ISearchContainables? SearchContainables { get; set; }

			ISearchValues<double?>? BirthYears { get; set; }
			IEnumerable<KnownColor>? EyeColors { get; set; }
			IEnumerable<KnownColor>? HairColors { get; set; }
			ISearchValues<int?>? Heights { get; set; }
			IPlanet.ISearchContainables? Homeworld { get; set; }
			ISearchValues<double?>? Masses { get; set; }
			IEnumerable<string>? Sexes { get; set; }
			IEnumerable<KnownColor>? SkinColors { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new ICharacter.ISearchContainables? SearchContainables { get; set; }

				public ISearchValues<double?>? BirthYears { get; set; }
				public IEnumerable<KnownColor>? EyeColors { get; set; }
				public IEnumerable<KnownColor>? HairColors { get; set; }
				public ISearchValues<int?>? Heights { get; set; }
				public IPlanet.ISearchContainables? Homeworld { get; set; }
				public ISearchValues<double?>? Masses { get; set; }
				public IEnumerable<string>? Sexes { get; set; }
				public IEnumerable<KnownColor>? SkinColors { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					BirthYears = defaultvalue;
					EyeColors = defaultvalue;
					HairColors = defaultvalue;
					Heights = defaultvalue;
					Homeworld = defaultvalue;
					Masses = defaultvalue;
					Sexes = defaultvalue;
					SkinColors = defaultvalue;
				}

				public T BirthYears { get; set; }
				public T EyeColors { get; set; }
				public T HairColors { get; set; }
				public T Heights { get; set; }
				public T Homeworld { get; set; }
				public T Masses { get; set; }
				public T Sexes { get; set; }
				public T SkinColors { get; set; }
			}

			public bool ShouldReturnCharacter(ICharacter character)
			{
				if (SearchContainables?.ShouldReturnCharacter(character, SearchString) ?? false)
					return true;

				if (BirthYears?.Search(character.BirthYear, out int _) ?? false) return true;
				if (SearchEyeColors(character, out int _)) return true;
				if (SearchHairColors(character, out int _)) return true;
				if (Heights?.Search(character.Height, out int _) ?? false) return true;
				if (Masses?.Search(character.Mass, out int _) ?? false) return true;
				if (SearchSex(character, out int _)) return true;
				if (SearchSkinColors(character, out int _)) return true;

				return false;
			}
			public bool ShouldReturnCharacter(ICharacter character, Func<IPlanet?>? homeworldFunc = null)
			{
				if (ShouldReturnCharacter(character))
					return true;

				if (Homeworld is not null && homeworldFunc is not null)
				{
					IPlanet? homeworld = homeworldFunc.Invoke();

					if (homeworld is not null && Homeworld.ShouldReturnPlanet(homeworld, SearchString))
						return true;
				}

				return false;
			}
			public async Task<bool> ShouldReturnCharacterAsync(ICharacter character, Func<Task<IPlanet?>>? homeworldFunc = null, CancellationToken cancellationToken = default)
			{
				if (ShouldReturnCharacter(character))
					return true;

				if (Homeworld is not null && homeworldFunc?.Invoke() is Task<IPlanet?> homeworldTask && await homeworldTask is IPlanet homeworld && Homeworld.ShouldReturnPlanet(homeworld, SearchString))
					return true;

				return false;
			}

			public int GetMatchCount(ICharacter character)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnCharacter(character, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (BirthYears is not null && BirthYears.Search(character.BirthYear, out int birthyearmatchcount)) matchcount += birthyearmatchcount;
				SearchEyeColors(character, out int eyecolorsmatchcount); matchcount += eyecolorsmatchcount;
				SearchHairColors(character, out int haircolorsmatchcount); matchcount += haircolorsmatchcount;
				if (Heights is not null && Heights.Search(character.Height, out int heightmatchcount)) matchcount += heightmatchcount;
				if (Masses is not null && Masses.Search(character.Mass, out int massmatchcount)) matchcount += massmatchcount;
				SearchSex(character, out int sexmatchcount); matchcount += sexmatchcount;
				SearchSkinColors(character, out int skincolorsmatchcount); matchcount += skincolorsmatchcount;

				return matchcount;
			}
			public int GetMatchCount(ICharacter character, Func<IPlanet?>? homeworldFunc = null)
			{
				int matchcount = GetMatchCount(character);

				if (Homeworld is not null && homeworldFunc?.Invoke() is IPlanet homeworld)
				{
					Homeworld.ShouldReturnPlanet(homeworld, SearchString, out int homeworldmatchcount); matchcount += homeworldmatchcount;
				}

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(ICharacter character, Func<Task<IPlanet?>>? homeworldFunc = null, CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(character);

				if (Homeworld is not null && homeworldFunc?.Invoke() is Task<IPlanet?> homeworldTask && await homeworldTask is IPlanet homeworld)
				{
					Homeworld.ShouldReturnPlanet(homeworld, SearchString, out int homeworldmatchcount); matchcount += homeworldmatchcount;
				}

				return matchcount;
			}

			private bool SearchEyeColors(ICharacter character, out int matchCount)
			{
				matchCount = 0;

				if (EyeColors == null || character.EyeColors == null)
					return false;

				foreach (KnownColor eyecolor in character.EyeColors)
					if (EyeColors.Contains(eyecolor))
						matchCount++;

				return matchCount > 0;
			}
			private bool SearchHairColors(ICharacter character, out int matchCount)
			{
				matchCount = 0;

				if (HairColors == null || character.HairColors == null)
					return false;

				foreach (KnownColor haircolor in character.HairColors)
					if (HairColors.Contains(haircolor))
						matchCount++;

				return matchCount > 0;
			}
			private bool SearchSex(ICharacter character, out int matchCount)
			{
				matchCount = 0;

				if (Sexes == null || string.IsNullOrWhiteSpace(character.Sex))
					return false;

				if (Sexes.Contains(character.Sex))
					matchCount++;

				return matchCount > 0;
			}
			private bool SearchSkinColors(ICharacter character, out int matchCount)
			{
				matchCount = 0;

				if (SkinColors == null || character.SkinColors == null)
					return false;

				foreach (KnownColor skincolor in character.SkinColors)
					if (SkinColors.Contains(skincolor))
						matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class CharacterSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, ICharacter.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.BirthYears), search.BirthYears).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.EyeColors), search.EyeColors).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.HairColors), search.HairColors).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.Heights), search.Heights).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.Homeworld), search.Homeworld).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.Masses), search.Masses).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.Sexes), search.Sexes).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ICharacter.ISearch<T>.SkinColors), search.SkinColors).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, ICharacter.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(ICharacter.ISearch.SearchContainables)).AppendLine().Append(search.SearchContainables);

			stringbuilder
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.BirthYears)).Append(search.BirthYears).AppendLine()
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.EyeColors)).AppendJoin(", ", search.EyeColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.HairColors)).AppendJoin(", ", search.HairColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.Heights)).Append(search.Heights).AppendLine()
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.Homeworld)).AppendLine().Append(search.Homeworld)
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.Masses)).Append(search.Masses).AppendLine()
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.Sexes)).AppendJoin(", ", search.Sexes ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ICharacter.ISearch.SkinColors)).AppendJoin(", ", search.SkinColors ?? Enumerable.Empty<KnownColor>()).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
