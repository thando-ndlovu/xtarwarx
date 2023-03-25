using System.Text;

namespace Localisation.Abstractions.Weapons
{
	public interface IWeaponMultipleLocalisation<T>
	{
		T WeaponsTitle { get; set; }
		T WeaponsEmptyText { get; set; }
		T WeaponsSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(WeaponsEmptyText), WeaponsEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(WeaponsSearchbarPlaceholder), WeaponsSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(WeaponsTitle), WeaponsTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IWeaponMultipleLocalisation : IWeaponMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IWeaponMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IWeaponMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				WeaponsTitle = defaultvalue;
				WeaponsEmptyText = defaultvalue;
				WeaponsSearchbarPlaceholder = defaultvalue;
			}

			public T WeaponsTitle { get; set; }
			public T WeaponsEmptyText { get; set; }
			public T WeaponsSearchbarPlaceholder { get; set; }
		}
	}
}
