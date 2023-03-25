using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class StarshipsSearchQuerySchemas : TransportersSearchQuerySchemas
	{
		public const string Id_HyperdriveRatings = nameof(IStarshipsSearchQuery.HyperdriveRatings);
		public const string Id_HyperdriveRatingRangeLower = nameof(IStarshipsSearchQuery.HyperdriveRatingRangeLower);
		public const string Id_HyperdriveRatingRangeUpper = nameof(IStarshipsSearchQuery.HyperdriveRatingRangeUpper);	
		public const string Id_MGLTs = nameof(IStarshipsSearchQuery.MGLTs);
		public const string Id_MGLTRangeLower = nameof(IStarshipsSearchQuery.MGLTRangeLower);
		public const string Id_MGLTRangeUpper = nameof(IStarshipsSearchQuery.MGLTRangeUpper);	  
		public const string Id_StarshipClass = nameof(IStarshipsSearchQuery.StarshipClass);
		public const string Id_StarshipClassFlags = nameof(IStarshipsSearchQuery.StarshipClassFlags);

		public new static IStarshipsSearchQuery<SwaggerSchema?> Default()
		{
			ITransportersSearchQuery<SwaggerSchema?> transportersearchquery = TransportersSearchQuerySchemas.Default();

			return new IStarshipsSearchQuery.Default<SwaggerSchema?>(null)
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

				HyperdriveRatings = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HyperdriveRatings;
					swaggerschema.Name = "HyperdriveRatings";
				}),
				HyperdriveRatingRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HyperdriveRatingRangeLower;
					swaggerschema.Name = "HyperdriveRatingRangeLower";
				}),
				HyperdriveRatingRangeUpper = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HyperdriveRatingRangeUpper;
					swaggerschema.Name = "HyperdriveRatingRangeUpper";
				}),
				MGLTs = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MGLTs;
					swaggerschema.Name = "MGLTs";
				}),
				MGLTRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MGLTRangeLower;
					swaggerschema.Name = "MGLTRangeLower";
				}),
				MGLTRangeUpper = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MGLTRangeUpper;
					swaggerschema.Name = "MGLTRangeUpper";
				}),
				StarshipClass = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_StarshipClass;
					swaggerschema.Name = "StarshipClass";
				}),
				StarshipClassFlags = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_StarshipClassFlags;
					swaggerschema.Name = "StarshipClassFlags";
				}),
			};
		} 
	}
}
