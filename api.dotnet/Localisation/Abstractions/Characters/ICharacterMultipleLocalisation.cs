using System.Text;

namespace Localisation.Abstractions.Characters
{
	public interface ICharacterMultipleLocalisation<T>
	{
		T CharactersTitle { get; set; }
		T CharactersEmptyText { get; set; }
		T CharactersSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(CharactersEmptyText), CharactersEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CharactersSearchbarPlaceholder), CharactersSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CharactersTitle), CharactersTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface ICharacterMultipleLocalisation : ICharacterMultipleLocalisation<string?> 
	{
		public class Default : Default<string?>, ICharacterMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : ICharacterMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				CharactersTitle = defaultvalue;
				CharactersEmptyText = defaultvalue;
				CharactersSearchbarPlaceholder = defaultvalue;
			}

			public T CharactersTitle { get; set; }
			public T CharactersEmptyText { get; set; }
			public T CharactersSearchbarPlaceholder { get; set; }
		}
	}
}
