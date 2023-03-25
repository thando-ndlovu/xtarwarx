using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class VehiclesSearchQuerySchemas : TransportersSearchQuerySchemas
	{
		public const string Id_VehicleClass = nameof(IVehiclesSearchQuery.VehicleClass);
		public const string Id_VehicleClassFlags = nameof(IVehiclesSearchQuery.VehicleClassFlags);

		public new static IVehiclesSearchQuery<SwaggerSchema?> Default()
		{
			ITransportersSearchQuery<SwaggerSchema?> transportersearchquery = TransportersSearchQuerySchemas.Default();

			return new IVehiclesSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = transportersearchquery.SearchString,
				CargoCapacities = transportersearchquery.CargoCapacities,
				CargoCapacityRangeLower = transportersearchquery.CargoCapacityRangeLower,
				CargoCapacityRangeUpper = transportersearchquery.CargoCapacityRangeUpper,
				Consumables = transportersearchquery.Consumables,
				ConsumableRangeLower = transportersearchquery.ConsumableRangeLower,
				ConsumableRangeUpper = transportersearchquery.ConsumableRangeUpper,		 
				CostInCredits = transportersearchquery.CostInCredits,
				CostInCreditRangeLower = transportersearchquery.CostInCreditRangeLower,
				CostInCreditRangeUpper = transportersearchquery.CostInCreditRangeUpper,
				Description = transportersearchquery.Description,
				Lengths = transportersearchquery.Lengths,
				LengthRangeLower = transportersearchquery.LengthRangeLower,
				LengthRangeUpper = transportersearchquery.LengthRangeUpper,
				ManufacturersDescription = transportersearchquery.ManufacturersDescription,
				ManufacturersName = transportersearchquery.ManufacturersName,
				MaxAtmospheringSpeeds = transportersearchquery.MaxAtmospheringSpeeds,
				MaxAtmospheringSpeedRangeLower = transportersearchquery.MaxAtmospheringSpeedRangeLower,
				MaxAtmospheringSpeedRangeUpper = transportersearchquery.MaxAtmospheringSpeedRangeUpper,
				MaxCrews = transportersearchquery.MaxCrews,
				MaxCrewRangeLower = transportersearchquery.MaxCrewRangeLower,
				MaxCrewRangeUpper = transportersearchquery.MaxCrewRangeUpper,
				MinCrews = transportersearchquery.MinCrews,
				MinCrewRangeLower = transportersearchquery.MinCrewRangeLower,
				MinCrewRangeUpper = transportersearchquery.MinCrewRangeUpper,
				Model = transportersearchquery.Model,
				Name = transportersearchquery.Name,
				Passengers = transportersearchquery.Passengers,
				PassengerRangeLower = transportersearchquery.PassengerRangeLower,
				PassengerRangeUpper = transportersearchquery.PassengerRangeUpper,
				PilotsDescription = transportersearchquery.PilotsDescription,
				PilotsName = transportersearchquery.PilotsName,

				VehicleClass = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_VehicleClass;
					swaggerschema.Name = "VehicleClass";
				}),
				VehicleClassFlags = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_VehicleClassFlags;
					swaggerschema.Name = "VehicleClassFlags";
				}),
			};
		} 
	}
}
