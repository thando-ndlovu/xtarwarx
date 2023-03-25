using Localisation.Abstractions.General;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IGeneralLocalisations : IDisposable
	{
		IGeneralPhrases? GeneralPhrases(CultureInfo? cultureInfo = null, IGeneralPhrases<bool>? retriever = null);
		IGeneralWords? GeneralWords(CultureInfo? cultureInfo = null, IGeneralWords<bool>? retriever = null);
	}
}
