using System.Text;

namespace Localisation.Abstractions.Vehicles
{
	public interface IVehicleMultipleLocalisation<T>
	{
		T VehiclesTitle { get; set; }
		T VehiclesEmptyText { get; set; }
		T VehiclesSearchbarPlaceholder { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			stringBuilder ??= new StringBuilder();

			stringBuilder
				.AppendFormat("{0}: {1}", nameof(VehiclesEmptyText), VehiclesEmptyText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(VehiclesSearchbarPlaceholder), VehiclesSearchbarPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(VehiclesTitle), VehiclesTitle).AppendLine();

			return stringBuilder.ToString();
		}
	}
	public interface IVehicleMultipleLocalisation : IVehicleMultipleLocalisation<string?>
	{
		public class Default : Default<string?>, IVehicleMultipleLocalisation
		{
			public Default() : base(null) { }
		}
		public class Default<T> : IVehicleMultipleLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				VehiclesTitle = defaultvalue;
				VehiclesEmptyText = defaultvalue;
				VehiclesSearchbarPlaceholder = defaultvalue;
			}
			
			public T VehiclesTitle { get; set; }
			public T VehiclesEmptyText { get; set; }
			public T VehiclesSearchbarPlaceholder { get; set; }
		}
	}
}
