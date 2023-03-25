using System.Text;

namespace Localisation.Abstractions.Species
{
	public interface ISpecieMultipleLocalisation<T>
	{
		T SpeciesTitle { get; set; }
		T SpeciesEmptyText { get; set; }
		T SpeciesSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(SpeciesEmptyText), SpeciesEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SpeciesSearchbarPlaceholder), SpeciesSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SpeciesTitle), SpeciesTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface ISpecieMultipleLocalisation : ISpecieMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, ISpecieMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : ISpecieMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				SpeciesTitle = defaultvalue;
				SpeciesEmptyText = defaultvalue;
				SpeciesSearchbarPlaceholder = defaultvalue;
			}

			public T SpeciesTitle { get; set; }
			public T SpeciesEmptyText { get; set; }
			public T SpeciesSearchbarPlaceholder { get; set; }
		}
	}
}
