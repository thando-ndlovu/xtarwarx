using System.Text;

namespace Localisation.Abstractions.General
{
	public interface IGeneralWords<T>  
	{
		T Language { get; set; }
		T General { get; set; }
		T Mode { get; set; }
		T Select { get; set; }
		T Theme { get; set; }
		T About { get; set; }
		T Account { get; set; }
		T Add { get; set; }
		T Api { get; set; }
		T Authorize { get; set; }
		T Authorizing { get; set; }
		T Cancel { get; set; }
		T Confirm { get; set; } 
		T Create { get; set; } 
		T Database { get; set; } 
		T Delete { get; set; } 
		T Denied { get; set; } 
		T Edit { get; set; } 
		T Error { get; set; }
		T False { get; set; } 
		T Info { get; set; } 
		T Invalid { get; set; }
		T Loading { get; set; }  
		T Login { get; set; } 
		T Logout { get; set; } 
		T No { get; set; }
		T Ok { get; set; } 
		T Options { get; set; } 
		T Read { get; set; }
		T Reverse { get; set; } 
		T Remove { get; set; } 
		T Reset { get; set; } 
		T Search { get; set; }
		T Settings { get; set; } 
		T StarWarX { get; set; } 
		T Submit { get; set; } 
		T Success { get; set; } 
		T True { get; set; }
		T Unavailable { get; set; } 
		T Update { get; set; } 
		T Valid { get; set; } 
		T View { get; set; } 
		T Warning { get; set; } 
		T Yes { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("Language: {0},", Language?.ToString())
				.AppendFormat("General: {0},", General?.ToString())
				.AppendFormat("Mode: {0},", Mode?.ToString())
				.AppendFormat("Select: {0},", Select?.ToString())
				.AppendFormat("Theme: {0},", Theme?.ToString())
				.AppendFormat("About: {0},", About?.ToString())
				.AppendFormat("Account: {0},", Account?.ToString())
				.AppendFormat("Add: {0},", Add?.ToString())
				.AppendFormat("Api: {0},", Api?.ToString())
				.AppendFormat("Authorize: {0},", Authorize?.ToString())
				.AppendFormat("Authorizing: {0},", Authorizing?.ToString())
				.AppendFormat("Cancel: {0},", Cancel?.ToString())
				.AppendFormat("Confirm: {0},", Confirm?.ToString())
				.AppendFormat("Create: {0},", Create?.ToString())
				.AppendFormat("Database: {0},", Database?.ToString())
				.AppendFormat("Delete: {0},", Delete?.ToString())
				.AppendFormat("Denied: {0},", Denied?.ToString())
				.AppendFormat("Edit: {0},", Edit?.ToString())
				.AppendFormat("Error: {0},", Error?.ToString())
				.AppendFormat("False: {0},", False?.ToString())
				.AppendFormat("Info: {0},", Info?.ToString())
				.AppendFormat("Invalid: {0},", Invalid?.ToString())
				.AppendFormat("Loading: {0},", Loading?.ToString())
				.AppendFormat("Login: {0},", Login?.ToString())
				.AppendFormat("Logout: {0},", Logout?.ToString())
				.AppendFormat("No: {0},", No?.ToString())
				.AppendFormat("Ok: {0},", Ok?.ToString())
				.AppendFormat("Options: {0},", Options?.ToString())
				.AppendFormat("Read: {0},", Read?.ToString())
				.AppendFormat("Reverse: {0},", Reverse?.ToString())
				.AppendFormat("Remove: {0},", Remove?.ToString())
				.AppendFormat("Reset: {0},", Reset?.ToString())
				.AppendFormat("Search: {0},", Search?.ToString())
				.AppendFormat("StarWarX: {0},", StarWarX?.ToString())
				.AppendFormat("Settings: {0},", Settings?.ToString())
				.AppendFormat("Submit: {0},", Submit?.ToString())
				.AppendFormat("Success: {0},", Success?.ToString())
				.AppendFormat("True: {0},", True?.ToString())
				.AppendFormat("Unavailable: {0},", Unavailable?.ToString())
				.AppendFormat("Update: {0},", Update?.ToString())
				.AppendFormat("Valid: {0},", Valid?.ToString())
				.AppendFormat("View: {0},", View?.ToString())
				.AppendFormat("Warning: {0},", Warning?.ToString())
				.AppendFormat("Yes: {0},", Yes?.ToString())
				.ToString();
		}
	}
	public interface IGeneralWords
	{
		string? Language { get; set; }
		string? General { get; set; }
		string? Mode { get; set; }
		string? Select { get; set; }
		string? Theme { get; set; }
		string? About { get; set; }
		string? Account { get; set; }
		string? Add { get; set; }
		string? Api { get; set; }
		string? Authorize { get; set; }
		string? Authorizing { get; set; }
		string? Cancel { get; set; }
		string? Confirm { get; set; }
		string? Create { get; set; }
		string? Database { get; set; }
		string? Delete { get; set; }
		string? Denied { get; set; }
		string? Edit { get; set; }
		string? Error { get; set; }
		string? False { get; set; }
		string? Info { get; set; }
		string? Invalid { get; set; }
		string? Loading { get; set; }
		string? Login { get; set; }
		string? Logout { get; set; }
		string? No { get; set; }
		string? Ok { get; set; }
		string? Options { get; set; }
		string? Read { get; set; }
		string? Reverse { get; set; }
		string? Remove { get; set; }
		string? Reset { get; set; }
		string? Search { get; set; }
		string? Settings { get; set; }
		string? StarWarX { get; set; }
		string? Submit { get; set; }
		string? Success { get; set; }
		string? True { get; set; }
		string? Unavailable { get; set; }
		string? Update { get; set; }
		string? Valid { get; set; }
		string? View { get; set; }
		string? Warning { get; set; }
		string? Yes { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("Language: {0},", Language)
				.AppendFormat("General: {0},", General)
				.AppendFormat("Mode: {0},", Mode)
				.AppendFormat("Select: {0},", Select)
				.AppendFormat("Theme: {0},", Theme)
				.AppendFormat("About: {0},", About)
				.AppendFormat("Account: {0},", Account)
				.AppendFormat("Add: {0},", Add)
				.AppendFormat("Api: {0},", Api)
				.AppendFormat("Authorize: {0},", Authorize)
				.AppendFormat("Authorizing: {0},", Authorizing)
				.AppendFormat("Cancel: {0},", Cancel)
				.AppendFormat("Confirm: {0},", Confirm)
				.AppendFormat("Create: {0},", Create)
				.AppendFormat("Database: {0},", Database)
				.AppendFormat("Delete: {0},", Delete)
				.AppendFormat("Denied: {0},", Denied)
				.AppendFormat("Edit: {0},", Edit)
				.AppendFormat("Error: {0},", Error)
				.AppendFormat("False: {0},", False)
				.AppendFormat("Info: {0},", Info)
				.AppendFormat("Invalid: {0},", Invalid)
				.AppendFormat("Loading: {0},", Loading)
				.AppendFormat("Login: {0},", Login)
				.AppendFormat("Logout: {0},", Logout)
				.AppendFormat("No: {0},", No)
				.AppendFormat("Ok: {0},", Ok)
				.AppendFormat("Options: {0},", Options)
				.AppendFormat("Read: {0},", Read)
				.AppendFormat("Reverse: {0},", Reverse)
				.AppendFormat("Remove: {0},", Remove)
				.AppendFormat("Reset: {0},", Reset)
				.AppendFormat("Search: {0},", Search)
				.AppendFormat("Settings: {0},", Settings)
				.AppendFormat("StarWarX: {0},", StarWarX)
				.AppendFormat("Submit: {0},", Submit)
				.AppendFormat("Success: {0},", Success)
				.AppendFormat("True: {0},", True)
				.AppendFormat("Unavailable: {0},", Unavailable)
				.AppendFormat("Update: {0},", Update)
				.AppendFormat("Valid: {0},", Valid)
				.AppendFormat("View: {0},", View)
				.AppendFormat("Warning: {0},", Warning)
				.AppendFormat("Yes: {0},", Yes)
				.ToString();
		}

