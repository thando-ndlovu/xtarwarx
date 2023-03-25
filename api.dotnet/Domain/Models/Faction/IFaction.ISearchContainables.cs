using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IFaction
	{
		public new interface ISearchContainables<T> : IStarWarsModel.ISearchContainables<T>
		{
			T Description { get; set; }
			T Name { get; set; }
			T OrganizationTypes { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearchContainables : ISearchContainables<bool>, IStarWarsModel.ISearchContainables
		{
			public new class Default : Default<bool>, ISearchContainables
			{
				public Default() : base(false) { }
			}
			public new class Default<T> : IStarWarsModel.ISearchContainables.Default<T>, ISearchContainables<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Description = defaultvalue;
					Name = defaultvalue;
					OrganizationTypes = defaultvalue;
				}

				public T Description { get; set; }
				public T Name { get; set; }
				public T OrganizationTypes { get; set; }
			}

			public bool ShouldReturnFaction(IFaction faction, string? searchString)
			{
				if (Description && DescriptionContainsSearchString(faction, searchString, out int _)) return true;
				if (Name && NameContainsSearchString(faction, searchString, out int _)) return true;
				if (OrganizationTypes && OrganizationTypesContainsSearchString(faction, searchString, out int _)) return true;

				return false;
			}
			public bool ShouldReturnFaction(IFaction faction, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (Description && DescriptionContainsSearchString(faction, searchString, out int descriptionMatchCount))
				{
					matchCount += descriptionMatchCount;

					shouldreturn = true;
				}
				if (Name && NameContainsSearchString(faction, searchString, out int nameMatchCount))
				{
					matchCount += nameMatchCount;

					shouldreturn = true;
				}  	
				if (OrganizationTypes && OrganizationTypesContainsSearchString(faction, searchString, out int organizationTypesMatchCount))
				{
					matchCount += organizationTypesMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool DescriptionContainsSearchString(IFaction faction, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(faction.Description)) return false;

				if (faction.Description.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool NameContainsSearchString(IFaction faction, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(faction.Name)) return false;

				if (faction.Name.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}		
			private bool OrganizationTypesContainsSearchString(IFaction faction, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (faction.OrganizationTypes == null) return false;

				foreach(string factionOrganizationType in faction.OrganizationTypes)
					if (factionOrganizationType.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
						matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class IFactionExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IFaction.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearchContainables<T>.Description), searchcontainables.Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearchContainables<T>.Name), searchcontainables.Name).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFaction.ISearchContainables<T>.OrganizationTypes), searchcontainables.OrganizationTypes).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as IStarWarsModel.ISearchContainables<T>);
		}
	}
}
