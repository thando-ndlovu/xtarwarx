using System.Text;

namespace Localisation.Abstractions.Factions
{
	public interface IFactionMultipleLocalisation<T>
	{
		T FactionsTitle { get; set; }
		T FactionsEmptyText { get; set; }
		T FactionsSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(FactionsEmptyText), FactionsEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(FactionsSearchbarPlaceholder), FactionsSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(FactionsTitle), FactionsTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IFactionMultipleLocalisation : IFactionMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IFactionMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IFactionMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				FactionsTitle = defaultvalue;
				FactionsEmptyText = defaultvalue;
				FactionsSearchbarPlaceholder = defaultvalue;
			}

			public T FactionsTitle { get; set; }
			public T FactionsEmptyText { get; set; }
			public T FactionsSearchbarPlaceholder { get; set; }
		}
	}
}
