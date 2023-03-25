using Localisation.Abstractions.General;

namespace Localisation.Utils.General
{
	public class GeneralPhrases
	{
		public const string ResourceName = "Generals.GeneralPhrases";

		public static readonly IGeneralPhrases<string> Keys = new IGeneralPhrases.Default<string>(string.Empty)
		{
			RestDesription = "GeneralPhrases_RestDesription",
			RestSwaggerDesription = "GeneralPhrases_RestSwaggerDesription",
			GraphQlDesription = "GeneralPhrases_GraphQlDesription",
			GraphQlAltairDesription = "GeneralPhrases_GraphQlAltairDesription",
			GraphQlGraphiqlDesription = "GeneralPhrases_GraphQlGraphiqlDesription",
			GraphQlPlaygroundDesription = "GeneralPhrases_GraphQlPlaygroundDesription",
			GraphQlVoyagerDesription = "GeneralPhrases_GraphQlVoyagerDesription",
			ReadMore = "GeneralPhrases_ReadMore",
			OrderBy = "GeneralPhrases_OrderBy",
			OrderByPrompt = "GeneralPhrases_OrderByPrompt",
			ItemsPerPage = "GeneralPhrases_ItemsPerPage",
			ItemsPerPagePrompt = "GeneralPhrases_ItemsPerPagePrompt",
		};
	}

	public static class GeneralPhrasesExtensions
	{
		public static IGeneralPhrases? GetGeneralPhrases(this LocalisationResourceManager? localisationResourceManager, IGeneralPhrases<bool>? retriever = null)
		{
			if (localisationResourceManager is null)
				return null;

			return new IGeneralPhrases.Default
			{
				RestDesription = retriever?.RestDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.RestDesription) : null,
				RestSwaggerDesription = retriever?.RestSwaggerDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.RestSwaggerDesription) : null,
				GraphQlDesription = retriever?.GraphQlDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.GraphQlDesription) : null,
				GraphQlAltairDesription = retriever?.GraphQlAltairDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.GraphQlAltairDesription) : null,
				GraphQlGraphiqlDesription = retriever?.GraphQlPlaygroundDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.GraphQlPlaygroundDesription) : null,
				GraphQlPlaygroundDesription = retriever?.GraphQlPlaygroundDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.GraphQlPlaygroundDesription) : null,
				GraphQlVoyagerDesription = retriever?.GraphQlVoyagerDesription ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.GraphQlVoyagerDesription) : null,
				ReadMore = retriever?.ReadMore ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.ReadMore) : null,
				OrderBy = retriever?.OrderBy ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.OrderBy) : null,
				OrderByPrompt = retriever?.OrderByPrompt ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.OrderByPrompt) : null,
				ItemsPerPage = retriever?.ItemsPerPage ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.ItemsPerPage) : null,
				ItemsPerPagePrompt = retriever?.ItemsPerPagePrompt ?? true ? localisationResourceManager.GetString(GeneralPhrases.Keys.ItemsPerPagePrompt) : null,
			};
		}
	}
}
