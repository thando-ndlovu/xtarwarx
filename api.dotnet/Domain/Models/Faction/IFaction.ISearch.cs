using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IFaction
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T AlliedCharacters { get; set; }
			T AlliedFactions { get; set; }
			T Leaders { get; set; }
			T MemberCharacters { get; set; }
			T MemberFactions { get; set; }

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

			ICharacter.ISearchContainables? AlliedCharacters { get; set; }
			ISearchContainables? AlliedFactions { get; set; }
			ICharacter.ISearchContainables? Leaders { get; set; }
			ICharacter.ISearchContainables? MemberCharacters { get; set; }
			ISearchContainables? MemberFactions { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new ISearchContainables? SearchContainables { get; set; }

				public ICharacter.ISearchContainables? AlliedCharacters { get; set; }
				public ISearchContainables? AlliedFactions { get; set; }
				public ICharacter.ISearchContainables? Leaders { get; set; }
				public ICharacter.ISearchContainables? MemberCharacters { get; set; }
				public ISearchContainables? MemberFactions { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					AlliedCharacters = defaultvalue;
					AlliedFactions = defaultvalue;
					Leaders = defaultvalue;
					MemberCharacters = defaultvalue;
					MemberFactions = defaultvalue;
				}

				public T AlliedCharacters { get; set; }
				public T AlliedFactions { get; set; }
				public T Leaders { get; set; }
				public T MemberCharacters { get; set; }
				public T MemberFactions { get; set; }
			}

			public bool ShouldReturnFaction(IFaction faction)
			{
				if (SearchContainables?.ShouldReturnFaction(faction, SearchString) ?? false) return true;

				return false;
			}
			public bool ShouldReturnFaction(
				IFaction faction,
				Func<IEnumerable<ICharacter>>? alliedCharactersFunc = null,
				Func<IEnumerable<IFaction>>? alliedFactionsFunc = null,
				Func<IEnumerable<ICharacter>>? leadersFunc = null,
				Func<IEnumerable<ICharacter>>? memberCharactersFunc = null,
				Func<IEnumerable<IFaction>>? memberFactionsFunc = null)
			{
				if (ShouldReturnFaction(faction))
					return true;

				if (AlliedCharacters is not null && alliedCharactersFunc is not null)
					foreach (ICharacter alliedCharacter in alliedCharactersFunc.Invoke())
						if (AlliedCharacters.ShouldReturnCharacter(alliedCharacter, SearchString))
							return true;

				if (AlliedFactions is not null && alliedFactionsFunc is not null)
					foreach (IFaction alliedFaction in alliedFactionsFunc.Invoke())
						if (AlliedFactions.ShouldReturnFaction(alliedFaction, SearchString))
							return true;

				if (Leaders is not null && leadersFunc is not null)
					foreach (ICharacter leader in leadersFunc.Invoke())
						if (Leaders.ShouldReturnCharacter(leader, SearchString))
							return true;

				if (MemberCharacters is not null && memberCharactersFunc is not null)
					foreach (ICharacter memberCharacter in memberCharactersFunc.Invoke())
						if (MemberCharacters.ShouldReturnCharacter(memberCharacter, SearchString))
							return true;

				if (MemberFactions is not null && memberFactionsFunc is not null)
					foreach (IFaction memberFaction in memberFactionsFunc.Invoke())
						if (MemberFactions.ShouldReturnFaction(memberFaction, SearchString))
							return true;

				return false;
			}
			public async Task<bool> ShouldReturnFactionAsync(
				IFaction faction,
				Func<IAsyncEnumerable<ICharacter>>? alliedCharactersFunc = null,
				Func<IAsyncEnumerable<IFaction>>? alliedFactionsFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? leadersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? memberCharactersFunc = null,
				Func<IAsyncEnumerable<IFaction>>? memberFactionsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnFaction(faction))
					return true;

				if (AlliedCharacters is not null && alliedCharactersFunc is not null)
					await foreach (ICharacter alliedCharacter in alliedCharactersFunc.Invoke().WithCancellation(cancellationToken))
						if (AlliedCharacters.ShouldReturnCharacter(alliedCharacter, SearchString))
							return true;

				if (AlliedFactions is not null && alliedFactionsFunc is not null)
					await foreach (IFaction alliedFaction in alliedFactionsFunc.Invoke().WithCancellation(cancellationToken))
						if (AlliedFactions.ShouldReturnFaction(alliedFaction, SearchString))
							return true;

				if (Leaders is not null && leadersFunc is not null)
					await foreach (ICharacter leader in leadersFunc.Invoke().WithCancellation(cancellationToken))
						if (Leaders.ShouldReturnCharacter(leader, SearchString))
							return true;

				if (MemberCharacters is not null && memberCharactersFunc is not null)
					await foreach (ICharacter memberCharacter in memberCharactersFunc.Invoke().WithCancellation(cancellationToken))
						if (MemberCharacters.ShouldReturnCharacter(memberCharacter, SearchString))
							return true;

				if (MemberFactions is not null && memberFactionsFunc is not null)
					await foreach (IFaction memberFaction in memberFactionsFunc.Invoke().WithCancellation(cancellationToken))
						if (MemberFactions.ShouldReturnFaction(memberFaction, SearchString))
							return true;

				return false;
			}

			public int GetMatchCount(IFaction faction)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnFaction(faction, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				return matchcount;
			}
			public int GetMatchCount(
				IFaction faction,
				Func<IEnumerable<ICharacter>>? alliedCharactersFunc = null,
				Func<IEnumerable<IFaction>>? alliedFactionsFunc = null,
				Func<IEnumerable<ICharacter>>? leadersFunc = null,
				Func<IEnumerable<ICharacter>>? memberCharactersFunc = null,
				Func<IEnumerable<IFaction>>? memberFactionsFunc = null)
			{
				int matchcount = GetMatchCount(faction);

				if (AlliedCharacters is not null && alliedCharactersFunc is not null)
					matchcount += alliedCharactersFunc.Invoke()
						.Select(alliedCharacter =>
						{
							AlliedCharacters.ShouldReturnCharacter(alliedCharacter, SearchString, out int alliedcharactermatchcount);

							return alliedcharactermatchcount;

						}).Sum();

				if (AlliedFactions is not null && alliedFactionsFunc is not null)
					matchcount += alliedFactionsFunc.Invoke()
						.Select(alliedFaction =>
						{
							AlliedFactions.ShouldReturnFaction(alliedFaction, SearchString, out int alliedfactionmatchcount);

							return alliedfactionmatchcount;

						}).Sum();

				if (Leaders is not null && leadersFunc is not null)
					matchcount += leadersFunc.Invoke()
						.Select(leader =>
						{
							Leaders.ShouldReturnCharacter(leader, SearchString, out int leadermatchcount);

							return leadermatchcount;

						}).Sum();

				if (MemberCharacters is not null && memberCharactersFunc is not null)
					matchcount += memberCharactersFunc.Invoke()
						.Select(memberCharacter =>
						{
							MemberCharacters.ShouldReturnCharacter(memberCharacter, SearchString, out int membercharactermatchcount);

							return membercharactermatchcount;

						}).Sum();

				if (MemberFactions is not null && memberFactionsFunc is not null)
					matchcount += memberFactionsFunc.Invoke()
						.Select(memberFaction =>
						{
							MemberFactions.ShouldReturnFaction(memberFaction, SearchString, out int memberfactionmatchcount);

							return memberfactionmatchcount;

						}).Sum();

				return matchcount;
			}

			public async Task<int> GetMatchCountAsync(
				IFaction faction,
				Func<IAsyncEnumerable<ICharacter>>? alliedCharactersFunc = null,
				Func<IAsyncEnumerable<IFaction>>? alliedFactionsFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? leadersFunc = null,
				Func<IAsyncEnumerable<ICharacter>>? memberCharactersFunc = null,
				Func<IAsyncEnumerable<IFaction>>? memberFactionsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(faction);

				if (AlliedCharacters is not null && alliedCharactersFunc is not null)
					await foreach (ICharacter alliedCharacter in alliedCharactersFunc.Invoke().WithCancellation(cancellationToken))
					{
						AlliedCharacters.ShouldReturnCharacter(alliedCharacter, SearchString, out int alliedcharactermatchcount); matchcount += alliedcharactermatchcount;
					}

				if (AlliedFactions is not null && alliedFactionsFunc is not null)
					await foreach (IFaction alliedFaction in alliedFactionsFunc.Invoke().WithCancellation(cancellationToken))
					{
						AlliedFactions.ShouldReturnFaction(alliedFaction, SearchString, out int alliedfactionmatchcount); matchcount += alliedfactionmatchcount;
					}

				if (Leaders is not null && leadersFunc is not null)
					await foreach (ICharacter leader in leadersFunc.Invoke().WithCancellation(cancellationToken))
					{
						Leaders.ShouldReturnCharacter(leader, SearchString, out int leadermatchcount); matchcount += leadermatchcount;
					}

				if (MemberCharacters is not null && memberCharactersFunc is not null)
					await foreach (ICharacter memberCharacter in memberCharactersFunc.Invoke().WithCancellation(cancellationToken))
					{
						MemberCharacters.ShouldReturnCharacter(memberCharacter, SearchString, out int memebercharactermatchcount); matchcount += memebercharactermatchcount;
					}

				if (MemberFactions is not null && memberFactionsFunc is not null)
					await foreach (IFaction memberFaction in memberFactionsFunc.Invoke().WithCancellation(cancellationToken))
					{
						MemberFactions.ShouldReturnFaction(memberFaction, SearchString, out int memberfactionmatchcount); matchcount += memberfactionmatchcount;
					}

				return matchcount;
			}
		}
	}

	public static class FactionSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IFaction.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearch<T>.AlliedCharacters), search.AlliedCharacters).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearch<T>.AlliedFactions), search.AlliedFactions).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearch<T>.Leaders), search.Leaders).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearch<T>.MemberCharacters), search.MemberCharacters).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearch<T>.MemberFactions), search.MemberFactions).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IFaction.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFaction.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();												   

			if (search.AlliedCharacters is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFaction.ISearch.AlliedCharacters)).AppendLine()
					.Append(search.AlliedCharacters).AppendLine();												   

			if (search.AlliedFactions is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFaction.ISearch.AlliedFactions)).AppendLine()
					.Append(search.AlliedFactions).AppendLine();												   

			if (search.Leaders is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFaction.ISearch.Leaders)).AppendLine()
					.Append(search.Leaders).AppendLine();												   

			if (search.MemberCharacters is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFaction.ISearch.MemberCharacters)).AppendLine()
					.Append(search.MemberCharacters).AppendLine();												   

			if (search.MemberCharacters is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFaction.ISearch.MemberCharacters)).AppendLine()
					.Append(search.MemberCharacters).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
