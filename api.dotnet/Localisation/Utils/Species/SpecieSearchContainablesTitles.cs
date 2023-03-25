using Domain.Models;

namespace Localisation.Utils.Species
{
	public class SpecieSearchContainablesTitles
	{
		public const string ResourceName = "Species.SpecieSearchContainablesTitles";

		public static readonly ISpecie.ISearchContainables<string> Keys = new ISpecie.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "SpecieSearchContainablesTitles_Description",
			Name = "SpecieSearchContainablesTitles_Name",
		};
	}

	public static class SpecieSearchContainablesTitlesExtensions
	{
		public static ISpecie.ISearchContainables<string?>? GetSpecieSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, ISpecie.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecie.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(SpecieSearchContainablesTitles.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(SpecieSearchContainablesTitles.Keys.Name) : null,
				};
	}
}
