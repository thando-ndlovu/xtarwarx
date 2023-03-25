using System.Text;

namespace Localisation.Abstractions.Films
{
	public interface IFilmMultipleLocalisation<T>
	{
		T FilmsTitle { get; set; }
		T FilmsEmptyText { get; set; }
		T FilmsSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(FilmsEmptyText), FilmsEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(FilmsSearchbarPlaceholder), FilmsSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(FilmsTitle), FilmsTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IFilmMultipleLocalisation : IFilmMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IFilmMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IFilmMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				FilmsTitle = defaultvalue;
				FilmsEmptyText = defaultvalue;
				FilmsSearchbarPlaceholder = defaultvalue;
			}

			public T FilmsTitle { get; set; }
			public T FilmsEmptyText { get; set; }
			public T FilmsSearchbarPlaceholder { get; set; }
		}
	}
}
