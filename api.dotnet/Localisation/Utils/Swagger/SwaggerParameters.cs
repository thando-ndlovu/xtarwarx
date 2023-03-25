using Localisation.Abstractions.Swagger;

namespace Localisation.Utils.Swagger
{
	public class SwaggerParameters
	{
		public const string ResourceName = "Swagger.SwaggerParameters";

		public static readonly ISwaggerParametersLocalisation<string> Keys = new ISwaggerParametersLocalisation.Default<string>(string.Empty)
		{
			Query_Ids_Desription = "SwaggerParameters_Query_Ids_Desription",
			Query_Ids_Name = "SwaggerParameters_Query_Ids_Name",			 
			Query_IdsToSkip_Desription = "SwaggerParameters_Query_IdsToSkip_Desription",
			Query_IdsToSkip_Name = "SwaggerParameters_Query_IdsToSkip_Name",
			Query_ItemsPerPage_Desription = "SwaggerParameters_Query_ItemsPerPage_Desription",
			Query_ItemsPerPage_Name = "SwaggerParameters_Query_ItemsPerPage_Name",
			Query_OrderBy_Desription = "SwaggerParameters_Query_OrderBy_Desription",
			Query_OrderBy_Name = "SwaggerParameters_Query_OrderBy_Name",
			Query_Page_Desription = "SwaggerParameters_Query_Page_Desription",
			Query_Page_Name = "SwaggerParameters_Query_Page_Name",

			QueryMeta_AdditionsSince_Name = "SwaggerParameters_QueryMeta_AdditionsSince_Name",
			QueryMeta_AdditionsSince_Desription = "SwaggerParameters_QueryMeta_AdditionsSince_Desription",
			QueryMeta_EditsSince_Name = "SwaggerParameters_QueryMeta_EditsSince_Name",
			QueryMeta_EditsSince_Desription = "SwaggerParameters_QueryMeta_EditsSince_Desription",
		};
	}

	public static class SwaggerParametersExtensions
	{
		public static ISwaggerParametersLocalisation? GetSwaggerParameters(this LocalisationResourceManager? localisationResourceManager, ISwaggerParametersLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISwaggerParametersLocalisation.Default
				{
					Query_Ids_Desription = retriever?.Query_Ids_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_Ids_Desription) : null,
					Query_Ids_Name = retriever?.Query_Ids_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_Ids_Name) : null,					  
					Query_IdsToSkip_Desription = retriever?.Query_IdsToSkip_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_IdsToSkip_Desription) : null,
					Query_IdsToSkip_Name = retriever?.Query_IdsToSkip_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_IdsToSkip_Name) : null,	
					Query_ItemsPerPage_Desription = retriever?.Query_ItemsPerPage_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_ItemsPerPage_Desription) : null,
					Query_ItemsPerPage_Name = retriever?.Query_ItemsPerPage_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_ItemsPerPage_Name) : null,	
					Query_OrderBy_Desription = retriever?.Query_OrderBy_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_OrderBy_Desription) : null,
					Query_OrderBy_Name = retriever?.Query_OrderBy_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_OrderBy_Name) : null,
					Query_Page_Desription = retriever?.Query_Page_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_Page_Desription) : null,
					Query_Page_Name = retriever?.Query_Page_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.Query_Page_Name) : null,

					QueryMeta_AdditionsSince_Name = retriever?.QueryMeta_AdditionsSince_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.QueryMeta_AdditionsSince_Name) : null,
					QueryMeta_AdditionsSince_Desription = retriever?.QueryMeta_AdditionsSince_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.QueryMeta_AdditionsSince_Desription) : null,
					QueryMeta_EditsSince_Name = retriever?.QueryMeta_EditsSince_Name ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.QueryMeta_EditsSince_Name) : null,
					QueryMeta_EditsSince_Desription = retriever?.QueryMeta_EditsSince_Desription ?? true ? localisationResourceManager.GetString(SwaggerParameters.Keys.QueryMeta_EditsSince_Desription) : null,
				};
	}
}
