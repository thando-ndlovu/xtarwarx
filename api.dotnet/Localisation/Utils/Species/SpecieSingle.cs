using Domain.Models;

using Localisation.Abstractions.Species;

namespace Localisation.Utils.Species
{
	public class SpecieSingle
	{
		public const string ResourceName = "Species.SpecieSingle";

		public static readonly ISpecieSingleLocalisation<string> Keys = new ISpecieSingleLocalisation.Default<string>(string.Empty)
		{
			CharactersTitle = "SpecieSingle_CharactersTitle",
			CharactersEmptyText = "SpecieSingle_CharactersEmptyText",
			HomeworldTitle = "SpecieSingle_HomeworldTitle",
			HomeworldAbsentText = "SpecieSingle_HomeworldAbsentText",
			ImagesTitle = "SpecieSingle_ImagesTitle",
			ImagesEmptyText = "SpecieSingle_ImagesEmptyText",
		};
	}

	public static class SpecieSingleExtensions
	{
		public static ISpecieSingleLocalisation? GetSpecieSingle(this LocalisationResourceManager? localisationResourceManager, ISpecieSingleLocalisation<bool>? retriever = null, ISpecie<string?>? specieTitles = null)
		{
			if (localisationResourceManager == null)
				return specieTitles as ISpecieSingleLocalisation;

			ISpecieSingleLocalisation speciesingle = ISpecieSingleLocalisation.FromSpecie(specieTitles) ?? new ISpecieSingleLocalisation.Default { };

			speciesingle.CharactersTitle = retriever?.CharactersTitle ?? true ? localisationResourceManager.GetString(SpecieSingle.Keys.CharactersTitle) : null;
			speciesingle.CharactersEmptyText = retriever?.CharactersEmptyText ?? true ? localisationResourceManager.GetString(SpecieSingle.Keys.CharactersEmptyText) : null;
			speciesingle.HomeworldTitle = retriever?.HomeworldTitle ?? true ? localisationResourceManager.GetString(SpecieSingle.Keys.HomeworldTitle) : null;
			speciesingle.HomeworldAbsentText = retriever?.HomeworldAbsentText ?? true ? localisationResourceManager.GetString(SpecieSingle.Keys.HomeworldAbsentText) : null;
			speciesingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(SpecieSingle.Keys.ImagesTitle) : null;
			speciesingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(SpecieSingle.Keys.ImagesEmptyText) : null;

			return speciesingle;

		}
		public static ISpecieSingleLocalisation? GetSpecieSingle(this LocalisationResourceManager? localisationResourceManager, ISpecieSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? specieTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetSpecieSingle(
				retriever: retriever,
				specieTitles: specieTitlesLocalisationResourceManager.GetSpecieTitles());
	}
}
