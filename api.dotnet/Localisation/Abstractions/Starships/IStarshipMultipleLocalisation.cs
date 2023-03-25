using System.Text;

namespace Localisation.Abstractions.Starships
{
	public interface IStarshipMultipleLocalisation<T>
	{
		T StarshipsTitle { get; set; }
		T StarshipsEmptyText { get; set; }
		T StarshipsSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(StarshipsEmptyText), StarshipsEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(StarshipsSearchbarPlaceholder), StarshipsSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(StarshipsTitle), StarshipsTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IStarshipMultipleLocalisation : IStarshipMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IStarshipMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IStarshipMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				StarshipsTitle = defaultvalue;
				StarshipsEmptyText = defaultvalue;
				StarshipsSearchbarPlaceholder = defaultvalue;
			}

			public T StarshipsTitle { get; set; }
			public T StarshipsEmptyText { get; set; }
			public T StarshipsSearchbarPlaceholder { get; set; }
		}
	}
}
