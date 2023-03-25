using System.Text;

namespace Localisation.Abstractions.Planets
{
	public interface IPlanetMultipleLocalisation<T>
	{
		T PlanetsTitle { get; set; }
		T PlanetsEmptyText { get; set; }
		T PlanetsSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(PlanetsEmptyText), PlanetsEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PlanetsSearchbarPlaceholder), PlanetsSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PlanetsTitle), PlanetsTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IPlanetMultipleLocalisation : IPlanetMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IPlanetMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IPlanetMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				PlanetsTitle = defaultvalue;
				PlanetsEmptyText = defaultvalue;
				PlanetsSearchbarPlaceholder = defaultvalue;
			}

			public T PlanetsTitle { get; set; }
			public T PlanetsEmptyText { get; set; }
			public T PlanetsSearchbarPlaceholder { get; set; }
		}
	}
}
