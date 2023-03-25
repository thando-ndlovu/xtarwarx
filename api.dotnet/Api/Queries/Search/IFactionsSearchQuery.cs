using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IFactionsSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T AlliedCharactersDescription { get; set; }
		T AlliedCharactersName { get; set; }
		T AlliedFactionsDescription { get; set; }
		T AlliedFactionsName { get; set; }
		T Description { get; set; }
		T LeadersDescription { get; set; }
		T LeadersName { get; set; }
		T MemberCharactersDescription { get; set; }
		T MemberCharactersName { get; set; }
		T MemberFactionsDescription { get; set; }
		T MemberFactionsName { get; set; }
		T Name { get; set; }
		T OrganizationTypes { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(AlliedCharactersDescription)
				.Append(AlliedCharactersName)
				.Append(AlliedFactionsDescription)
				.Append(AlliedFactionsName)
				.Append(Description)
				.Append(LeadersDescription)
				.Append(LeadersName)
				.Append(MemberCharactersDescription)
				.Append(MemberCharactersName)
				.Append(MemberFactionsDescription)
				.Append(MemberFactionsName)
				.Append(Name)
				.Append(OrganizationTypes);
		}
	}
	public interface IFactionsSearchQuery : IStarWarsModelSearchQuery
	{
		bool? AlliedCharactersDescription { get; set; }
		bool? AlliedCharactersName { get; set; }
		bool? AlliedFactionsDescription { get; set; }
		bool? AlliedFactionsName { get; set; }
		bool? Description { get; set; }
		bool? LeadersDescription { get; set; }
		bool? LeadersName { get; set; }
		bool? MemberCharactersDescription { get; set; }
		bool? MemberCharactersName { get; set; }
		bool? MemberFactionsDescription { get; set; }
		bool? MemberFactionsName { get; set; }
		bool? Name { get; set; }
		bool? OrganizationTypes { get; set; }

		public bool ShouldSearchAlliedCharacters()
		{
			return
				(AlliedCharactersDescription ?? false) ||
				(AlliedCharactersName ?? false);
		}
		public bool ShouldSearchAlliedFactions()
		{
			return
				(AlliedFactionsDescription ?? false) ||
				(AlliedFactionsName ?? false);
		}
		public bool ShouldSearchLeaders()
		{
			return
				(LeadersDescription ?? false) ||
				(LeadersName ?? false);
		}
		public bool ShouldSearchMemberCharacters()
		{
			return
				(MemberCharactersDescription ?? false) ||
				(MemberCharactersName ?? false);
		}
		public bool ShouldSearchMemberFactions()
		{
			return
				(MemberFactionsDescription ?? false) ||
				(MemberFactionsName ?? false);
		}

		public IFaction.ISearch AsFactionSearch(string? searchstring = null)
		{
			return new IFaction.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new IFaction.ISearchContainables.Default
				{
					Description = Description ?? false,
					Name = Name ?? false,
					OrganizationTypes = OrganizationTypes ?? false,
				},

				AlliedCharacters = new ICharacter.ISearchContainables.Default
				{
					Description = AlliedCharactersDescription ?? false,
					Name = AlliedCharactersName ?? false,
				},

				AlliedFactions = new IFaction.ISearchContainables.Default
				{
					Description = AlliedFactionsDescription ?? false,
					Name = AlliedFactionsName ?? false,
				},

				Leaders = new ICharacter.ISearchContainables.Default
				{
					Description = LeadersDescription ?? false,
					Name = LeadersName ?? false,
				},

				MemberCharacters = new ICharacter.ISearchContainables.Default
				{
					Description = MemberCharactersDescription ?? false,
					Name = MemberCharactersName ?? false,
				},

				MemberFactions = new IFaction.ISearchContainables.Default
				{
					Description = MemberFactionsDescription ?? false,
					Name = MemberFactionsName ?? false,
				},
			};
		}
		public IEnumerable<string> AsQueryData(IFactionsSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (AlliedCharactersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AlliedCharactersDescription ?? nameof(AlliedCharactersDescription).ToLower(), AlliedCharactersDescription.Value));

			if (AlliedCharactersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AlliedCharactersName ?? nameof(AlliedCharactersName).ToLower(), AlliedCharactersName.Value));

			if (AlliedFactionsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AlliedFactionsDescription ?? nameof(AlliedFactionsDescription).ToLower(), AlliedFactionsDescription.Value));

			if (AlliedFactionsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.AlliedFactionsName ?? nameof(AlliedFactionsName).ToLower(), AlliedFactionsName.Value));

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (LeadersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.LeadersDescription ?? nameof(LeadersDescription).ToLower(), LeadersDescription.Value));

			if (LeadersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.LeadersName ?? nameof(LeadersName).ToLower(), LeadersName.Value));

			if (MemberCharactersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MemberCharactersDescription ?? nameof(MemberCharactersDescription).ToLower(), MemberCharactersDescription.Value));

			if (MemberCharactersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MemberCharactersName ?? nameof(MemberCharactersName).ToLower(), MemberCharactersName.Value));

			if (MemberFactionsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MemberFactionsDescription ?? nameof(MemberFactionsDescription).ToLower(), MemberFactionsDescription.Value));

			if (MemberFactionsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MemberFactionsName ?? nameof(MemberFactionsName).ToLower(), MemberFactionsName.Value));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (OrganizationTypes.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.OrganizationTypes ?? nameof(OrganizationTypes).ToLower(), OrganizationTypes.Value));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, IFactionsSearchQuery
		{
			public Default() : base() { }
			public Default(IFaction.ISearch factionsearch) : base(factionsearch)
			{
				Description = factionsearch.SearchContainables?.Description;
				Name = factionsearch.SearchContainables?.Name;
				OrganizationTypes = factionsearch.SearchContainables?.OrganizationTypes;

				AlliedCharactersDescription = factionsearch.AlliedCharacters?.Description;
				AlliedCharactersName = factionsearch.AlliedCharacters?.Name;

				AlliedFactionsDescription = factionsearch.AlliedFactions?.Description;
				AlliedFactionsName = factionsearch.AlliedFactions?.Name;

				LeadersDescription = factionsearch.Leaders?.Description;
				LeadersName = factionsearch.Leaders?.Name;

				MemberCharactersDescription = factionsearch.MemberCharacters?.Description;
				MemberCharactersName = factionsearch.MemberCharacters?.Name;

				MemberFactionsDescription = factionsearch.MemberFactions?.Description;
				MemberFactionsName = factionsearch.MemberFactions?.Name;
			}

			public bool? AlliedCharactersDescription { get; set; }
			public bool? AlliedCharactersName { get; set; }
			public bool? AlliedFactionsDescription { get; set; }
			public bool? AlliedFactionsName { get; set; }
			public bool? Description { get; set; }
			public bool? LeadersDescription { get; set; }
			public bool? LeadersName { get; set; }
			public bool? MemberCharactersDescription { get; set; }
			public bool? MemberCharactersName { get; set; }
			public bool? MemberFactionsDescription { get; set; }
			public bool? MemberFactionsName { get; set; }
			public bool? Name { get; set; }
			public bool? OrganizationTypes { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, IFactionsSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				AlliedCharactersDescription = defaultvalue;
				AlliedCharactersName = defaultvalue;
				AlliedFactionsDescription = defaultvalue;
				AlliedFactionsName = defaultvalue;
				AlliedFactionsOrganizationTypes = defaultvalue;
				Description = defaultvalue;
				LeadersDescription = defaultvalue;
				LeadersName = defaultvalue;
				MemberCharactersDescription = defaultvalue;
				MemberCharactersName = defaultvalue;
				MemberFactionsDescription = defaultvalue;
				MemberFactionsName = defaultvalue;
				MemberFactionsOrganizationTypes = defaultvalue;
				Name = defaultvalue;
				OrganizationTypes = defaultvalue;
			}

			public T AlliedCharactersDescription { get; set; }
			public T AlliedCharactersName { get; set; }
			public T AlliedFactionsDescription { get; set; }
			public T AlliedFactionsName { get; set; }
			public T AlliedFactionsOrganizationTypes { get; set; }
			public T Description { get; set; }
			public T LeadersDescription { get; set; }
			public T LeadersName { get; set; }
			public T MemberCharactersDescription { get; set; }
			public T MemberCharactersName { get; set; }
			public T MemberFactionsDescription { get; set; }
			public T MemberFactionsName { get; set; }
			public T MemberFactionsOrganizationTypes { get; set; }
			public T Name { get; set; }
			public T OrganizationTypes { get; set; }
		}
	}
}
