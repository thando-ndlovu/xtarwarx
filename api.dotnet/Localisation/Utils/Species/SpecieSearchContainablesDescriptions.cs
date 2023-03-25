using Domain.Models;

namespace Localisation.Utils.Species
{
	public class SpecieSearchContainablesDescriptions
	{
		public const string ResourceName = "Species.SpecieSearchContainablesDescriptions";

		public static readonly ISpecie.ISearchContainables<string> Keys = new ISpecie.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "SpecieSearchContainablesDescriptions_Description",
			Name = "SpecieSearchContainablesDescriptions_Name",
		};
	}

	public static class SpecieSearchContainablesDescriptionsExtensions
	{
		public static ISpecie.ISearchContainables<string?>? GetSpecieSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, ISpecie.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecie.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(SpecieSearchContainablesDescriptions.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(SpecieSearchContainablesDescriptions.Keys.Name) : null,
				};
	}
}
