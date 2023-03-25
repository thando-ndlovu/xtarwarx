using System.Text;

namespace Localisation.Abstractions.Swagger
{
	public interface ISwaggerParametersLocalisation<T>
	{
		#region Query

		T Query_ItemsPerPage_Name { get; set; }
		T Query_ItemsPerPage_Desription { get; set; }
		T Query_Ids_Name { get; set; }
		T Query_Ids_Desription { get; set; }			   
		T Query_IdsToSkip_Name { get; set; }
		T Query_IdsToSkip_Desription { get; set; }
		T Query_OrderBy_Name { get; set; }
		T Query_OrderBy_Desription { get; set; }
		T Query_Page_Name { get; set; }
		T Query_Page_Desription { get; set; }

		#endregion

		#region QueryMeta

		T QueryMeta_AdditionsSince_Name { get; set; }
		T QueryMeta_AdditionsSince_Desription { get; set; }
		T QueryMeta_EditsSince_Name { get; set; }
		T QueryMeta_EditsSince_Desription { get; set; }

		#endregion

		public string? ToString()
		{
			return new StringBuilder()
				.AppendFormat("Query_Ids_Desription: {0}", Query_Ids_Desription?.ToString() ?? "null")
				.AppendFormat("Query_Ids_Name: {0}", Query_Ids_Name?.ToString() ?? "null")
				.AppendFormat("Query_ItemsPerPage_Desription: {0}", Query_ItemsPerPage_Desription?.ToString() ?? "null")
				.AppendFormat("Query_ItemsPerPage_Name: {0}", Query_ItemsPerPage_Name?.ToString() ?? "null")
				.AppendFormat("Query_Page_Desription: {0}", Query_OrderBy_Desription?.ToString() ?? "null")
				.AppendFormat("Query_OrderBy_Name: {0}", Query_OrderBy_Name?.ToString() ?? "null")
				.AppendFormat("Query_Page_Desription: {0}", Query_Page_Desription?.ToString() ?? "null")
				.AppendFormat("Query_Page_Name: {0}", Query_Page_Name?.ToString() ?? "null")
				.AppendFormat("QueryMeta_AdditionsSince_Name: {0}", QueryMeta_AdditionsSince_Name?.ToString() ?? "null")
				.AppendFormat("QueryMeta_AdditionsSince_Desription: {0}", QueryMeta_AdditionsSince_Desription?.ToString() ?? "null")
				.AppendFormat("QueryMeta_EditsSince_Name: {0}", QueryMeta_EditsSince_Name?.ToString() ?? "null")
				.AppendFormat("QueryMeta_EditsSince_Desription: {0}", QueryMeta_EditsSince_Desription?.ToString() ?? "null")
				.ToString();
		}
	}
	public interface ISwaggerParametersLocalisation
	{
		#region Query

		string? Query_ItemsPerPage_Name { get; set; }
		string? Query_ItemsPerPage_Desription { get; set; }
		string? Query_Ids_Name { get; set; }
		string? Query_Ids_Desription { get; set; }				   
		string? Query_IdsToSkip_Name { get; set; }
		string? Query_IdsToSkip_Desription { get; set; }
		string? Query_OrderBy_Name { get; set; }
		string? Query_OrderBy_Desription { get; set; }
		string? Query_Page_Name { get; set; }
		string? Query_Page_Desription { get; set; }

		#endregion

		#region MetaQuery

		string? QueryMeta_AdditionsSince_Name { get; set; }
		string? QueryMeta_AdditionsSince_Desription { get; set; }
		string? QueryMeta_EditsSince_Name { get; set; }
		string? QueryMeta_EditsSince_Desription { get; set; }

		#endregion

