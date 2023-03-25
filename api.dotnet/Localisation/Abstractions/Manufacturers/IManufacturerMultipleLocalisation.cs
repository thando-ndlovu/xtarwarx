using System.Text;

namespace Localisation.Abstractions.Manufacturers
{
	public interface IManufacturerMultipleLocalisation<T>
	{
		T ManufacturersTitle { get; set; }
		T ManufacturersEmptyText { get; set; }
		T ManufacturersSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(ManufacturersEmptyText), ManufacturersEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ManufacturersSearchbarPlaceholder), ManufacturersSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ManufacturersTitle), ManufacturersTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IManufacturerMultipleLocalisation : IManufacturerMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IManufacturerMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IManufacturerMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				ManufacturersTitle = defaultvalue;
				ManufacturersEmptyText = defaultvalue;
				ManufacturersSearchbarPlaceholder = defaultvalue;
			}

			public T ManufacturersTitle { get; set; }
			public T ManufacturersEmptyText { get; set; }
			public T ManufacturersSearchbarPlaceholder { get; set; }
		}
	}
}
