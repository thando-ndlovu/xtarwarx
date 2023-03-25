using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class TransportersSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_CargoCapacities = nameof(ITransportersSearchQuery.CargoCapacities);
		public const string Id_CargoCapacityRangeLower = nameof(ITransportersSearchQuery.CargoCapacityRangeLower);
		public const string Id_CargoCapacityRangeUpper = nameof(ITransportersSearchQuery.CargoCapacityRangeUpper);
		public const string Id_Consumables = nameof(ITransportersSearchQuery.Consumables);
		public const string Id_ConsumableRangeLower = nameof(ITransportersSearchQuery.ConsumableRangeLower);
		public const string Id_ConsumableRangeUpper = nameof(ITransportersSearchQuery.ConsumableRangeUpper);		  
		public const string Id_CostInCredits = nameof(ITransportersSearchQuery.CostInCredits);
		public const string Id_CostInCreditRangeLower = nameof(ITransportersSearchQuery.CostInCreditRangeLower);
		public const string Id_CostInCreditRangeUpper = nameof(ITransportersSearchQuery.CostInCreditRangeUpper);
		public const string Id_Description = nameof(ITransportersSearchQuery.Description);
		public const string Id_Lengths = nameof(ITransportersSearchQuery.Lengths);
		public const string Id_LengthRangeLower = nameof(ITransportersSearchQuery.LengthRangeLower);
		public const string Id_LengthRangeUpper = nameof(ITransportersSearchQuery.LengthRangeUpper);
		public const string Id_ManufacturersDescription = nameof(ITransportersSearchQuery.ManufacturersDescription);
		public const string Id_ManufacturersName = nameof(ITransportersSearchQuery.ManufacturersName);
		public const string Id_MaxAtmospheringSpeeds = nameof(ITransportersSearchQuery.MaxAtmospheringSpeeds);
		public const string Id_MaxAtmospheringSpeedRangeLower = nameof(ITransportersSearchQuery.MaxAtmospheringSpeedRangeLower);
		public const string Id_MaxAtmospheringSpeedRangeUpper = nameof(ITransportersSearchQuery.MaxAtmospheringSpeedRangeUpper);
		public const string Id_MaxCrews = nameof(ITransportersSearchQuery.MaxCrews);
		public const string Id_MaxCrewRangeLower = nameof(ITransportersSearchQuery.MaxCrewRangeLower);
		public const string Id_MaxCrewRangeUpper = nameof(ITransportersSearchQuery.MaxCrewRangeUpper);
		public const string Id_MinCrews = nameof(ITransportersSearchQuery.MinCrews);
		public const string Id_MinCrewRangeLower = nameof(ITransportersSearchQuery.MinCrewRangeLower);
		public const string Id_MinCrewRangeUpper = nameof(ITransportersSearchQuery.MinCrewRangeUpper);
		public const string Id_Model = nameof(ITransportersSearchQuery.Model);
		public const string Id_Name = nameof(ITransportersSearchQuery.Name);
		public const string Id_Passengers = nameof(ITransportersSearchQuery.Passengers);
		public const string Id_PassengerRangeLower = nameof(ITransportersSearchQuery.PassengerRangeLower);
		public const string Id_PassengerRangeUpper = nameof(ITransportersSearchQuery.PassengerRangeUpper);
		public const string Id_PilotsDescription = nameof(ITransportersSearchQuery.PilotsDescription);
		public const string Id_PilotsName = nameof(ITransportersSearchQuery.PilotsName);

		public new static ITransportersSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new ITransportersSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				CargoCapacities = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CargoCapacities;
					swaggerschema.Name = "CargoCapacities";
				}),
				CargoCapacityRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CargoCapacityRangeLower;
					swaggerschema.Name = "CargoCapacityRangeLower";
				}),
				CargoCapacityRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CargoCapacityRangeUpper;
					swaggerschema.Name = "CargoCapacityRangeUpper";
				}),
				Consumables = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Consumables;
					swaggerschema.Name = "Consumables";
				}),
				ConsumableRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ConsumableRangeLower;
					swaggerschema.Name = "ConsumableRangeLower";
				}),
				ConsumableRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ConsumableRangeUpper;
					swaggerschema.Name = "ConsumableRangeUpper";
				}),			   
				CostInCredits = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CostInCredits;
					swaggerschema.Name = "CostInCredits";
				}),
				CostInCreditRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CostInCreditRangeLower;
					swaggerschema.Name = "CostInCreditRangeLower";
				}),
				CostInCreditRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CostInCreditRangeUpper;
					swaggerschema.Name = "CostInCreditRangeUpper";
				}),
				Description = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
				}),
				Lengths = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Lengths;
					swaggerschema.Name = "Lengths";
				}),
				LengthRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_LengthRangeLower;
					swaggerschema.Name = "LengthRangeLower";
				}),
				LengthRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_LengthRangeUpper;
					swaggerschema.Name = "LengthRangeUpper";
				}),
				ManufacturersDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ManufacturersDescription;
					swaggerschema.Name = "ManufacturersDescription";
				}),
				ManufacturersName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ManufacturersName;
					swaggerschema.Name = "ManufacturersName";
				}),
				MaxAtmospheringSpeeds = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MaxAtmospheringSpeeds;
					swaggerschema.Name = "MaxAtmospheringSpeeds";
				}),
				MaxAtmospheringSpeedRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MaxAtmospheringSpeedRangeLower;
					swaggerschema.Name = "MaxAtmospheringSpeedRangeLower";
				}),
				MaxAtmospheringSpeedRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MaxAtmospheringSpeedRangeUpper;
					swaggerschema.Name = "MaxAtmospheringSpeedRangeUpper";
				}),
				MaxCrews = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MaxCrews;
					swaggerschema.Name = "MaxCrews";
				}),
				MaxCrewRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MaxCrewRangeLower;
					swaggerschema.Name = "MaxCrewRangeLower";
				}),
				MaxCrewRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MaxCrewRangeUpper;
					swaggerschema.Name = "MaxCrewRangeUpper";
				}),
				MinCrews = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MinCrews;
					swaggerschema.Name = "MinCrews";
				}),
				MinCrewRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MinCrewRangeLower;
					swaggerschema.Name = "MinCrewRangeLower";
				}),
				MinCrewRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_MinCrewRangeUpper;
					swaggerschema.Name = "MinCrewRangeUpper";
				}),
				Model = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Model;
					swaggerschema.Name = "Model";
				}),
				Name = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Name;
					swaggerschema.Name = "Name";
				}),
				Passengers = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Passengers;
					swaggerschema.Name = "Passengers";
				}),
				PassengerRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PassengerRangeLower;
					swaggerschema.Name = "PassengerRangeLower";
				}),
				PassengerRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PassengerRangeUpper;
					swaggerschema.Name = "PassengerRangeUpper";
				}),
				PilotsDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PilotsDescription;
					swaggerschema.Name = "PilotsDescription";
				}),
				PilotsName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PilotsName;
					swaggerschema.Name = "PilotsName";
				}),
			};
		} 
	}
}
