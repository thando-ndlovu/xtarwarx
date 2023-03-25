using System.Text;

namespace Localisation.Abstractions.General
{
	public interface IGeneralPhrases<T>
	{
		T RestDesription { get; set; }
		T RestSwaggerDesription { get; set; }
		T GraphQlDesription { get; set; }
		T GraphQlAltairDesription { get; set; }
		T GraphQlGraphiqlDesription { get; set; }
		T GraphQlPlaygroundDesription { get; set; }
		T GraphQlVoyagerDesription { get; set; }
		T ReadMore { get; set; }
		T OrderBy { get; set; }
		T OrderByPrompt { get; set; }
		T ItemsPerPage { get; set; }
		T ItemsPerPagePrompt { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("GraphQlDesription: {0},", GraphQlDesription?.ToString())
				.AppendFormat("GraphQlAltairDesription: {0},", GraphQlAltairDesription?.ToString())
				.AppendFormat("GraphQlGraphiqlDesription: {0},", GraphQlGraphiqlDesription?.ToString())
				.AppendFormat("GraphQlPlaygroundDesription: {0},", GraphQlPlaygroundDesription?.ToString())
				.AppendFormat("GraphQlVoyagerDesription: {0},", GraphQlVoyagerDesription?.ToString())
				.AppendFormat("RestDesription: {0},", RestDesription?.ToString())
				.AppendFormat("RestSwaggerDesription: {0},", RestSwaggerDesription?.ToString())
				.AppendFormat("ReadMore: {0},", ReadMore?.ToString())
				.AppendFormat("OrderBy: {0},", OrderBy?.ToString())
				.AppendFormat("OrderByPrompt: {0},", OrderByPrompt?.ToString())
				.AppendFormat("ItemsPerPage: {0},", ItemsPerPage?.ToString())
				.AppendFormat("ItemsPerPagePrompt: {0},", ItemsPerPagePrompt?.ToString())
				.ToString();
		}
	}
	public interface IGeneralPhrases
	{
		string? RestDesription { get; set; }
		string? RestSwaggerDesription { get; set; }
		string? GraphQlDesription { get; set; }
		string? GraphQlAltairDesription { get; set; }
		string? GraphQlGraphiqlDesription { get; set; }
		string? GraphQlPlaygroundDesription { get; set; }
		string? GraphQlVoyagerDesription { get; set; }
		string? ReadMore { get; set; }
		string? OrderBy { get; set; }
		string? OrderByPrompt { get; set; }
		string? ItemsPerPage { get; set; }
		string? ItemsPerPagePrompt { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("GraphQlDesription: {0},", GraphQlDesription)
				.AppendFormat("GraphQlAltairDesription: {0},", GraphQlAltairDesription)
				.AppendFormat("GraphQlGraphiqlDesription: {0},", GraphQlGraphiqlDesription)
				.AppendFormat("GraphQlPlaygroundDesription: {0},", GraphQlPlaygroundDesription)
				.AppendFormat("GraphQlVoyagerDesription: {0},", GraphQlVoyagerDesription)
				.AppendFormat("RestDesription: {0},", RestDesription)
				.AppendFormat("RestSwaggerDesription: {0},", RestSwaggerDesription)
				.AppendFormat("ReadMore: {0},", ReadMore)
				.AppendFormat("OrderBy: {0},", OrderBy)
				.AppendFormat("OrderByPrompt: {0},", OrderByPrompt)
				.AppendFormat("ItemsPerPage: {0},", ItemsPerPage)
				.AppendFormat("ItemsPerPagePrompt: {0},", ItemsPerPagePrompt)
				.ToString();
		}

		public class Default : IGeneralPhrases
		{
			public string? RestDesription { get; set; }
			public string? RestSwaggerDesription { get; set; }
			public string? GraphQlDesription { get; set; }
			public string? GraphQlAltairDesription { get; set; }
			public string? GraphQlGraphiqlDesription { get; set; }
			public string? GraphQlPlaygroundDesription { get; set; }
			public string? GraphQlVoyagerDesription { get; set; }
			public string? ReadMore { get; set; }
			public string? OrderBy { get; set; }
			public string? OrderByPrompt { get; set; }
			public string? ItemsPerPage { get; set; }
			public string? ItemsPerPagePrompt { get; set; }
		}
		public class Default<T> : IGeneralPhrases<T>
		{
			public Default(T defaultvalue)
			{
				RestDesription = defaultvalue;
				RestSwaggerDesription = defaultvalue;
				GraphQlDesription = defaultvalue;
				GraphQlAltairDesription = defaultvalue;
				GraphQlGraphiqlDesription = defaultvalue;
				GraphQlPlaygroundDesription = defaultvalue;
				GraphQlVoyagerDesription = defaultvalue;
				ReadMore = defaultvalue;
				OrderBy = defaultvalue;
				OrderByPrompt = defaultvalue;
				ItemsPerPage = defaultvalue;
				ItemsPerPagePrompt = defaultvalue;
			}

			public T RestDesription { get; set; }
			public T RestSwaggerDesription { get; set; }
			public T GraphQlDesription { get; set; }
			public T GraphQlAltairDesription { get; set; }
			public T GraphQlGraphiqlDesription { get; set; }
			public T GraphQlPlaygroundDesription { get; set; }
			public T GraphQlVoyagerDesription { get; set; }
			public T ReadMore { get; set; }
			public T OrderBy { get; set; }
			public T OrderByPrompt { get; set; }
			public T ItemsPerPage { get; set; }
			public T ItemsPerPagePrompt { get; set; }
		}
	}
}