		public string? ToString()
		{
			return new StringBuilder()
				.AppendFormat("Query_Ids_Desription: {0}", Query_Ids_Desription ?? "null")
				.AppendFormat("Query_Ids_Name: {0}", Query_Ids_Name ?? "null")
				.AppendFormat("Query_ItemsPerPage_Desription: {0}", Query_ItemsPerPage_Desription ?? "null")
				.AppendFormat("Query_ItemsPerPage_Name: {0}", Query_ItemsPerPage_Name ?? "null")
				.AppendFormat("Query_Page_Desription: {0}", Query_OrderBy_Desription ?? "null")
				.AppendFormat("Query_OrderBy_Name: {0}", Query_OrderBy_Name ?? "null")
				.AppendFormat("Query_Page_Desription: {0}", Query_Page_Desription ?? "null")
				.AppendFormat("Query_Page_Name: {0}", Query_Page_Name ?? "null")
				.AppendFormat("QueryMeta_AdditionsSince_Name: {0}", QueryMeta_AdditionsSince_Name ?? "null")
				.AppendFormat("QueryMeta_AdditionsSince_Desription: {0}", QueryMeta_AdditionsSince_Desription ?? "null")
				.AppendFormat("QueryMeta_EditsSince_Name: {0}", QueryMeta_EditsSince_Name ?? "null")
				.AppendFormat("QueryMeta_EditsSince_Desription: {0}", QueryMeta_EditsSince_Desription ?? "null")
				.ToString();
		}

		public class Default : ISwaggerParametersLocalisation
		{
			#region Query

			public string? Query_ItemsPerPage_Name { get; set; }
			public string? Query_ItemsPerPage_Desription { get; set; }
			public string? Query_Ids_Name { get; set; }
			public string? Query_Ids_Desription { get; set; }						 
			public string? Query_IdsToSkip_Name { get; set; }
			public string? Query_IdsToSkip_Desription { get; set; }
			public string? Query_OrderBy_Name { get; set; }
			public string? Query_OrderBy_Desription { get; set; }  
			public string? Query_Page_Name { get; set; }
			public string? Query_Page_Desription { get; set; }

			#endregion

			#region QueryMeta

			public string? QueryMeta_AdditionsSince_Name { get; set; }
			public string? QueryMeta_AdditionsSince_Desription { get; set; }
			public string? QueryMeta_EditsSince_Name { get; set; }
			public string? QueryMeta_EditsSince_Desription { get; set; }

			#endregion
		}
		public class Default<T> : ISwaggerParametersLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				Query_ItemsPerPage_Name = defaultvalue;
				Query_ItemsPerPage_Desription = defaultvalue;
				Query_Ids_Name = defaultvalue;
				Query_Ids_Desription = defaultvalue;							   
				Query_IdsToSkip_Name = defaultvalue;
				Query_IdsToSkip_Desription = defaultvalue;
				Query_OrderBy_Name = defaultvalue;
				Query_OrderBy_Desription = defaultvalue;
				Query_Page_Name = defaultvalue;
				Query_Page_Desription = defaultvalue;

				QueryMeta_AdditionsSince_Name = defaultvalue;
				QueryMeta_AdditionsSince_Desription = defaultvalue;
				QueryMeta_EditsSince_Name = defaultvalue;
				QueryMeta_EditsSince_Desription = defaultvalue;
			}

			#region Query

			public T Query_ItemsPerPage_Name { get; set; }
			public T Query_ItemsPerPage_Desription { get; set; }
			public T Query_Ids_Name { get; set; }
			public T Query_Ids_Desription { get; set; }					 
			public T Query_IdsToSkip_Name { get; set; }
			public T Query_IdsToSkip_Desription { get; set; }
			public T Query_OrderBy_Name { get; set; }
			public T Query_OrderBy_Desription { get; set; }
			public T Query_Page_Name { get; set; }
			public T Query_Page_Desription { get; set; }

			#endregion

			#region QueryMeta

			public T QueryMeta_AdditionsSince_Name { get; set; }
			public T QueryMeta_AdditionsSince_Desription { get; set; }
			public T QueryMeta_EditsSince_Name { get; set; }
			public T QueryMeta_EditsSince_Desription { get; set; }

			#endregion
		}
	}
}
