using Localisation.Abstractions.General;

namespace Localisation.Utils.General
{
	public class GeneralWords
	{
		public const string ResourceName = "Generals.GeneralWords";

		public static readonly IGeneralWords<string> Keys = new IGeneralWords.Default<string>(string.Empty)
		{
			General = "GeneralWords_General",
			Language = "GeneralWords_Language",
			Mode = "GeneralWords_Mode",
			Select = "GeneralWords_Select",
			Theme = "GeneralWords_Theme",
			About = "GeneralWords_About",
			Account = "GeneralWords_Account", 
			Add = "GeneralWords_Add",
			Api = "GeneralWords_Api", 
			Authorize = "GeneralWords_Authorize", 
			Authorizing = "GeneralWords_Authorizing", 
			Cancel = "GeneralWords_Cancel", 
			Confirm = "GeneralWords_Confirm", 
			Create = "GeneralWords_Create", 
			Database = "GeneralWords_Database", 
			Delete = "GeneralWords_Delete", 
			Denied = "GeneralWords_Denied", 
			Edit = "GeneralWords_Edit", 
			Error = "GeneralWords_Error", 
			False = "GeneralWords_False", 
			Info = "GeneralWords_Info", 
			Invalid = "GeneralWords_Invalid",
			Loading = "GeneralWords_Loading",  
			Login = "GeneralWords_Login", 
			Logout = "GeneralWords_Logout", 
			No = "GeneralWords_No", 
			Ok = "GeneralWords_Ok", 
			Options = "GeneralWords_Options", 
			Read = "GeneralWords_Read",
			Reverse = "GeneralWords_Reverse", 
			Remove = "GeneralWords_Remove", 
			Reset = "GeneralWords_Reset", 
			Search = "GeneralWords_Search", 
			Settings = "GeneralWords_Settings",
			StarWarX = "GeneralWords_StarWarX", 
			Submit = "GeneralWords_Submit", 
			Success = "GeneralWords_Success", 
			True = "GeneralWords_True",
			Unavailable = "GeneralWords_Unavailable", 
			Update = "GeneralWords_Update", 
			Valid = "GeneralWords_Valid", 
			View = "GeneralWords_View", 
			Warning = "GeneralWords_Warning", 
			Yes = "GeneralWords_Yes", 
		};
	}

	public static class GeneralWordsExtensions
	{
		public static IGeneralWords? GetGeneralWords(this LocalisationResourceManager? localisationResourceManager, IGeneralWords<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IGeneralWords.Default
				{
					General = retriever?.General ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.General) : null,
					Language = retriever?.Language ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Language) : null,
					Mode = retriever?.Mode ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Mode) : null,
					Select = retriever?.Select ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Select) : null,
					Theme = retriever?.Theme ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Theme) : null,
					About = retriever?.About ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.About) : null,
					Account = retriever?.Account ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Account) : null,
					Add = retriever?.Add ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Add) : null,
					Api = retriever?.Api ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Api) : null,
					Authorize = retriever?.Authorize ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Authorize) : null,
					Authorizing = retriever?.Authorizing ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Authorizing) : null,
					Cancel = retriever?.Cancel ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Cancel) : null,
					Confirm = retriever?.Confirm ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Confirm) : null,
					Create = retriever?.Create ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Create) : null,
					Database = retriever?.Database ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Database) : null,
					Delete = retriever?.Delete ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Delete) : null,
					Denied = retriever?.Denied ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Denied) : null,
					Edit = retriever?.Edit ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Edit) : null,
					Error = retriever?.Error ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Error) : null,
					False = retriever?.False ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.False) : null,
					Info = retriever?.Info ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Info) : null,
					Invalid = retriever?.Invalid ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Invalid) : null,
					Loading = retriever?.Loading ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Loading) : null,
					Login = retriever?.Login ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Login) : null,
					Logout = retriever?.Logout ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Logout) : null,
					No = retriever?.No ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.No) : null,
					Ok = retriever?.Ok ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Ok) : null,
					Options = retriever?.Options ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Options) : null,
					Read = retriever?.Read ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Read) : null,
					Reverse = retriever?.Reverse ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Reverse) : null,
					Remove = retriever?.Remove ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Remove) : null,
					Reset = retriever?.Reset ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Reset) : null,
					Search = retriever?.Search ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Search) : null,
					Settings = retriever?.Settings ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Settings) : null,
					StarWarX = retriever?.StarWarX ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.StarWarX) : null,
					Submit = retriever?.Submit ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Submit) : null,
					Success = retriever?.Success ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Success) : null,
					True = retriever?.True ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.True) : null,
					Unavailable = retriever?.Update ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Unavailable) : null,
					Update = retriever?.Update ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Update) : null,
					Valid = retriever?.Valid ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Valid) : null,
					View = retriever?.View ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.View) : null,
					Warning = retriever?.Warning ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Warning) : null,
					Yes = retriever?.Yes ?? true ? localisationResourceManager.GetString(GeneralWords.Keys.Yes) : null,
				};
	}
}
