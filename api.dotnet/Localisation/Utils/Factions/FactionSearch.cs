using Localisation.Abstractions.Factions;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Factions
{
	public class FactionSearch
	{
		public const string ResourceName = "Factions.FactionSearch";

		public static readonly IFactionSearchLocalisationTyped<string> Keys = new IFactionSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "FactionSearch_Title",

			AlliedCharactersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FactionSearch_AlliedCharactersSearchContainables_Title",
				Description = "FactionSearch_AlliedCharactersSearchContainables_Description",
			},
			AlliedFactionsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FactionSearch_AlliedFactionsSearchContainables_Title",
				Description = "FactionSearch_AlliedFactionsSearchContainables_Description",
			},
			LeadersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FactionSearch_LeadersSearchContainables_Title",
				Description = "FactionSearch_LeadersSearchContainables_Description",
			},
			MemberCharactersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FactionSearch_MemberCharactersSearchContainables_Title",
				Description = "FactionSearch_MemberCharactersSearchContainables_Description",
			},
			MemberFactionsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FactionSearch_MemberFactionsSearchContainables_Title",
				Description = "FactionSearch_MemberFactionsSearchContainables_Description",
			},
		};
	}

	public static class FactionSearchExtensions
	{
		public static IFactionSearchLocalisation? GetFactionSearch(this LocalisationResourceManager? localisationResourceManager, IFactionSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFactionSearchLocalisation.Default 
				{
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.Title) : null,

					AlliedCharactersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.AlliedCharactersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.AlliedCharactersSearchContainables.Title) : null,
						Description = retriever?.AlliedCharactersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.AlliedCharactersSearchContainables.Description) : null,
					},
					AlliedFactionsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.AlliedFactionsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.AlliedFactionsSearchContainables.Title) : null,
						Description = retriever?.AlliedFactionsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.AlliedFactionsSearchContainables.Description) : null,
					},
					LeadersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.LeadersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.LeadersSearchContainables.Title) : null,
						Description = retriever?.LeadersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.LeadersSearchContainables.Description) : null,
					},
					MemberCharactersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.MemberCharactersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.MemberCharactersSearchContainables.Title) : null,
						Description = retriever?.MemberCharactersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.MemberCharactersSearchContainables.Description) : null,
					},
					MemberFactionsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.MemberFactionsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.MemberFactionsSearchContainables.Title) : null,
						Description = retriever?.MemberFactionsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FactionSearch.Keys.MemberFactionsSearchContainables.Description) : null,
					},
				};
	}
}