		#region Defaults

		public class Default : IGeneralWords
		{
			public string? Language { get; set; }
			public string? General { get; set; }
			public string? Mode { get; set; }
			public string? Select { get; set; }
			public string? Theme { get; set; }
			public string? About { get; set; }
			public string? Account { get; set; }
			public string? Add { get; set; }
			public string? Api { get; set; }
			public string? Authorize { get; set; }
			public string? Authorizing { get; set; }
			public string? Cancel { get; set; }
			public string? Confirm { get; set; }
			public string? Create { get; set; }
			public string? Database { get; set; }
			public string? Delete { get; set; }
			public string? Denied { get; set; }
			public string? Edit { get; set; }
			public string? Error { get; set; }
			public string? False { get; set; }
			public string? Info { get; set; }
			public string? Invalid { get; set; }
			public string? Loading { get; set; }
			public string? Login { get; set; }
			public string? Logout { get; set; }
			public string? No { get; set; }
			public string? Ok { get; set; }
			public string? Options { get; set; }
			public string? Read { get; set; }
			public string? Reverse { get; set; }
			public string? Remove { get; set; }
			public string? Reset { get; set; }
			public string? Search { get; set; }
			public string? Settings { get; set; }
			public string? StarWarX { get; set; }
			public string? Submit { get; set; }
			public string? Success { get; set; }
			public string? True { get; set; }
			public string? Unavailable { get; set; }
			public string? Update { get; set; }
			public string? Valid { get; set; }
			public string? View { get; set; }
			public string? Warning { get; set; }
			public string? Yes { get; set; }
		}
		public class Default<T> : IGeneralWords<T>
		{
			public Default(T defaultvalue)
			{
				Theme = defaultvalue;
				Language = defaultvalue;
				General = defaultvalue;
				Mode = defaultvalue;
				Select = defaultvalue;
				About = defaultvalue;
				Account = defaultvalue;
				Add = defaultvalue;
				Api = defaultvalue;
				Authorize = defaultvalue;
				Authorizing = defaultvalue;
				Cancel = defaultvalue;
				Confirm = defaultvalue;
				Create = defaultvalue;
				Database = defaultvalue;
				Delete = defaultvalue;
				Denied = defaultvalue;
				Edit = defaultvalue;
				Error = defaultvalue;
				False = defaultvalue;
				Info = defaultvalue;
				Invalid = defaultvalue;
				Loading = defaultvalue;
				Login = defaultvalue;
				Logout = defaultvalue;
				No = defaultvalue;
				Ok = defaultvalue;
				Options = defaultvalue;
				Read = defaultvalue;
				Reverse = defaultvalue;
				Remove = defaultvalue;
				Reset = defaultvalue;
				Search = defaultvalue;
				Settings = defaultvalue;
				StarWarX = defaultvalue;
				Submit = defaultvalue;
				Success = defaultvalue;
				True = defaultvalue;
				Unavailable = defaultvalue;
				Update = defaultvalue;
				Valid = defaultvalue;
				View = defaultvalue;
				Warning = defaultvalue;
				Yes = defaultvalue;
			}

