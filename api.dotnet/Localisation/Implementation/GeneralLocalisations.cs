using Localisation.Abstractions;
using Localisation.Abstractions.General;
using Localisation.Utils.General;

using System.Globalization;

using GeneralUtils = Localisation.Utils.General;

namespace Localisation.Implementation
{
	public class GeneralLocalisations : Base.BaseLocalisations, IGeneralLocalisations
	{
		public IGeneralPhrases? GeneralPhrases(CultureInfo? cultureInfo = null, IGeneralPhrases<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(GeneralUtils.GeneralPhrases.ResourceName, localisationcultureinfo)?
				.GetGeneralPhrases(retriever);
		}
		public IGeneralWords? GeneralWords(CultureInfo? cultureInfo = null, IGeneralWords<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(GeneralUtils.GeneralWords.ResourceName, localisationcultureinfo)?
				.GetGeneralWords(retriever);
		}
	}
}
