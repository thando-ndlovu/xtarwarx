using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface ISpecie
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T AverageHeights { get; set; }
			T AverageLifespans { get; set; }
			T Characters { get; set; }
			T Classifications { get; set; }
			T Designations { get; set; }
			T EyeColors { get; set; }
			T HairColors { get; set; }
			T Homeworld { get; set; }
			T Languages { get; set; }
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

			ISearchValues<int?>? AverageHeights { get; set; }
			ISearchValues<int?>? AverageLifespans { get; set; }
			ICharacter.ISearchContainables? Characters { get; set; }
			IEnumerable<string>? Classifications { get; set; }
			IEnumerable<string>? Designations { get; set; }
			IEnumerable<KnownColor>? EyeColors { get; set; }
			IEnumerable<KnownColor>? HairColors { get; set; }
			IPlanet.ISearchContainables? Homeworld { get; set; }
			IEnumerable<string>? Languages { get; set; }
			IEnumerable<KnownColor>? SkinColors { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }

				public ISearchValues<int?>? AverageHeights { get; set; }
				public ISearchValues<int?>? AverageLifespans { get; set; }
				public ICharacter.ISearchContainables? Characters { get; set; }
				public IEnumerable<string>? Classifications { get; set; }
				public IEnumerable<string>? Designations { get; set; }
				public IEnumerable<KnownColor>? EyeColors { get; set; }
				public IEnumerable<KnownColor>? HairColors { get; set; }
				public IPlanet.ISearchContainables? Homeworld { get; set; }
				public IEnumerable<string>? Languages { get; set; }
				public IEnumerable<KnownColor>? SkinColors { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					AverageHeights = defaultvalue;
					AverageLifespans = defaultvalue;
					Characters = defaultvalue;
					Classifications = defaultvalue;
					Designations = defaultvalue;
					EyeColors = defaultvalue;
					HairColors = defaultvalue;
					Homeworld = defaultvalue;
					Languages = defaultvalue;
					SkinColors = defaultvalue;
				}

				public T AverageHeights { get; set; }
				public T AverageLifespans { get; set; }
				public T Characters { get; set; }
				public T Classifications { get; set; }
				public T Designations { get; set; }
				public T EyeColors { get; set; }
				public T HairColors { get; set; }
				public T Homeworld { get; set; }
				public T Languages { get; set; }
				public T SkinColors { get; set; }
			}

			public bool ShouldReturnSpecie(ISpecie specie)
			{
				if (SearchContainables?.ShouldReturnSpecie(specie, SearchString) ?? false)
					return true;

				if (AverageHeights is not null && AverageHeights.Search(specie.AverageHeight, out int _)) return true;
				if (AverageLifespans is not null && AverageLifespans.Search(specie.AverageLifespan, out int _)) return true;
				if (SearchDesignation(specie, out int _)) return true;
				if (SearchClassification(specie, out int _)) return true;
				if (SearchEyeColors(specie, out int _)) return true;
				if (SearchHairColors(specie, out int _)) return true;
				if (SearchLanguage(specie, out int _)) return true;
				if (SearchSkinColors(specie, out int _)) return true;

				return false;
			}
			public bool ShouldReturnSpecie(
				ISpecie specie,
				Func<IEnumerable<ICharacter>>? charactersFunc = null,
				Func<IPlanet?>? homeworldFunc = null)
			{
				if (ShouldReturnSpecie(specie))
					return true;

				if (Characters is not null && charactersFunc is not null)
					foreach (ICharacter character in charactersFunc.Invoke())
						if (Characters.ShouldReturnCharacter(character, SearchString))
							return true;

				if (Homeworld is not null && homeworldFunc is not null)
				{
					IPlanet? homeworld = homeworldFunc.Invoke();

					if (homeworld is not null && Homeworld.ShouldReturnPlanet(homeworld, SearchString))
						return true;
				}

				return false;
			}
			public async Task<bool> ShouldReturnSpecieAsync(
				ISpecie specie,
				Func<IAsyncEnumerable<ICharacter>>? charactersFunc = null,
				Func<Task<IPlanet?>>? homeworldFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnSpecie(specie))
					return true;

				if (Characters is not null && charactersFunc is not null)
					await foreach (ICharacter character in charactersFunc.Invoke().WithCancellation(cancellationToken))
						if (Characters.ShouldReturnCharacter(character, SearchString))
							return true;

				if (Homeworld is not null && homeworldFunc is not null)
				{
					IPlanet? homeworld = await homeworldFunc.Invoke();

					if (homeworld is not null && Homeworld.ShouldReturnPlanet(homeworld, SearchString))
						return true;
				}

				return false;
			}

			public int GetMatchCount(ISpecie specie)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnSpecie(specie, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (AverageHeights is not null && AverageHeights.Search(specie.AverageHeight, out int averageheightmatchcount)) matchcount += averageheightmatchcount;
				if (AverageLifespans is not null && AverageLifespans.Search(specie.AverageLifespan, out int averagelifespanmatchcount)) matchcount += averagelifespanmatchcount;
				SearchDesignation(specie, out int designationmatchcount); matchcount += designationmatchcount;
				SearchClassification(specie, out int classificationmatchcount); matchcount += classificationmatchcount;
				SearchEyeColors(specie, out int eyecolorsmatchcount); matchcount += eyecolorsmatchcount;
				SearchHairColors(specie, out int haircolorsmatchcount); matchcount += haircolorsmatchcount;
				SearchLanguage(specie, out int languagematchcount); matchcount += languagematchcount;
				SearchSkinColors(specie, out int skincolorsmatchcount); matchcount += skincolorsmatchcount;

				return matchcount;
			}
			public int GetMatchCount(
				ISpecie specie,
				Func<IEnumerable<ICharacter>>? charactersFunc = null,
				Func<IPlanet?>? homeworldFunc = null)
			{
				int matchcount = GetMatchCount(specie);

				if (Characters is not null && charactersFunc is not null)
					matchcount += charactersFunc.Invoke()
						.Select(character =>
						{
							Characters.ShouldReturnCharacter(character, SearchString, out int charactermatchcount);

							return charactermatchcount;

						}).Sum();

				if (Homeworld is not null && homeworldFunc?.Invoke() is IPlanet homeworld)
				{
					Homeworld.ShouldReturnPlanet(homeworld, SearchString, out int homeworldmatchcount); matchcount += homeworldmatchcount;
				}

				return matchcount;
			}
			public async Task<int> GetMatchCountAsync(
				ISpecie specie,
				Func<IAsyncEnumerable<ICharacter>>? charactersFunc = null,
				Func<Task<IPlanet?>>? homeworldFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(specie);

				if (Characters is not null && charactersFunc is not null)
					await foreach (ICharacter character in charactersFunc.Invoke().WithCancellation(cancellationToken))
					{
						Characters.ShouldReturnCharacter(character, SearchString, out int charactermatchcount); matchcount += charactermatchcount;
					}

				if (Homeworld is not null && homeworldFunc?.Invoke() is Task<IPlanet?> homeworldTask && await homeworldTask is IPlanet homeworld)
				{
					Homeworld.ShouldReturnPlanet(homeworld, SearchString, out int homeworldmatchcount); matchcount += homeworldmatchcount;
				}

				return matchcount;
			}

			private bool SearchDesignation(ISpecie specie, out int matchCount)
			{
				matchCount = 0;

				if (Designations == null || string.IsNullOrWhiteSpace(specie.Designation))
					return false;

				if (Designations.Contains(specie.Designation))
					matchCount++;

				return matchCount > 0;
			}
			private bool SearchClassification(ISpecie specie, out int matchCount)
			{
				matchCount = 0;

				if (Classifications == null || string.IsNullOrWhiteSpace(specie.Classification))
					return false;

				if (Classifications.Contains(specie.Classification))
					matchCount++;

				return matchCount > 0;
			}
			private bool SearchEyeColors(ISpecie specie, out int matchCount)
			{
				matchCount = 0;

				if (EyeColors == null || specie.EyeColors == null)
					return false;

				foreach (KnownColor eyecolor in specie.EyeColors)
					if (EyeColors.Contains(eyecolor))
						matchCount++;

				return matchCount > 0;
			}
			private bool SearchHairColors(ISpecie specie, out int matchCount)
			{
				matchCount = 0;

				if (HairColors == null || specie.HairColors == null)
					return false;

				foreach (KnownColor haircolor in specie.HairColors)
					if (HairColors.Contains(haircolor))
						matchCount++;

				return matchCount > 0;
			}
			private bool SearchLanguage(ISpecie specie, out int matchCount)
			{
				matchCount = 0;

				if (Languages == null || string.IsNullOrWhiteSpace(specie.Language))
					return false;

				if (Languages.Contains(specie.Language))
					matchCount++;

				return matchCount > 0;
			}
			private bool SearchSkinColors(ISpecie specie, out int matchCount)
			{
				matchCount = 0;

				if (SkinColors == null || specie.SkinColors == null)
					return false;

				foreach (KnownColor skincolor in specie.SkinColors)
					if (SkinColors.Contains(skincolor))
						matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class SpecieSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, ISpecie.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.AverageHeights), search.AverageHeights).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.AverageLifespans), search.AverageLifespans).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.Characters), search.Characters).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.Classifications), search.Classifications).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.Designations), search.Designations).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.EyeColors), search.EyeColors).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.HairColors), search.HairColors).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.Homeworld), search.Homeworld).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.Languages), search.Languages).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ISpecie.ISearch<T>.SkinColors), search.SkinColors).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, ISpecie.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(ISpecie.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			stringbuilder
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.AverageHeights)).AppendLine().Append(search.AverageHeights)
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.AverageLifespans)).AppendLine().Append(search.AverageLifespans);

			if (search.Characters is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(ISpecie.ISearch.Characters)).AppendLine()
					.Append(search.Characters).AppendLine();

			stringbuilder
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.Classifications)).AppendJoin(", ", search.Classifications ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.Designations)).AppendJoin(", ", search.Designations ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.EyeColors)).AppendJoin(", ", search.EyeColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.HairColors)).AppendJoin(", ", search.HairColors ?? Enumerable.Empty<KnownColor>()).AppendLine();

			if (search.Homeworld is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(ISpecie.ISearch.Homeworld)).AppendLine()
					.Append(search.Homeworld).AppendLine();

			stringbuilder
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.Languages)).AppendJoin(", ", search.Languages ?? Enumerable.Empty<string>()).AppendLine()
				.AppendFormat("{0}: ", nameof(ISpecie.ISearch.SkinColors)).AppendJoin(", ", search.SkinColors ?? Enumerable.Empty<KnownColor>()).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