			public T Language { get; set; }
			public T General { get; set; }
			public T Mode { get; set; }
			public T Select { get; set; }
			public T Theme { get; set; }
			public T About { get; set; }
			public T Account { get; set; }
			public T Add { get; set; }
			public T Api { get; set; }
			public T Authorize { get; set; }
			public T Authorizing { get; set; }
			public T Cancel { get; set; }
			public T Confirm { get; set; }
			public T Create { get; set; }
			public T Database { get; set; }
			public T Delete { get; set; }
			public T Denied { get; set; }
			public T Edit { get; set; }
			public T Error { get; set; }
			public T False { get; set; }
			public T Info { get; set; }
			public T Invalid { get; set; }
			public T Loading { get; set; }
			public T Login { get; set; }
			public T Logout { get; set; }
			public T No { get; set; }
			public T Ok { get; set; }
			public T Options { get; set; }
			public T Read { get; set; }
			public T Reverse { get; set; }
			public T Remove { get; set; }
			public T Reset { get; set; }
			public T Search { get; set; }
			public T Settings { get; set; }
			public T StarWarX { get; set; }
			public T Submit { get; set; }
			public T Success { get; set; }
			public T True { get; set; }
			public T Unavailable { get; set; }
			public T Update { get; set; }
			public T Valid { get; set; }
			public T View { get; set; }
			public T Warning { get; set; }
			public T Yes { get; set; }
		}

		#endregion
	}
}
