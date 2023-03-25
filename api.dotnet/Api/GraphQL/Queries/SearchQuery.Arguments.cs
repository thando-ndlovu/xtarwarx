using Api.Queries;
using Api.Queries.Search;
using Api.GraphQL.Types;

using GraphQL;
using GraphQL.Types;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Queries
{
	public partial class SearchQuery 
	{
		public new class Arguments : StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments
		{
			public new class ArgumentNames : StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.ArgumentNames
			{
				public static readonly string SearchString = "SearchString";

				public static readonly ICharactersSearchQuery<string> QuerySearch_Characters = new ICharactersSearchQuery.Default<string>(string.Empty)
				{
					BirthYears = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.BirthYears)),
					BirthYearRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.BirthYearRangeLower)),
					BirthYearRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.BirthYearRangeUpper)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.Description)),
					EyeColors = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.EyeColors)),
					HairColors = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.HairColors)),
					Heights = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.Heights)),
					HeightRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.HeightRangeLower)),
					HeightRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.HeightRangeUpper)),
					HomeworldDescription = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.HomeworldDescription)),
					HomeworldName = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.HomeworldName)),
					Masses = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.Masses)),
					MassRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.MassRangeLower)),
					MassRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.MassRangeUpper)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.Name)),
					Sexes = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.Sexes)),
					SkinColors = string.Format("{0}{1}", nameof(IQuerySearch.Characters), nameof(IQuerySearch.Characters.SkinColors)),
				};
				public static readonly IFactionsSearchQuery<string> QuerySearch_Factions = new IFactionsSearchQuery.Default<string>(string.Empty)
				{
					AlliedCharactersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.AlliedCharactersDescription)),
					AlliedCharactersName = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.AlliedCharactersName)),
					AlliedFactionsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.AlliedFactionsDescription)),
					AlliedFactionsName = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.AlliedFactionsName)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.Description)),
					LeadersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.LeadersDescription)),
					LeadersName = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.LeadersName)),
					MemberCharactersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.MemberCharactersDescription)),
					MemberCharactersName = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.MemberCharactersName)),
					MemberFactionsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.MemberFactionsDescription)),
					MemberFactionsName = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.MemberFactionsName)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.Name)),
					OrganizationTypes = string.Format("{0}{1}", nameof(IQuerySearch.Factions), nameof(IQuerySearch.Factions.OrganizationTypes)),
				};
				public static readonly IFilmsSearchQuery<string> QuerySearch_Films = new IFilmsSearchQuery.Default<string>(string.Empty)
				{
					CastMembers = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.CastMembers)),
					CharactersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.CharactersDescription)),
					CharactersName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.CharactersName)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.Description)),
					Director = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.Director)),
					Durations = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.Durations)),
					DurationRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.DurationRangeLower)),
					DurationRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.DurationRangeUpper)),
					EpisodeIds = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.EpisodeIds)),
					EpisodeIdRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.EpisodeIdRangeLower)),
					EpisodeIdRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.EpisodeIdRangeUpper)),
					FactionsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.FactionsDescription)),
					FactionsName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.FactionsName)),
					ManufacturersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.ManufacturersDescription)),
					ManufacturersName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.ManufacturersName)),
					OpeningCrawl = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.OpeningCrawl)),
					PlanetsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.PlanetsDescription)),
					PlanetsName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.PlanetsName)),
					Producers = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.Producers)),
					ReleaseDates = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.ReleaseDates)),
					ReleaseDateRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.ReleaseDateRangeLower)),
					ReleaseDateRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.ReleaseDateRangeUpper)),
					SpeciesDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.SpeciesDescription)),
					SpeciesName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.SpeciesName)),
					StarshipsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.StarshipsDescription)),
					StarshipsModel = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.StarshipsModel)),
					StarshipsName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.StarshipsName)),
					StarshipsStarshipClass = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.StarshipsStarshipClass)),
					StarshipsStarshipClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.StarshipsStarshipClassFlags)),
					Title = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.Title)),
					VehiclesDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.VehiclesDescription)),
					VehiclesModel = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.VehiclesModel)),
					VehiclesName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.VehiclesName)),
					VehiclesVehicleClass = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.VehiclesVehicleClass)),
					VehiclesVehicleClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.VehiclesVehicleClassFlags)),
					WeaponsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.WeaponsDescription)),
					WeaponsModel = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.WeaponsModel)),
					WeaponsName = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.WeaponsName)),
					WeaponsWeaponClass = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.WeaponsWeaponClass)),
					WeaponsWeaponClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Films), nameof(IQuerySearch.Films.WeaponsWeaponClassFlags)),
				};
				public static readonly IManufacturersSearchQuery<string> QuerySearch_Manufacturers = new IManufacturersSearchQuery.Default<string>(string.Empty)
				{
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.Description)),
					HeadquatersPlanetDescription = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.HeadquatersPlanetDescription)),
					HeadquatersPlanetName = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.HeadquatersPlanetName)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.Name)),
					StarshipsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.StarshipsDescription)),
					StarshipsModel = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.StarshipsModel)),
					StarshipsName = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.StarshipsName)),
					StarshipsStarshipClass = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.StarshipsStarshipClass)),
					StarshipsStarshipClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.StarshipsStarshipClassFlags)),
					VehiclesDescription = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.VehiclesDescription)),
					VehiclesModel = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.VehiclesModel)),
					VehiclesName = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.VehiclesName)),
					VehiclesVehicleClass = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.VehiclesVehicleClass)),
					VehiclesVehicleClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.VehiclesVehicleClassFlags)),
					WeaponsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.WeaponsDescription)),
					WeaponsModel = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.WeaponsModel)),
					WeaponsName = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.WeaponsName)),
					WeaponsWeaponClass = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.WeaponsWeaponClass)),
					WeaponsWeaponClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Manufacturers), nameof(IQuerySearch.Manufacturers.WeaponsWeaponClassFlags)),
				};
				public static readonly IPlanetsSearchQuery<string> QuerySearch_Planets = new IPlanetsSearchQuery.Default<string>(string.Empty)
				{
					ClimateFlags = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.ClimateFlags)),
					ClimateTypes = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.ClimateTypes)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.Description)),
					Diameters = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.Diameters)),
					DiameterRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.DiameterRangeLower)),
					DiameterRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.DiameterRangeUpper)),
					Gravities = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.Gravities)),
					GravityRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.GravityRangeLower)),
					GravityRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.GravityRangeUpper)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.Name)),
					OrbitalPeriods = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.OrbitalPeriods)),
					OrbitalPeriodRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.OrbitalPeriodRangeLower)),
					OrbitalPeriodRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.OrbitalPeriodRangeUpper)),
					Populations = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.Populations)),
					PopulationRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.PopulationRangeLower)),
					PopulationRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.PopulationRangeUpper)),
					ResidentsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.ResidentsDescription)),
					ResidentsName = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.ResidentsName)),
					RotationalPeriods = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.RotationalPeriods)),
					RotationalPeriodRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.RotationalPeriodRangeLower)),
					RotationalPeriodRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.RotationalPeriodRangeUpper)),
					SurfaceWaters = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.SurfaceWaters)),
					SurfaceWaterRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.SurfaceWaterRangeLower)),
					SurfaceWaterRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.SurfaceWaterRangeUpper)),
					TerrainFlags = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.TerrainFlags)),
					TerrainTypes = string.Format("{0}{1}", nameof(IQuerySearch.Planets), nameof(IQuerySearch.Planets.TerrainTypes)),
				};
				public static readonly ISpeciesSearchQuery<string> QuerySearch_Species = new ISpeciesSearchQuery.Default<string>(string.Empty)
				{
					AverageHeights = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.AverageHeights)),
					AverageHeightRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.AverageHeightRangeLower)),
					AverageHeightRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.AverageHeightRangeUpper)),
					AverageLifespans = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.AverageLifespans)),
					AverageLifespanRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.AverageLifespanRangeLower)),
					AverageLifespanRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.AverageLifespanRangeUpper)),
					CharactersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.CharactersDescription)),
					CharactersName = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.CharactersName)),
					Classifications = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.Classifications)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.Description)),
					Designations = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.Designations)),
					EyeColors = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.EyeColors)),
					HairColors = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.HairColors)),
					HomeworldDescription = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.HomeworldDescription)),
					HomeworldName = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.HomeworldName)),
					Languages = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.Languages)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.Name)),
					SkinColors = string.Format("{0}{1}", nameof(IQuerySearch.Species), nameof(IQuerySearch.Species.SkinColors)),
				};
				public static readonly IStarshipsSearchQuery<string> QuerySearch_Starships = new IStarshipsSearchQuery.Default<string>(string.Empty)
				{
					CargoCapacities = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.CargoCapacities)),
					CargoCapacityRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.CargoCapacityRangeLower)),
					CargoCapacityRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.CargoCapacityRangeUpper)),
					Consumables = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.Consumables)),
					ConsumableRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.ConsumableRangeLower)),
					ConsumableRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.ConsumableRangeUpper)),			 
					CostInCredits = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.CostInCredits)),
					CostInCreditRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.CostInCreditRangeLower)),
					CostInCreditRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.CostInCreditRangeUpper)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.Description)),
					HyperdriveRatings = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.HyperdriveRatings)),
					HyperdriveRatingRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.HyperdriveRatingRangeLower)),
					HyperdriveRatingRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.HyperdriveRatingRangeUpper)),
					Lengths = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.Lengths)),
					LengthRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.LengthRangeLower)),
					LengthRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.LengthRangeUpper)),
					ManufacturersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.ManufacturersDescription)),
					ManufacturersName = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.ManufacturersName)),
					MaxAtmospheringSpeeds = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MaxAtmospheringSpeeds)),
					MaxAtmospheringSpeedRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MaxAtmospheringSpeedRangeLower)),
					MaxAtmospheringSpeedRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MaxAtmospheringSpeedRangeUpper)),
					MaxCrews = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MaxCrews)),
					MaxCrewRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MaxCrewRangeLower)),
					MaxCrewRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MaxCrewRangeUpper)),
					MGLTs = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MGLTs)),
					MGLTRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MGLTRangeLower)),
					MGLTRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MGLTRangeUpper)),
					MinCrews = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MinCrews)),
					MinCrewRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MinCrewRangeLower)),
					MinCrewRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.MinCrewRangeUpper)),
					Model = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.Model)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.Name)),
					Passengers = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.Passengers)),
					PassengerRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.PassengerRangeLower)),
					PassengerRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.PassengerRangeUpper)),
					PilotsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.PilotsDescription)),
					PilotsName = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.PilotsName)),
					StarshipClass = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.StarshipClass)),
					StarshipClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Starships), nameof(IQuerySearch.Starships.StarshipClassFlags)),
				};
				public static readonly IVehiclesSearchQuery<string> QuerySearch_Vehicles = new IVehiclesSearchQuery.Default<string>(string.Empty)
				{
					CargoCapacities = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.CargoCapacities)),
					CargoCapacityRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.CargoCapacityRangeLower)),
					CargoCapacityRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.CargoCapacityRangeUpper)),
					Consumables = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.Consumables)),
					ConsumableRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.ConsumableRangeLower)),
					ConsumableRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.ConsumableRangeUpper)),	 
					CostInCredits = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.CostInCredits)),
					CostInCreditRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.CostInCreditRangeLower)),
					CostInCreditRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.CostInCreditRangeUpper)),
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.Description)),
					Lengths = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.Lengths)),
					LengthRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.LengthRangeLower)),
					LengthRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.LengthRangeUpper)),
					ManufacturersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.ManufacturersDescription)),
					ManufacturersName = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.ManufacturersName)),
					MaxAtmospheringSpeeds = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MaxAtmospheringSpeeds)),
					MaxAtmospheringSpeedRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MaxAtmospheringSpeedRangeLower)),
					MaxAtmospheringSpeedRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MaxAtmospheringSpeedRangeUpper)),
					MaxCrews = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MaxCrews)),
					MaxCrewRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MaxCrewRangeLower)),
					MaxCrewRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MaxCrewRangeUpper)),
					MinCrews = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MinCrews)),
					MinCrewRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MinCrewRangeLower)),
					MinCrewRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.MinCrewRangeUpper)),
					Model = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.Model)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.Name)),
					Passengers = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.Passengers)),
					PassengerRangeLower = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.PassengerRangeLower)),
					PassengerRangeUpper = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.PassengerRangeUpper)),
					PilotsDescription = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.PilotsDescription)),
					PilotsName = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.PilotsName)),
					VehicleClass = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.VehicleClass)),
					VehicleClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Vehicles), nameof(IQuerySearch.Vehicles.VehicleClassFlags)),
				};
				public static readonly IWeaponsSearchQuery<string> QuerySearch_Weapons = new IWeaponsSearchQuery.Default<string>(string.Empty)
				{
					Description = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.Description)),
					ManufacturersDescription = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.ManufacturersDescription)),
					ManufacturersName = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.ManufacturersName)),
					Model = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.Model)),
					Name = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.Name)),
					WeaponClass = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.WeaponClass)),
					WeaponClassFlags = string.Format("{0}{1}", nameof(IQuerySearch.Weapons), nameof(IQuerySearch.Weapons.WeaponClassFlags)),
				};
			}

			public new readonly static IQuerySearch DefaultQuery = new IQuerySearch.Default
			{
				Ids = StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.DefaultQuery.Ids,
				ItemsPerPage = StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.DefaultQuery.ItemsPerPage,
				OrderBy = StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.DefaultQuery.OrderBy,
				Page = StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.DefaultQuery.Page,

				Characters = new ICharactersSearchQuery.Default
				{
					Name = true,
				},
				Factions = new IFactionsSearchQuery.Default
				{
					Name = true,
				},
				Films = new IFilmsSearchQuery.Default
				{
					Title = true,
				},
				Manufacturers = new IManufacturersSearchQuery.Default
				{
					Name = true,
				},
				Planets = new IPlanetsSearchQuery.Default
				{
					Name = true,
				},
				Species = new ISpeciesSearchQuery.Default
				{
					Name = true,
				},
				Starships = new IStarshipsSearchQuery.Default
				{
					Name = true,
				},
				Vehicles = new IVehiclesSearchQuery.Default
				{
					Name = true,
				},
				Weapons = new IWeaponsSearchQuery.Default
				{
					Name = true,
				},
			};

			public static IQuerySearch GenerateQuery(IResolveFieldContext resolvefieldcontext, IQuerySearch? defaultquery = null)
			{
				string? searchstring = resolvefieldcontext.Arguments?.ContainsKey(ArgumentNames.SearchString) ?? false
					? resolvefieldcontext.Arguments[ArgumentNames.SearchString].Value as string
					: null;

				ICharactersSearchQuery characterssearchquery = resolvefieldcontext.Arguments is null
					? new ICharactersSearchQuery.Default { SearchString = searchstring } 
					: new ICharactersSearchQuery.Default
					{
						SearchString = searchstring,

						BirthYears = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.BirthYears)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.BirthYears].Value as double?[]
							: defaultquery?.Characters?.BirthYears,
						BirthYearRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.BirthYearRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.BirthYearRangeLower].Value as double?
							: defaultquery?.Characters?.BirthYearRangeLower,
						BirthYearRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.BirthYearRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.BirthYearRangeUpper].Value as double?
							: defaultquery?.Characters?.BirthYearRangeUpper,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.Description].Value as bool?
							: defaultquery?.Characters?.Description,
						EyeColors = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.EyeColors)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.EyeColors].Value as string[]
							: defaultquery?.Characters?.EyeColors,
						HairColors = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.HairColors)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.HairColors].Value as string[]
							: defaultquery?.Characters?.HairColors,
						Heights = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.Heights)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.Heights].Value as int?[]
							: defaultquery?.Characters?.Heights,
						HeightRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.HeightRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.HeightRangeLower].Value as int?
							: defaultquery?.Characters?.HeightRangeLower,
						HeightRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.HeightRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.HeightRangeUpper].Value as int?
							: defaultquery?.Characters?.HeightRangeUpper,
						HomeworldDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.HomeworldDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.HomeworldDescription].Value as bool?
							: defaultquery?.Characters?.HomeworldDescription,
						HomeworldName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.HomeworldName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.HomeworldName].Value as bool?
							: defaultquery?.Characters?.HomeworldName,
						Masses = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.Masses)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.Masses].Value as double?[]
							: defaultquery?.Characters?.Masses,
						MassRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.MassRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.MassRangeLower].Value as double?
							: defaultquery?.Characters?.MassRangeLower,
						MassRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.MassRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.MassRangeUpper].Value as double?
							: defaultquery?.Characters?.MassRangeUpper,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.Name].Value as bool?
							: defaultquery?.Characters?.Name,
						Sexes = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.Sexes)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.Sexes].Value as string[]
							: defaultquery?.Characters?.Sexes,
						SkinColors = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Characters.SkinColors)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Characters.SkinColors].Value as string[]
							: defaultquery?.Characters?.SkinColors,
					};
				IFactionsSearchQuery factionssearchquery = resolvefieldcontext.Arguments is null
					? new IFactionsSearchQuery.Default { SearchString = searchstring } 
					: new IFactionsSearchQuery.Default
					{
						SearchString = searchstring,

						AlliedCharactersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.AlliedCharactersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.AlliedCharactersDescription].Value as bool?
							: defaultquery?.Factions?.AlliedCharactersDescription,
						AlliedCharactersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.AlliedCharactersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.AlliedCharactersName].Value as bool?
							: defaultquery?.Factions?.AlliedCharactersName,
						AlliedFactionsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.AlliedFactionsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.AlliedFactionsDescription].Value as bool?
							: defaultquery?.Factions?.AlliedFactionsDescription,
						AlliedFactionsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.AlliedFactionsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.AlliedFactionsName].Value as bool?
							: defaultquery?.Factions?.AlliedFactionsName,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.Description].Value as bool?
							: defaultquery?.Factions?.Description,
						LeadersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.LeadersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.LeadersDescription].Value as bool?
							: defaultquery?.Factions?.LeadersDescription,
						LeadersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.LeadersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.LeadersName].Value as bool?
							: defaultquery?.Factions?.LeadersName,
						MemberCharactersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.MemberCharactersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.MemberCharactersDescription].Value as bool?
							: defaultquery?.Factions?.MemberCharactersDescription,
						MemberCharactersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.MemberCharactersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.MemberCharactersName].Value as bool?
							: defaultquery?.Factions?.MemberCharactersName,
						MemberFactionsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.MemberFactionsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.MemberFactionsDescription].Value as bool?
							: defaultquery?.Factions?.MemberFactionsDescription,
						MemberFactionsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.MemberFactionsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.MemberFactionsName].Value as bool?
							: defaultquery?.Factions?.MemberFactionsName,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.Name].Value as bool?
							: defaultquery?.Factions?.Name,
						OrganizationTypes = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Factions.OrganizationTypes)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Factions.OrganizationTypes].Value as bool?
							: defaultquery?.Factions?.OrganizationTypes,
					};
				IFilmsSearchQuery filmssearchquery = resolvefieldcontext.Arguments is null
					? new IFilmsSearchQuery.Default { SearchString = searchstring } 
					: new IFilmsSearchQuery.Default
					{
						SearchString = searchstring,

						CastMembers = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.CastMembers)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.CastMembers].Value as bool?
							: defaultquery?.Films?.CastMembers,
						CharactersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.CharactersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.CharactersDescription].Value as bool?
							: defaultquery?.Films?.CharactersDescription,
						CharactersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.CharactersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.CharactersName].Value as bool?
							: defaultquery?.Films?.CharactersName,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.Description].Value as bool?
							: defaultquery?.Films?.Description,
						Director = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.Director)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.Director].Value as bool?
							: defaultquery?.Films?.Director,
						Durations = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.Durations)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.Durations].Value as TimeSpan?[]
							: defaultquery?.Films?.Durations,
						DurationRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.DurationRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.DurationRangeLower].Value as TimeSpan?
							: defaultquery?.Films?.DurationRangeLower,
						DurationRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.DurationRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.DurationRangeUpper].Value as TimeSpan?
							: defaultquery?.Films?.DurationRangeUpper,
						EpisodeIds = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.EpisodeIds)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.EpisodeIds].Value as int?[]
							: defaultquery?.Films?.EpisodeIds,
						EpisodeIdRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.EpisodeIdRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.EpisodeIdRangeLower].Value as int?
							: defaultquery?.Films?.EpisodeIdRangeLower,
						EpisodeIdRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.EpisodeIdRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.EpisodeIdRangeUpper].Value as int?
							: defaultquery?.Films?.EpisodeIdRangeUpper,
						FactionsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.FactionsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.FactionsDescription].Value as bool?
							: defaultquery?.Films?.FactionsDescription,
						FactionsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.FactionsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.FactionsName].Value as bool?
							: defaultquery?.Films?.FactionsName,
						ManufacturersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.ManufacturersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.ManufacturersDescription].Value as bool?
							: defaultquery?.Films?.ManufacturersDescription,
						ManufacturersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.ManufacturersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.ManufacturersName].Value as bool?
							: defaultquery?.Films?.ManufacturersName,
						OpeningCrawl = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.OpeningCrawl)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.OpeningCrawl].Value as bool?
							: defaultquery?.Films?.OpeningCrawl,
						PlanetsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.PlanetsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.PlanetsDescription].Value as bool?
							: defaultquery?.Films?.PlanetsDescription,
						PlanetsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.PlanetsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.PlanetsName].Value as bool?
							: defaultquery?.Films?.PlanetsName,
						Producers = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.Producers)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.Producers].Value as bool?
							: defaultquery?.Films?.Producers,
						ReleaseDates = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.ReleaseDates)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.ReleaseDates].Value as DateTime?[]
							: defaultquery?.Films?.ReleaseDates,
						ReleaseDateRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.ReleaseDateRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.ReleaseDateRangeLower].Value as DateTime?
							: defaultquery?.Films?.ReleaseDateRangeLower,
						ReleaseDateRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.ReleaseDateRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.ReleaseDateRangeUpper].Value as DateTime?
							: defaultquery?.Films?.ReleaseDateRangeUpper,
						SpeciesDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.SpeciesDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.SpeciesDescription].Value as bool?
							: defaultquery?.Films?.SpeciesDescription,
						SpeciesName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.SpeciesName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.SpeciesName].Value as bool?
							: defaultquery?.Films?.SpeciesName,
						StarshipsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.StarshipsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.StarshipsDescription].Value as bool?
							: defaultquery?.Films?.StarshipsDescription,
						StarshipsModel = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.StarshipsModel)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.StarshipsModel].Value as bool?
							: defaultquery?.Films?.StarshipsModel,
						StarshipsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.StarshipsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.StarshipsName].Value as bool?
							: defaultquery?.Films?.StarshipsName,
						StarshipsStarshipClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.StarshipsStarshipClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.StarshipsStarshipClass].Value as bool?
							: defaultquery?.Films?.StarshipsStarshipClass,
						StarshipsStarshipClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.StarshipsStarshipClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.StarshipsStarshipClassFlags].Value as bool?
							: defaultquery?.Films?.StarshipsStarshipClassFlags,
						Title = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.Title)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.Title].Value as bool?
							: defaultquery?.Films?.Title,
						VehiclesDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.VehiclesDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.VehiclesDescription].Value as bool?
							: defaultquery?.Films?.VehiclesDescription,
						VehiclesModel = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.VehiclesModel)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.VehiclesModel].Value as bool?
							: defaultquery?.Films?.VehiclesModel,
						VehiclesName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.VehiclesName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.VehiclesName].Value as bool?
							: defaultquery?.Films?.VehiclesName,
						VehiclesVehicleClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.VehiclesVehicleClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.VehiclesVehicleClass].Value as bool?
							: defaultquery?.Films?.VehiclesVehicleClass,
						VehiclesVehicleClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.VehiclesVehicleClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.VehiclesVehicleClassFlags].Value as bool?
							: defaultquery?.Films?.VehiclesVehicleClassFlags,
						WeaponsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.WeaponsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.WeaponsDescription].Value as bool?
							: defaultquery?.Films?.WeaponsDescription,
						WeaponsModel = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.WeaponsModel)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.WeaponsModel].Value as bool?
							: defaultquery?.Films?.WeaponsModel,
						WeaponsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.WeaponsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.WeaponsName].Value as bool?
							: defaultquery?.Films?.WeaponsName,
						WeaponsWeaponClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.WeaponsWeaponClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.WeaponsWeaponClass].Value as bool?
							: defaultquery?.Films?.WeaponsWeaponClass,
						WeaponsWeaponClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Films.WeaponsWeaponClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Films.WeaponsWeaponClassFlags].Value as bool?
							: defaultquery?.Films?.WeaponsWeaponClassFlags,
					};
				IManufacturersSearchQuery manufacturerssearchquery = resolvefieldcontext.Arguments is null
					? new IManufacturersSearchQuery.Default { SearchString = searchstring } 
					: new IManufacturersSearchQuery.Default
					{
						SearchString = searchstring,

						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.Description].Value as bool?
							: defaultquery?.Manufacturers?.Description,
						HeadquatersPlanetDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetDescription].Value as bool?
							: defaultquery?.Manufacturers?.HeadquatersPlanetDescription,
						HeadquatersPlanetName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetName].Value as bool?
							: defaultquery?.Manufacturers?.HeadquatersPlanetName,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.Name].Value as bool?
							: defaultquery?.Manufacturers?.Name,
						StarshipsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.StarshipsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.StarshipsDescription].Value as bool?
							: defaultquery?.Manufacturers?.StarshipsDescription,
						StarshipsModel = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.StarshipsModel)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.StarshipsModel].Value as bool?
							: defaultquery?.Manufacturers?.StarshipsModel,
						StarshipsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.StarshipsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.StarshipsName].Value as bool?
							: defaultquery?.Manufacturers?.StarshipsName,
						StarshipsStarshipClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClass].Value as bool?
							: defaultquery?.Manufacturers?.StarshipsStarshipClass,
						StarshipsStarshipClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClassFlags].Value as bool?
							: defaultquery?.Manufacturers?.StarshipsStarshipClassFlags,
						VehiclesDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.VehiclesDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.VehiclesDescription].Value as bool?
							: defaultquery?.Manufacturers?.VehiclesDescription,
						VehiclesModel = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.VehiclesModel)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.VehiclesModel].Value as bool?
							: defaultquery?.Manufacturers?.VehiclesModel,
						VehiclesName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.VehiclesName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.VehiclesName].Value as bool?
							: defaultquery?.Manufacturers?.VehiclesName,
						VehiclesVehicleClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClass].Value as bool?
							: defaultquery?.Manufacturers?.VehiclesVehicleClass,
						VehiclesVehicleClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClassFlags].Value as bool?
							: defaultquery?.Manufacturers?.VehiclesVehicleClassFlags,
						WeaponsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.WeaponsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.WeaponsDescription].Value as bool?
							: defaultquery?.Manufacturers?.WeaponsDescription,
						WeaponsModel = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.WeaponsModel)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.WeaponsModel].Value as bool?
							: defaultquery?.Manufacturers?.WeaponsModel,
						WeaponsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.WeaponsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.WeaponsName].Value as bool?
							: defaultquery?.Manufacturers?.WeaponsName,
						WeaponsWeaponClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClass].Value as bool?
							: defaultquery?.Manufacturers?.WeaponsWeaponClass,
						WeaponsWeaponClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClassFlags].Value as bool?
							: defaultquery?.Manufacturers?.WeaponsWeaponClassFlags,
					};
				IPlanetsSearchQuery planetssearchquery = resolvefieldcontext.Arguments is null
					? new IPlanetsSearchQuery.Default { SearchString = searchstring } 
					: new IPlanetsSearchQuery.Default
					{
						SearchString = searchstring,

						ClimateFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.ClimateFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.ClimateFlags].Value as string[]
							: defaultquery?.Planets?.ClimateFlags,
						ClimateTypes = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.ClimateTypes)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.ClimateTypes].Value as string[]
							: defaultquery?.Planets?.ClimateTypes,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.Description].Value as bool?
							: defaultquery?.Planets?.Description,
						Diameters = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.Diameters)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.Diameters].Value as int?[]
							: defaultquery?.Planets?.Diameters,
						DiameterRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.DiameterRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.DiameterRangeLower].Value as int?
							: defaultquery?.Planets?.DiameterRangeLower,
						DiameterRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.DiameterRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.DiameterRangeUpper].Value as int?
							: defaultquery?.Planets?.DiameterRangeUpper,
						Gravities = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.Gravities)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.Gravities].Value as double?[]
							: defaultquery?.Planets?.Gravities,
						GravityRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.GravityRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.GravityRangeLower].Value as double?
							: defaultquery?.Planets?.GravityRangeLower,
						GravityRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.GravityRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.GravityRangeUpper].Value as double?
							: defaultquery?.Planets?.GravityRangeUpper,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.Name].Value as bool?
							: defaultquery?.Planets?.Name,
						OrbitalPeriods = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.OrbitalPeriods)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.OrbitalPeriods].Value as TimeSpan?[]
							: defaultquery?.Planets?.OrbitalPeriods,
						OrbitalPeriodRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeLower].Value as TimeSpan?
							: defaultquery?.Planets?.OrbitalPeriodRangeLower,
						OrbitalPeriodRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeUpper].Value as TimeSpan?
							: defaultquery?.Planets?.OrbitalPeriodRangeUpper,
						Populations = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.Populations)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.Populations].Value as long?[]
							: defaultquery?.Planets?.Populations,
						PopulationRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.PopulationRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.PopulationRangeLower].Value as long?
							: defaultquery?.Planets?.PopulationRangeLower,
						PopulationRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.PopulationRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.PopulationRangeUpper].Value as long?
							: defaultquery?.Planets?.PopulationRangeUpper,
						ResidentsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.ResidentsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.ResidentsDescription].Value as bool?
							: defaultquery?.Planets?.ResidentsDescription,
						ResidentsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.ResidentsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.ResidentsName].Value as bool?
							: defaultquery?.Planets?.ResidentsName,
						RotationalPeriods = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.RotationalPeriods)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.RotationalPeriods].Value as TimeSpan?[]
							: defaultquery?.Planets?.RotationalPeriods,
						RotationalPeriodRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeLower].Value as TimeSpan?
							: defaultquery?.Planets?.RotationalPeriodRangeLower,
						RotationalPeriodRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeUpper].Value as TimeSpan?
							: defaultquery?.Planets?.RotationalPeriodRangeUpper,
						SurfaceWaters = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.SurfaceWaters)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.SurfaceWaters].Value as double?[]
							: defaultquery?.Planets?.SurfaceWaters,
						SurfaceWaterRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeLower].Value as double?
							: defaultquery?.Planets?.SurfaceWaterRangeLower,
						SurfaceWaterRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeUpper].Value as double?
							: defaultquery?.Planets?.SurfaceWaterRangeUpper,
						TerrainFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.TerrainFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.TerrainFlags].Value as string[]
							: defaultquery?.Planets?.TerrainFlags,
						TerrainTypes = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Planets.TerrainTypes)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Planets.TerrainTypes].Value as string[]
							: defaultquery?.Planets?.TerrainTypes,
					};
				ISpeciesSearchQuery speciessearchquery = resolvefieldcontext.Arguments is null
					? new ISpeciesSearchQuery.Default { SearchString = searchstring } 
					: new ISpeciesSearchQuery.Default
					{
						SearchString = searchstring,

						AverageHeights = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.AverageHeights)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.AverageHeights].Value as int?[]
							: defaultquery?.Species?.AverageHeights,
						AverageHeightRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.AverageHeightRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.AverageHeightRangeLower].Value as int?
							: defaultquery?.Species?.AverageHeightRangeLower,
						AverageHeightRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.AverageHeightRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.AverageHeightRangeUpper].Value as int?
							: defaultquery?.Species?.AverageHeightRangeUpper,
						AverageLifespans = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.AverageLifespans)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.AverageLifespans].Value as int?[]
							: defaultquery?.Species?.AverageLifespans,
						AverageLifespanRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.AverageLifespanRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.AverageLifespanRangeLower].Value as int?
							: defaultquery?.Species?.AverageLifespanRangeLower,
						AverageLifespanRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.AverageLifespanRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.AverageLifespanRangeUpper].Value as int?
							: defaultquery?.Species?.AverageLifespanRangeUpper,
						CharactersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.CharactersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.CharactersDescription].Value as bool?
							: defaultquery?.Species?.CharactersDescription,
						CharactersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.CharactersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.CharactersName].Value as bool?
							: defaultquery?.Species?.CharactersName,
						Classifications = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.Classifications)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.Classifications].Value as string[]
							: defaultquery?.Species?.Classifications,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.Description].Value as bool?
							: defaultquery?.Species?.Description,
						Designations = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.Designations)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.Designations].Value as string[]
							: defaultquery?.Species?.Designations,
						EyeColors = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.EyeColors)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.EyeColors].Value as string[]
							: defaultquery?.Species?.EyeColors,
						HairColors = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.HairColors)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.HairColors].Value as string[]
							: defaultquery?.Species?.HairColors,
						HomeworldDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.HomeworldDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.HomeworldDescription].Value as bool?
							: defaultquery?.Species?.HomeworldDescription,
						HomeworldName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.HomeworldName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.HomeworldName].Value as bool?
							: defaultquery?.Species?.HomeworldName,
						Languages = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.Languages)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.Languages].Value as string[]
							: defaultquery?.Species?.Languages,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.Name].Value as bool?
							: defaultquery?.Species?.Name,
						SkinColors = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Species.SkinColors)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Species.SkinColors].Value as string[]
							: defaultquery?.Species?.SkinColors,
					};
				IStarshipsSearchQuery starshipssearchquery = resolvefieldcontext.Arguments is null
					? new IStarshipsSearchQuery.Default { SearchString = searchstring } 
					: new IStarshipsSearchQuery.Default
					{
						SearchString = searchstring,

						CargoCapacities = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.CargoCapacities)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.CargoCapacities].Value as long?[]
							: defaultquery?.Starships?.CargoCapacities,
						CargoCapacityRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.CargoCapacityRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.CargoCapacityRangeLower].Value as long?
							: defaultquery?.Starships?.CargoCapacityRangeLower,
						CargoCapacityRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.CargoCapacityRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.CargoCapacityRangeUpper].Value as long?
							: defaultquery?.Starships?.CargoCapacityRangeUpper,
						Consumables = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.Consumables)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.Consumables].Value as string?[]
							: defaultquery?.Starships?.Consumables,
						ConsumableRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.ConsumableRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.ConsumableRangeLower].Value as string
							: defaultquery?.Starships?.ConsumableRangeLower,
						ConsumableRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.ConsumableRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.ConsumableRangeUpper].Value as string
							: defaultquery?.Starships?.ConsumableRangeUpper,
						CostInCredits = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.CostInCredits)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.CostInCredits].Value as long?[]
							: defaultquery?.Starships?.CostInCredits,
						CostInCreditRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.CostInCreditRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.CostInCreditRangeLower].Value as long?
							: defaultquery?.Starships?.CostInCreditRangeLower,
						CostInCreditRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.CostInCreditRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.CostInCreditRangeUpper].Value as long?
							: defaultquery?.Starships?.CostInCreditRangeUpper,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.Description].Value as bool?
							: defaultquery?.Starships?.Description,
						HyperdriveRatings = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.HyperdriveRatings)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.HyperdriveRatings].Value as double?[]
							: defaultquery?.Starships?.HyperdriveRatings,
						HyperdriveRatingRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeLower].Value as double?
							: defaultquery?.Starships?.HyperdriveRatingRangeLower,
						HyperdriveRatingRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeUpper].Value as double?
							: defaultquery?.Starships?.HyperdriveRatingRangeUpper,
						Lengths = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.Lengths)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.Lengths].Value as double?[]
							: defaultquery?.Starships?.Lengths,
						LengthRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.LengthRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.LengthRangeLower].Value as double?
							: defaultquery?.Starships?.LengthRangeLower,
						LengthRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.LengthRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.LengthRangeUpper].Value as double?
							: defaultquery?.Starships?.LengthRangeUpper,
						ManufacturersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.ManufacturersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.ManufacturersDescription].Value as bool?
							: defaultquery?.Starships?.ManufacturersDescription,
						ManufacturersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.ManufacturersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.ManufacturersName].Value as bool?
							: defaultquery?.Starships?.ManufacturersName,
						MaxAtmospheringSpeeds = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeeds)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeeds].Value as int?[]
							: defaultquery?.Starships?.MaxAtmospheringSpeeds,
						MaxAtmospheringSpeedRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeLower].Value as int?
							: defaultquery?.Starships?.MaxAtmospheringSpeedRangeLower,
						MaxAtmospheringSpeedRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeUpper].Value as int?
							: defaultquery?.Starships?.MaxAtmospheringSpeedRangeUpper,
						MaxCrews = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MaxCrews)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MaxCrews].Value as int?[]
							: defaultquery?.Starships?.MaxCrews,
						MaxCrewRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MaxCrewRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MaxCrewRangeLower].Value as int?
							: defaultquery?.Starships?.MaxCrewRangeLower,
						MaxCrewRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MaxCrewRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MaxCrewRangeUpper].Value as int?
							: defaultquery?.Starships?.MaxCrewRangeUpper,
						MGLTs = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MGLTs)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MGLTs].Value as int?[]
							: defaultquery?.Starships?.MGLTs,
						MGLTRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MGLTRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MGLTRangeLower].Value as int?
							: defaultquery?.Starships?.MGLTRangeLower,
						MGLTRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MGLTRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MGLTRangeUpper].Value as int?
							: defaultquery?.Starships?.MGLTRangeUpper,
						MinCrews = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MinCrews)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MinCrews].Value as int?[]
							: defaultquery?.Starships?.MinCrews,
						MinCrewRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MinCrewRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MinCrewRangeLower].Value as int?
							: defaultquery?.Starships?.MinCrewRangeLower,
						MinCrewRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.MinCrewRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.MinCrewRangeUpper].Value as int?
							: defaultquery?.Starships?.MinCrewRangeUpper,
						Model = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.Model)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.Model].Value as bool?
							: defaultquery?.Starships?.Model,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.Name].Value as bool?
							: defaultquery?.Starships?.Name,
						Passengers = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.Passengers)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.Passengers].Value as int?[]
							: defaultquery?.Starships?.Passengers,
						PassengerRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.PassengerRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.PassengerRangeLower].Value as int?
							: defaultquery?.Starships?.PassengerRangeLower,
						PassengerRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.PassengerRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.PassengerRangeUpper].Value as int?
							: defaultquery?.Starships?.PassengerRangeUpper,
						PilotsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.PilotsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.PilotsDescription].Value as bool?
							: defaultquery?.Starships?.PilotsDescription,
						PilotsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.PilotsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.PilotsName].Value as bool?
							: defaultquery?.Starships?.PilotsName,
						StarshipClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.StarshipClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.StarshipClass].Value as bool?
							: defaultquery?.Starships?.StarshipClass,
						StarshipClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.StarshipClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.StarshipClassFlags].Value as bool?
							: defaultquery?.Starships?.StarshipClassFlags,
					};
				IVehiclesSearchQuery vehiclessearchquery = resolvefieldcontext.Arguments is null
					? new IVehiclesSearchQuery.Default { SearchString = searchstring } 
					: new IVehiclesSearchQuery.Default
					{
						SearchString = searchstring,

						CargoCapacities = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.CargoCapacities)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.CargoCapacities].Value as long?[]
							: defaultquery?.Vehicles?.CargoCapacities,
						CargoCapacityRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeLower].Value as long?
							: defaultquery?.Vehicles?.CargoCapacityRangeLower,
						CargoCapacityRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeUpper].Value as long?
							: defaultquery?.Vehicles?.CargoCapacityRangeUpper,
						Consumables = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.Consumables)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.Consumables].Value as string?[]
							: defaultquery?.Vehicles?.Consumables,
						ConsumableRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.ConsumableRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.ConsumableRangeLower].Value as string
							: defaultquery?.Vehicles?.ConsumableRangeLower,
						ConsumableRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Starships.ConsumableRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Starships.ConsumableRangeUpper].Value as string
							: defaultquery?.Starships?.ConsumableRangeUpper,
						CostInCredits = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.CostInCredits)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.CostInCredits].Value as long?[]
							: defaultquery?.Vehicles?.CostInCredits,
						CostInCreditRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeLower].Value as long?
							: defaultquery?.Vehicles?.CostInCreditRangeLower,
						CostInCreditRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeUpper].Value as long?
							: defaultquery?.Vehicles?.CostInCreditRangeUpper,
						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.Description].Value as bool?
							: defaultquery?.Vehicles?.Description,
						Lengths = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.Lengths)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.Lengths].Value as double?[]
							: defaultquery?.Vehicles?.Lengths,
						LengthRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.LengthRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.LengthRangeLower].Value as double?
							: defaultquery?.Vehicles?.LengthRangeLower,
						LengthRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.LengthRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.LengthRangeUpper].Value as double?
							: defaultquery?.Vehicles?.LengthRangeUpper,
						ManufacturersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.ManufacturersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.ManufacturersDescription].Value as bool?
							: defaultquery?.Vehicles?.ManufacturersDescription,
						ManufacturersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.ManufacturersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.ManufacturersName].Value as bool?
							: defaultquery?.Vehicles?.ManufacturersName,
						MaxAtmospheringSpeeds = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeeds)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeeds].Value as int?[]
							: defaultquery?.Vehicles?.MaxAtmospheringSpeeds,
						MaxAtmospheringSpeedRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeLower].Value as int?
							: defaultquery?.Vehicles?.MaxAtmospheringSpeedRangeLower,
						MaxAtmospheringSpeedRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeUpper].Value as int?
							: defaultquery?.Vehicles?.MaxAtmospheringSpeedRangeUpper,
						MaxCrews = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MaxCrews)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MaxCrews].Value as int?[]
							: defaultquery?.Vehicles?.MaxCrews,
						MaxCrewRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeLower].Value as int?
							: defaultquery?.Vehicles?.MaxCrewRangeLower,
						MaxCrewRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeUpper].Value as int?
							: defaultquery?.Vehicles?.MaxCrewRangeUpper,
						MinCrews = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MinCrews)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MinCrews].Value as int?[]
							: defaultquery?.Vehicles?.MinCrews,
						MinCrewRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MinCrewRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MinCrewRangeLower].Value as int?
							: defaultquery?.Vehicles?.MinCrewRangeLower,
						MinCrewRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.MinCrewRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.MinCrewRangeUpper].Value as int?
							: defaultquery?.Vehicles?.MinCrewRangeUpper,
						Model = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.Model)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.Model].Value as bool?
							: defaultquery?.Vehicles?.Model,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.Name].Value as bool?
							: defaultquery?.Vehicles?.Name,
						Passengers = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.Passengers)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.Passengers].Value as int?[]
							: defaultquery?.Vehicles?.Passengers,
						PassengerRangeLower = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.PassengerRangeLower)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.PassengerRangeLower].Value as int?
							: defaultquery?.Vehicles?.PassengerRangeLower,
						PassengerRangeUpper = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.PassengerRangeUpper)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.PassengerRangeUpper].Value as int?
							: defaultquery?.Vehicles?.PassengerRangeUpper,
						PilotsDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.PilotsDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.PilotsDescription].Value as bool?
							: defaultquery?.Vehicles?.PilotsDescription,
						PilotsName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.PilotsName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.PilotsName].Value as bool?
							: defaultquery?.Vehicles?.PilotsName,
						VehicleClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.VehicleClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.VehicleClass].Value as bool?
							: defaultquery?.Vehicles?.VehicleClass,
						VehicleClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Vehicles.VehicleClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Vehicles.VehicleClassFlags].Value as bool?
							: defaultquery?.Vehicles?.VehicleClassFlags,
					};
				IWeaponsSearchQuery weaponssearchquery = resolvefieldcontext.Arguments is null
					? new IWeaponsSearchQuery.Default { SearchString = searchstring } 
					: new IWeaponsSearchQuery.Default
					{
						SearchString = searchstring,

						Description = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.Description)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.Description].Value as bool?
							: defaultquery?.Weapons?.Description,
						ManufacturersDescription = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.ManufacturersDescription)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.ManufacturersDescription].Value as bool?
							: defaultquery?.Weapons?.ManufacturersDescription,
						ManufacturersName = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.ManufacturersName)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.ManufacturersName].Value as bool?
							: defaultquery?.Weapons?.ManufacturersName,
						Model = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.Model)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.Model].Value as bool?
							: defaultquery?.Weapons?.Model,
						Name = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.Name)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.Name].Value as bool?
							: defaultquery?.Weapons?.Name,
						WeaponClass = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.WeaponClass)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.WeaponClass].Value as bool?
							: defaultquery?.Weapons?.WeaponClass,
						WeaponClassFlags = resolvefieldcontext.Arguments.ContainsKey(ArgumentNames.QuerySearch_Weapons.WeaponClassFlags)
							? resolvefieldcontext.Arguments[ArgumentNames.QuerySearch_Weapons.WeaponClassFlags].Value as bool?
							: defaultquery?.Weapons?.WeaponClassFlags,
					};

				IQuery query = GenerateQuery(resolvefieldcontext, defaultquery as IQuery);

				IQuerySearch querysearch = new IQuerySearch.Default
				{
					SearchString = searchstring,

					Characters = characterssearchquery,
					Factions = factionssearchquery,
					Films = filmssearchquery,
					Manufacturers = manufacturerssearchquery,
					Planets = planetssearchquery,
					Species = speciessearchquery,
					Starships = starshipssearchquery,
					Vehicles = vehiclessearchquery,
					Weapons = weaponssearchquery,

					Ids = query.Ids,
					ItemsPerPage = query.ItemsPerPage,
					OrderBy = query.OrderBy,
					Page = query.Page,
				};

				return querysearch;
			}
			public static QueryArguments QueryArguments(IQuerySearch? defaultquery = null)
			{
				QueryArguments queryarguments = StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.QueryArguments(defaultquery);

				ICharactersSearchQuery<QueryArgument?> charactersqueryarguments = new ICharactersSearchQuery.Default<QueryArgument?>(null)
				{
					BirthYears = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Characters?.BirthYears,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.BirthYears,
					},
					BirthYearRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Characters?.BirthYearRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.BirthYearRangeLower,
					},
					BirthYearRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Characters?.BirthYearRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.BirthYearRangeUpper,
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Characters?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.Description,
					},
					EyeColors = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Characters?.EyeColors,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.EyeColors,
					},
					HairColors = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Characters?.HairColors,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.HairColors,
					},
					Heights = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Characters?.Heights,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.Heights,
					},
					HeightRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Characters?.HeightRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.HeightRangeLower,
					},
					HeightRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Characters?.HeightRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.HeightRangeUpper,
					},
					HomeworldDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Characters?.HomeworldDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.HomeworldDescription,
					},
					HomeworldName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Characters?.HomeworldName,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.HomeworldName,
					},
					Masses = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Characters?.Masses,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.Masses,
					},
					MassRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Characters?.MassRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.MassRangeLower,
					},
					MassRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Characters?.MassRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.MassRangeUpper,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Characters?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.Name,
					},
					Sexes = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Characters?.Sexes,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.Sexes,
					},
					SkinColors = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Characters?.SkinColors,
						Name = Arguments.ArgumentNames.QuerySearch_Characters.SkinColors,
					},
				};
				IFactionsSearchQuery<QueryArgument?> factionsqueryarguments = new IFactionsSearchQuery.Default<QueryArgument?>(null)
				{
					AlliedCharactersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.AlliedCharactersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.AlliedCharactersDescription,
					},
					AlliedCharactersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.AlliedCharactersName,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.AlliedCharactersName,
					},
					AlliedFactionsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.AlliedFactionsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.AlliedFactionsDescription,
					},
					AlliedFactionsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.AlliedFactionsName,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.AlliedFactionsName,
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.Description,
					},
					LeadersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.LeadersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.LeadersDescription,
					},
					LeadersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.LeadersName,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.LeadersName,
					},
					MemberCharactersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.MemberCharactersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.MemberCharactersDescription,
					},
					MemberCharactersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.MemberCharactersName,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.MemberCharactersName,
					},
					MemberFactionsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.MemberFactionsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.MemberFactionsDescription,
					},
					MemberFactionsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.MemberFactionsName,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.MemberFactionsName,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.Name,
					},
					OrganizationTypes = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Factions?.OrganizationTypes,
						Name = Arguments.ArgumentNames.QuerySearch_Factions.OrganizationTypes,
					},
				};
				IFilmsSearchQuery<QueryArgument?> filmsqueryarguments = new IFilmsSearchQuery.Default<QueryArgument?>(null)
				{
					CastMembers = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.CastMembers,
						Name = Arguments.ArgumentNames.QuerySearch_Films.CastMembers
					},
					CharactersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.CharactersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.CharactersDescription
					},
					CharactersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.CharactersName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.CharactersName
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Films.Description
					},
					Director = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.Director,
						Name = Arguments.ArgumentNames.QuerySearch_Films.Director
					},
					Durations = new QueryArgument(new ArrayGraphType<TimeSpan>())
					{
						DefaultValue = defaultquery?.Films?.Durations,
						Name = Arguments.ArgumentNames.QuerySearch_Films.Durations
					},
					DurationRangeLower = new QueryArgument(new TimeSpanMinutesGraphType())
					{
						DefaultValue = defaultquery?.Films?.DurationRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Films.DurationRangeLower
					},
					DurationRangeUpper = new QueryArgument(new TimeSpanMinutesGraphType())
					{
						DefaultValue = defaultquery?.Films?.DurationRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Films.DurationRangeUpper
					},
					EpisodeIds = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Films?.EpisodeIds,
						Name = Arguments.ArgumentNames.QuerySearch_Films.EpisodeIds
					},
					EpisodeIdRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Films?.EpisodeIdRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Films.EpisodeIdRangeLower
					},
					EpisodeIdRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Films?.EpisodeIdRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Films.EpisodeIdRangeUpper
					},
					FactionsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.FactionsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.FactionsDescription
					},
					FactionsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.FactionsName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.FactionsName
					},
					ManufacturersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.ManufacturersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.ManufacturersDescription
					},
					ManufacturersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.ManufacturersName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.ManufacturersName
					},
					OpeningCrawl = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.OpeningCrawl,
						Name = Arguments.ArgumentNames.QuerySearch_Films.OpeningCrawl
					},
					PlanetsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.PlanetsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.PlanetsDescription
					},
					PlanetsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.PlanetsName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.PlanetsName
					},
					Producers = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.Producers,
						Name = Arguments.ArgumentNames.QuerySearch_Films.Producers
					},
					ReleaseDates = new QueryArgument(new ArrayGraphType<DateTime>())
					{
						DefaultValue = defaultquery?.Films?.ReleaseDates,
						Name = Arguments.ArgumentNames.QuerySearch_Films.ReleaseDates
					},
					ReleaseDateRangeLower = new QueryArgument(new DateTimeGraphType())
					{
						DefaultValue = defaultquery?.Films?.ReleaseDateRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Films.ReleaseDateRangeLower
					},
					ReleaseDateRangeUpper = new QueryArgument(new DateTimeGraphType())
					{
						DefaultValue = defaultquery?.Films?.ReleaseDateRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Films.ReleaseDateRangeUpper
					},
					SpeciesDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.SpeciesDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.SpeciesDescription
					},
					SpeciesName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.SpeciesName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.SpeciesName
					},
					StarshipsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.StarshipsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.StarshipsDescription
					},
					StarshipsModel = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.StarshipsModel,
						Name = Arguments.ArgumentNames.QuerySearch_Films.StarshipsModel
					},
					StarshipsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.StarshipsName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.StarshipsName
					},
					StarshipsStarshipClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.StarshipsStarshipClass,
						Name = Arguments.ArgumentNames.QuerySearch_Films.StarshipsStarshipClass
					},
					StarshipsStarshipClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.StarshipsStarshipClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Films.StarshipsStarshipClassFlags
					},
					VehiclesDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.VehiclesDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.VehiclesDescription
					},
					VehiclesModel = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.VehiclesModel,
						Name = Arguments.ArgumentNames.QuerySearch_Films.VehiclesModel
					},
					VehiclesName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.VehiclesName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.VehiclesName
					},
					VehiclesVehicleClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.VehiclesVehicleClass,
						Name = Arguments.ArgumentNames.QuerySearch_Films.VehiclesVehicleClass
					},
					VehiclesVehicleClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.VehiclesVehicleClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Films.VehiclesVehicleClassFlags
					},
					WeaponsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.WeaponsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Films.WeaponsDescription
					},
					WeaponsModel = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.WeaponsModel,
						Name = Arguments.ArgumentNames.QuerySearch_Films.WeaponsModel
					},
					WeaponsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.WeaponsName,
						Name = Arguments.ArgumentNames.QuerySearch_Films.WeaponsName
					},
					WeaponsWeaponClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.WeaponsWeaponClass,
						Name = Arguments.ArgumentNames.QuerySearch_Films.WeaponsWeaponClass
					},
					WeaponsWeaponClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Films?.WeaponsWeaponClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Films.WeaponsWeaponClassFlags
					},
				};
				IManufacturersSearchQuery<QueryArgument?> manufacturersqueryarguments = new IManufacturersSearchQuery.Default<QueryArgument?>(null)
				{
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.Description,
					},
					HeadquatersPlanetDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.HeadquatersPlanetDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetDescription,
					},
					HeadquatersPlanetName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.HeadquatersPlanetName,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetName,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.Name,
					},
					StarshipsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.StarshipsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.StarshipsDescription,
					},
					StarshipsModel = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.StarshipsModel,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.StarshipsModel,
					},
					StarshipsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.StarshipsName,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.StarshipsName,
					},
					StarshipsStarshipClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.StarshipsStarshipClass,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClass,
					},
					StarshipsStarshipClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.StarshipsStarshipClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClassFlags,
					},
					VehiclesDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.VehiclesDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.VehiclesDescription,
					},
					VehiclesModel = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.VehiclesModel,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.VehiclesModel,
					},
					VehiclesName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.VehiclesName,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.VehiclesName,
					},
					VehiclesVehicleClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.VehiclesVehicleClass,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClass,
					},
					VehiclesVehicleClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.VehiclesVehicleClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClassFlags,
					},
					WeaponsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.WeaponsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.WeaponsDescription,
					},
					WeaponsModel = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.WeaponsModel,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.WeaponsModel,
					},
					WeaponsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.WeaponsName,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.WeaponsName,
					},
					WeaponsWeaponClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.WeaponsWeaponClass,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClass,
					},
					WeaponsWeaponClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Manufacturers?.WeaponsWeaponClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClassFlags,
					},
				};
				IPlanetsSearchQuery<QueryArgument?> planetsqueryarguments = new IPlanetsSearchQuery.Default<QueryArgument?>(null)
				{
					ClimateFlags = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Planets?.ClimateFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.ClimateFlags,
					},
					ClimateTypes = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Planets?.ClimateTypes,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.ClimateTypes,
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Planets?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.Description,
					},
					Diameters = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Planets?.Diameters,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.Diameters,
					},
					DiameterRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Planets?.DiameterRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.DiameterRangeLower,
					},
					DiameterRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Planets?.DiameterRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.DiameterRangeUpper,
					},
					Gravities = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Planets?.Gravities,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.Gravities,
					},
					GravityRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Planets?.GravityRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.GravityRangeLower,
					},
					GravityRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Planets?.GravityRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.GravityRangeUpper,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Planets?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.Name,
					},
					OrbitalPeriods = new QueryArgument(new ArrayGraphType<TimeSpan>())
					{
						DefaultValue = defaultquery?.Planets?.OrbitalPeriods,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.OrbitalPeriods,
					},
					OrbitalPeriodRangeLower = new QueryArgument(new TimeSpanDaysGraphType())
					{
						DefaultValue = defaultquery?.Planets?.OrbitalPeriodRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeLower,
					},
					OrbitalPeriodRangeUpper = new QueryArgument(new TimeSpanDaysGraphType())
					{
						DefaultValue = defaultquery?.Planets?.OrbitalPeriodRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeUpper,
					},
					Populations = new QueryArgument(new TimeSpanDaysGraphType())
					{
						DefaultValue = defaultquery?.Planets?.Populations,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.Populations,
					},
					PopulationRangeLower = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Planets?.PopulationRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.PopulationRangeLower,
					},
					PopulationRangeUpper = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Planets?.PopulationRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.PopulationRangeUpper,
					},
					ResidentsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Planets?.ResidentsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.ResidentsDescription,
					},
					ResidentsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Planets?.ResidentsName,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.ResidentsName,
					},
					RotationalPeriods = new QueryArgument(new ArrayGraphType<TimeSpan>())
					{
						DefaultValue = defaultquery?.Planets?.RotationalPeriods,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.RotationalPeriods,
					},
					RotationalPeriodRangeLower = new QueryArgument(new TimeSpanHoursGraphType())
					{
						DefaultValue = defaultquery?.Planets?.RotationalPeriodRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeLower,
					},
					RotationalPeriodRangeUpper = new QueryArgument(new TimeSpanHoursGraphType())
					{
						DefaultValue = defaultquery?.Planets?.RotationalPeriodRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeUpper,
					},
					SurfaceWaters = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Planets?.SurfaceWaters,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.SurfaceWaters,
					},
					SurfaceWaterRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Planets?.SurfaceWaterRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeLower,
					},
					SurfaceWaterRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Planets?.SurfaceWaterRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeUpper,
					},
					TerrainFlags = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Planets?.TerrainFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.TerrainFlags,
					},
					TerrainTypes = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Planets?.TerrainTypes,
						Name = Arguments.ArgumentNames.QuerySearch_Planets.TerrainTypes,
					},
				};
				ISpeciesSearchQuery<QueryArgument?> speciesqueryarguments = new ISpeciesSearchQuery.Default<QueryArgument?>(null)
				{
					AverageHeights = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Species?.AverageHeights,
						Name = Arguments.ArgumentNames.QuerySearch_Species.AverageHeights,
					},
					AverageHeightRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Species?.AverageHeightRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Species.AverageHeightRangeLower,
					},
					AverageHeightRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Species?.AverageHeightRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Species.AverageHeightRangeUpper,
					},
					AverageLifespans = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Species?.AverageLifespans,
						Name = Arguments.ArgumentNames.QuerySearch_Species.AverageLifespans,
					},
					AverageLifespanRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Species?.AverageLifespanRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Species.AverageLifespanRangeLower,
					},
					AverageLifespanRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Species?.AverageLifespanRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Species.AverageLifespanRangeUpper,
					},
					CharactersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Species?.CharactersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Species.CharactersDescription,
					},
					CharactersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Species?.CharactersName,
						Name = Arguments.ArgumentNames.QuerySearch_Species.CharactersName,
					},
					Classifications = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Species?.Classifications,
						Name = Arguments.ArgumentNames.QuerySearch_Species.Classifications,
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Species?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Species.Description,
					},
					Designations = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Species?.Designations,
						Name = Arguments.ArgumentNames.QuerySearch_Species.Designations,
					},
					EyeColors = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Species?.EyeColors,
						Name = Arguments.ArgumentNames.QuerySearch_Species.EyeColors,
					},
					HairColors = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Species?.HairColors,
						Name = Arguments.ArgumentNames.QuerySearch_Species.HairColors,
					},
					HomeworldDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Species?.HomeworldDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Species.HomeworldDescription,
					},
					HomeworldName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Species?.HomeworldName,
						Name = Arguments.ArgumentNames.QuerySearch_Species.HomeworldName,
					},
					Languages = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Species?.Languages,
						Name = Arguments.ArgumentNames.QuerySearch_Species.Languages,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Species?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Species.Name,
					},
					SkinColors = new QueryArgument(new ArrayGraphType<string>())
					{
						DefaultValue = defaultquery?.Species?.SkinColors,
						Name = Arguments.ArgumentNames.QuerySearch_Species.SkinColors,
					},
				};
				IStarshipsSearchQuery<QueryArgument?> starshipssqueryarguments = new IStarshipsSearchQuery.Default<QueryArgument?>(null)
				{
					CargoCapacities = new QueryArgument(new ArrayGraphType<long>())
					{
						DefaultValue = defaultquery?.Starships?.CargoCapacities,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.CargoCapacities,
					},
					CargoCapacityRangeLower = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Starships?.CargoCapacityRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.CargoCapacityRangeLower,
					},
					CargoCapacityRangeUpper = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Starships?.CargoCapacityRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.CargoCapacityRangeUpper,
					},
					CostInCredits = new QueryArgument(new ArrayGraphType<long>())
					{
						DefaultValue = defaultquery?.Starships?.CostInCredits,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.CostInCredits,
					},
					CostInCreditRangeLower = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Starships?.CostInCreditRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.CostInCreditRangeLower,
					},
					CostInCreditRangeUpper = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Starships?.CostInCreditRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.CostInCreditRangeUpper,
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.Description,
					},
					HyperdriveRatings = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Starships?.HyperdriveRatings,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.HyperdriveRatings,
					},
					HyperdriveRatingRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Starships?.HyperdriveRatingRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeLower,
					},
					HyperdriveRatingRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Starships?.HyperdriveRatingRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeUpper,
					},
					Lengths = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Starships?.Lengths,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.Lengths,
					},
					LengthRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Starships?.LengthRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.LengthRangeLower,
					},
					LengthRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Starships?.LengthRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.LengthRangeUpper,
					},
					ManufacturersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.ManufacturersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.ManufacturersDescription,
					},
					ManufacturersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.ManufacturersName,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.ManufacturersName,
					},
					MaxAtmospheringSpeeds = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Starships?.MaxAtmospheringSpeeds,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeeds,
					},
					MaxAtmospheringSpeedRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MaxAtmospheringSpeedRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeLower,
					},
					MaxAtmospheringSpeedRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MaxAtmospheringSpeedRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeUpper,
					},
					MaxCrews = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Starships?.MaxCrews,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MaxCrews,
					},
					MaxCrewRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MaxCrewRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MaxCrewRangeLower,
					},
					MaxCrewRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MaxCrewRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MaxCrewRangeUpper,
					},
					MinCrews = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Starships?.MinCrews,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MinCrews,
					},
					MinCrewRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MinCrewRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MinCrewRangeLower,
					},
					MinCrewRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MinCrewRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MinCrewRangeUpper,
					},
					MGLTs = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Starships?.MGLTs,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MGLTs,
					},
					MGLTRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MGLTRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MGLTRangeLower,
					},
					MGLTRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.MGLTRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.MGLTRangeUpper,
					},
					Model = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.Model,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.Model,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.Name,
					},
					Passengers = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Starships?.Passengers,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.Passengers,
					},
					PassengerRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.PassengerRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.PassengerRangeLower,
					},
					PassengerRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Starships?.PassengerRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.PassengerRangeUpper,
					},
					PilotsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.PilotsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.PilotsDescription,
					},
					PilotsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.PilotsName,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.PilotsName,
					},
					StarshipClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.StarshipClass,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.StarshipClass,
					},
					StarshipClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Starships?.StarshipClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Starships.StarshipClassFlags,
					},
				};
				IVehiclesSearchQuery<QueryArgument?> vehiclesqueryarguments = new IVehiclesSearchQuery.Default<QueryArgument?>(null)
				{
					CargoCapacities = new QueryArgument(new ArrayGraphType<long>())
					{
						DefaultValue = defaultquery?.Vehicles?.CargoCapacities,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.CargoCapacities,
					},
					CargoCapacityRangeLower = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.CargoCapacityRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeLower,
					},
					CargoCapacityRangeUpper = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.CargoCapacityRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeUpper,
					},
					CostInCredits = new QueryArgument(new ArrayGraphType<long>())
					{
						DefaultValue = defaultquery?.Vehicles?.CostInCredits,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.CostInCredits,
					},
					CostInCreditRangeLower = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.CostInCreditRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeLower,
					},
					CostInCreditRangeUpper = new QueryArgument(new LongGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.CostInCreditRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeUpper,
					},
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.Description,
					},
					Lengths = new QueryArgument(new ArrayGraphType<double>())
					{
						DefaultValue = defaultquery?.Vehicles?.Lengths,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.Lengths,
					},
					LengthRangeLower = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.LengthRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.LengthRangeLower,
					},
					LengthRangeUpper = new QueryArgument(new DoubleGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.LengthRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.LengthRangeUpper,
					},
					ManufacturersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.ManufacturersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.ManufacturersDescription,
					},
					ManufacturersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.ManufacturersName,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.ManufacturersName,
					},
					MaxAtmospheringSpeeds = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Vehicles?.MaxAtmospheringSpeeds,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeeds,
					},
					MaxAtmospheringSpeedRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.MaxAtmospheringSpeedRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeLower,
					},
					MaxAtmospheringSpeedRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.MaxAtmospheringSpeedRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeUpper,
					},
					MaxCrews = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Vehicles?.MaxCrews,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MaxCrews,
					},
					MaxCrewRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.MaxCrewRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeLower,
					},
					MaxCrewRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.MaxCrewRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeUpper,
					},
					MinCrews = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Vehicles?.MinCrews,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MinCrews,
					},
					MinCrewRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.MinCrewRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MinCrewRangeLower,
					},
					MinCrewRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.MinCrewRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.MinCrewRangeUpper,
					},
					Model = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.Model,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.Model,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.Name,
					},
					Passengers = new QueryArgument(new ArrayGraphType<int>())
					{
						DefaultValue = defaultquery?.Vehicles?.Passengers,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.Passengers,
					},
					PassengerRangeLower = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.PassengerRangeLower,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.PassengerRangeLower,
					},
					PassengerRangeUpper = new QueryArgument(new IntGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.PassengerRangeUpper,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.PassengerRangeUpper,
					},
					PilotsDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.PilotsDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.PilotsDescription,
					},
					PilotsName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.PilotsName,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.PilotsName,
					},
					VehicleClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.VehicleClass,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.VehicleClass,
					},
					VehicleClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Vehicles?.VehicleClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Vehicles.VehicleClassFlags,
					},
				};
				IWeaponsSearchQuery<QueryArgument?> weaponsqueryarguments = new IWeaponsSearchQuery.Default<QueryArgument?>(null)
				{
					Description = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.Description,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.Description,
					},
					ManufacturersDescription = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.ManufacturersDescription,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.ManufacturersDescription,
					},
					ManufacturersName = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.ManufacturersName,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.ManufacturersName,
					},
					Model = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.Model,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.Model,
					},
					Name = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.Name,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.Name,
					},
					WeaponClass = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.WeaponClass,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.WeaponClass,
					},
					WeaponClassFlags = new QueryArgument(new BooleanGraphType())
					{
						DefaultValue = defaultquery?.Weapons?.WeaponClassFlags,
						Name = Arguments.ArgumentNames.QuerySearch_Weapons.WeaponClassFlags,
					},
				};

				IEnumerable<QueryArgument> arguments = Enumerable.Empty<QueryArgument?>()
					.Concat(charactersqueryarguments.AsEnumerable())
					.Concat(factionsqueryarguments.AsEnumerable())
					.Concat(filmsqueryarguments.AsEnumerable())
					.Concat(manufacturersqueryarguments.AsEnumerable())
					.Concat(planetsqueryarguments.AsEnumerable())
					.Concat(speciesqueryarguments.AsEnumerable())
					.Concat(starshipssqueryarguments.AsEnumerable())
					.Concat(vehiclesqueryarguments.AsEnumerable())
					.Concat(weaponsqueryarguments.AsEnumerable())
					.Prepend(new QueryArgument(new StringGraphType())
					{
						DefaultValue = null,
						Name = Arguments.ArgumentNames.SearchString,

					}).OfType<QueryArgument>();

				foreach (QueryArgument argument in arguments)
					queryarguments.Add(argument);

				return queryarguments;
			}
			public static string? QueryArgumentsAsString(IQuerySearch arguments)
			{
				bool hasprevious = false;

				StringBuilder stringbuilder = new();

				void AddArguments<T>(string key, params T[] arguments)
				{
					if (hasprevious is true) stringbuilder
							.Append(',');

					switch(arguments.Length)
					{
						case 0:
							break;
						case 1:
							stringbuilder.AppendFormat("{0}: {1}", key, arguments[0]);
							break;
						default:
							stringbuilder.AppendFormat("{0}: [{1}]", key, string.Join(", ", arguments));
							break;
					}

					hasprevious = true;
				}

				if (arguments.SearchString is not null) AddArguments(ArgumentNames.SearchString, arguments.SearchString);

				if (StarWarsModelQuery<IQuerySearchResultGraphType>.Arguments.QueryArgumentsAsString(arguments) is string basequeryargs)
				{
					if (hasprevious is true) stringbuilder
							.Append(',');

					stringbuilder.Append(basequeryargs);

					hasprevious = true;
				}

				if (arguments.Characters is not null)
				{
					if (arguments.SearchString is not null) AddArguments(ArgumentNames.SearchString, arguments.SearchString);
					if (arguments.Characters.BirthYears is not null) AddArguments(ArgumentNames.QuerySearch_Characters.BirthYears, arguments.Characters.BirthYears);
					if (arguments.Characters.BirthYearRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Characters.BirthYearRangeLower, arguments.Characters.BirthYearRangeLower);
					if (arguments.Characters.BirthYearRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Characters.BirthYearRangeUpper, arguments.Characters.BirthYearRangeUpper);
					if (arguments.Characters.Description is not null) AddArguments(ArgumentNames.QuerySearch_Characters.Description, arguments.Characters.Description);
					if (arguments.Characters.EyeColors is not null) AddArguments(ArgumentNames.QuerySearch_Characters.EyeColors, arguments.Characters.EyeColors);
					if (arguments.Characters.HairColors is not null) AddArguments(ArgumentNames.QuerySearch_Characters.HairColors, arguments.Characters.HairColors);
					if (arguments.Characters.Heights is not null) AddArguments(ArgumentNames.QuerySearch_Characters.Heights, arguments.Characters.Heights);
					if (arguments.Characters.HeightRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Characters.HeightRangeLower, arguments.Characters.HeightRangeLower);
					if (arguments.Characters.HeightRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Characters.HeightRangeUpper, arguments.Characters.HeightRangeUpper);
					if (arguments.Characters.HomeworldDescription is not null) AddArguments(ArgumentNames.QuerySearch_Characters.HomeworldDescription, arguments.Characters.HomeworldDescription);
					if (arguments.Characters.HomeworldName is not null) AddArguments(ArgumentNames.QuerySearch_Characters.HomeworldName, arguments.Characters.HomeworldName);
					if (arguments.Characters.Masses is not null) AddArguments(ArgumentNames.QuerySearch_Characters.Masses, arguments.Characters.Masses);
					if (arguments.Characters.MassRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Characters.MassRangeLower, arguments.Characters.MassRangeLower);
					if (arguments.Characters.MassRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Characters.MassRangeUpper, arguments.Characters.MassRangeUpper);
					if (arguments.Characters.Name is not null) AddArguments(ArgumentNames.QuerySearch_Characters.Name, arguments.Characters.Name);
					if (arguments.Characters.Sexes is not null) AddArguments(ArgumentNames.QuerySearch_Characters.Sexes, arguments.Characters.Sexes);
					if (arguments.Characters.SkinColors is not null) AddArguments(ArgumentNames.QuerySearch_Characters.SkinColors, arguments.Characters.SkinColors);
				}
				if (arguments.Factions is not null)
				{
					if (arguments.Factions.AlliedCharactersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Factions.AlliedCharactersDescription, arguments.Factions.AlliedCharactersDescription);
					if (arguments.Factions.AlliedCharactersName is not null) AddArguments(ArgumentNames.QuerySearch_Factions.AlliedCharactersName, arguments.Factions.AlliedCharactersName);
					if (arguments.Factions.AlliedFactionsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Factions.AlliedFactionsDescription, arguments.Factions.AlliedFactionsDescription);
					if (arguments.Factions.AlliedFactionsName is not null) AddArguments(ArgumentNames.QuerySearch_Factions.AlliedFactionsName, arguments.Factions.AlliedFactionsName);
					if (arguments.Factions.Description is not null) AddArguments(ArgumentNames.QuerySearch_Factions.Description, arguments.Factions.Description);
					if (arguments.Factions.LeadersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Factions.LeadersDescription, arguments.Factions.LeadersDescription);
					if (arguments.Factions.LeadersName is not null) AddArguments(ArgumentNames.QuerySearch_Factions.LeadersName, arguments.Factions.LeadersName);
					if (arguments.Factions.MemberCharactersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Factions.MemberCharactersDescription, arguments.Factions.MemberCharactersDescription);
					if (arguments.Factions.MemberCharactersName is not null) AddArguments(ArgumentNames.QuerySearch_Factions.MemberCharactersName, arguments.Factions.MemberCharactersName);
					if (arguments.Factions.MemberFactionsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Factions.MemberFactionsDescription, arguments.Factions.MemberFactionsDescription);
					if (arguments.Factions.MemberFactionsName is not null) AddArguments(ArgumentNames.QuerySearch_Factions.MemberFactionsName, arguments.Factions.MemberFactionsName);
					if (arguments.Factions.Name is not null) AddArguments(ArgumentNames.QuerySearch_Factions.Name, arguments.Factions.Name);
					if (arguments.Factions.OrganizationTypes is not null) AddArguments(ArgumentNames.QuerySearch_Factions.OrganizationTypes, arguments.Factions.OrganizationTypes);
				}
				if (arguments.Films is not null)
				{
					if (arguments.Films.CastMembers is not null) AddArguments(ArgumentNames.QuerySearch_Films.CastMembers, arguments.Films.CastMembers);
					if (arguments.Films.CharactersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.CharactersDescription, arguments.Films.CharactersDescription);
					if (arguments.Films.CharactersName is not null) AddArguments(ArgumentNames.QuerySearch_Films.CharactersName, arguments.Films.CharactersName);
					if (arguments.Films.Description is not null) AddArguments(ArgumentNames.QuerySearch_Films.Description, arguments.Films.Description);
					if (arguments.Films.Director is not null) AddArguments(ArgumentNames.QuerySearch_Films.Director, arguments.Films.Director);
					if (arguments.Films.Durations is not null) AddArguments(ArgumentNames.QuerySearch_Films.Durations, arguments.Films.Durations);
					if (arguments.Films.DurationRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Films.DurationRangeLower, arguments.Films.DurationRangeLower);
					if (arguments.Films.DurationRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Films.DurationRangeUpper, arguments.Films.DurationRangeUpper);
					if (arguments.Films.EpisodeIds is not null) AddArguments(ArgumentNames.QuerySearch_Films.EpisodeIds, arguments.Films.EpisodeIds);
					if (arguments.Films.EpisodeIdRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Films.EpisodeIdRangeLower, arguments.Films.EpisodeIdRangeLower);
					if (arguments.Films.EpisodeIdRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Films.EpisodeIdRangeUpper, arguments.Films.EpisodeIdRangeUpper);
					if (arguments.Films.FactionsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.FactionsDescription, arguments.Films.FactionsDescription);
					if (arguments.Films.FactionsName is not null) AddArguments(ArgumentNames.QuerySearch_Films.FactionsName, arguments.Films.FactionsName);
					if (arguments.Films.ManufacturersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.ManufacturersDescription, arguments.Films.ManufacturersDescription);
					if (arguments.Films.ManufacturersName is not null) AddArguments(ArgumentNames.QuerySearch_Films.ManufacturersName, arguments.Films.ManufacturersName);
					if (arguments.Films.OpeningCrawl is not null) AddArguments(ArgumentNames.QuerySearch_Films.OpeningCrawl, arguments.Films.OpeningCrawl);
					if (arguments.Films.PlanetsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.PlanetsDescription, arguments.Films.PlanetsDescription);
					if (arguments.Films.PlanetsName is not null) AddArguments(ArgumentNames.QuerySearch_Films.PlanetsName, arguments.Films.PlanetsName);
					if (arguments.Films.Producers is not null) AddArguments(ArgumentNames.QuerySearch_Films.Producers, arguments.Films.Producers);
					if (arguments.Films.ReleaseDates is not null) AddArguments(ArgumentNames.QuerySearch_Films.ReleaseDates, arguments.Films.ReleaseDates);
					if (arguments.Films.ReleaseDateRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Films.ReleaseDateRangeLower, arguments.Films.ReleaseDateRangeLower);
					if (arguments.Films.ReleaseDateRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Films.ReleaseDateRangeUpper, arguments.Films.ReleaseDateRangeUpper);
					if (arguments.Films.SpeciesDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.SpeciesDescription, arguments.Films.SpeciesDescription);
					if (arguments.Films.SpeciesName is not null) AddArguments(ArgumentNames.QuerySearch_Films.SpeciesName, arguments.Films.SpeciesName);
					if (arguments.Films.StarshipsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.StarshipsDescription, arguments.Films.StarshipsDescription);
					if (arguments.Films.StarshipsModel is not null) AddArguments(ArgumentNames.QuerySearch_Films.StarshipsModel, arguments.Films.StarshipsModel);
					if (arguments.Films.StarshipsName is not null) AddArguments(ArgumentNames.QuerySearch_Films.StarshipsName, arguments.Films.StarshipsName);
					if (arguments.Films.StarshipsStarshipClass is not null) AddArguments(ArgumentNames.QuerySearch_Films.StarshipsStarshipClass, arguments.Films.StarshipsStarshipClass);
					if (arguments.Films.StarshipsStarshipClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Films.StarshipsStarshipClassFlags, arguments.Films.StarshipsStarshipClassFlags);
					if (arguments.Films.Title is not null) AddArguments(ArgumentNames.QuerySearch_Films.Title, arguments.Films.Title);
					if (arguments.Films.VehiclesDescription is not null) AddArguments(ArgumentNames.QuerySearch_Films.VehiclesDescription, arguments.Films.VehiclesDescription);
					if (arguments.Films.VehiclesModel is not null) AddArguments(ArgumentNames.QuerySearch_Films.VehiclesModel, arguments.Films.VehiclesModel);
					if (arguments.Films.VehiclesName is not null) AddArguments(ArgumentNames.QuerySearch_Films.VehiclesName, arguments.Films.VehiclesName);
					if (arguments.Films.VehiclesVehicleClass is not null) AddArguments(ArgumentNames.QuerySearch_Films.VehiclesVehicleClass, arguments.Films.VehiclesVehicleClass);
					if (arguments.Films.VehiclesVehicleClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Films.VehiclesVehicleClassFlags, arguments.Films.VehiclesVehicleClassFlags);
				}
				if (arguments.Manufacturers is not null)
				{
					if (arguments.Manufacturers.Description is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.Description, arguments.Manufacturers.Description);
					if (arguments.Manufacturers.HeadquatersPlanetDescription is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetDescription, arguments.Manufacturers.HeadquatersPlanetDescription);
					if (arguments.Manufacturers.HeadquatersPlanetName is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.HeadquatersPlanetName, arguments.Manufacturers.HeadquatersPlanetName);
					if (arguments.Manufacturers.Name is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.Name, arguments.Manufacturers.Name);
					if (arguments.Manufacturers.StarshipsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.StarshipsDescription, arguments.Manufacturers.StarshipsDescription);
					if (arguments.Manufacturers.StarshipsModel is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.StarshipsModel, arguments.Manufacturers.StarshipsModel);
					if (arguments.Manufacturers.StarshipsName is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.StarshipsName, arguments.Manufacturers.StarshipsName);
					if (arguments.Manufacturers.StarshipsStarshipClass is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClass, arguments.Manufacturers.StarshipsStarshipClass);
					if (arguments.Manufacturers.StarshipsStarshipClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.StarshipsStarshipClassFlags, arguments.Manufacturers.StarshipsStarshipClassFlags);
					if (arguments.Manufacturers.VehiclesDescription is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.VehiclesDescription, arguments.Manufacturers.VehiclesDescription);
					if (arguments.Manufacturers.VehiclesModel is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.VehiclesModel, arguments.Manufacturers.VehiclesModel);
					if (arguments.Manufacturers.VehiclesName is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.VehiclesName, arguments.Manufacturers.VehiclesName);
					if (arguments.Manufacturers.VehiclesVehicleClass is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClass, arguments.Manufacturers.VehiclesVehicleClass);
					if (arguments.Manufacturers.VehiclesVehicleClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.VehiclesVehicleClassFlags, arguments.Manufacturers.VehiclesVehicleClassFlags);
					if (arguments.Manufacturers.WeaponsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.WeaponsDescription, arguments.Manufacturers.WeaponsDescription);
					if (arguments.Manufacturers.WeaponsModel is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.WeaponsModel, arguments.Manufacturers.WeaponsModel);
					if (arguments.Manufacturers.WeaponsName is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.WeaponsName, arguments.Manufacturers.WeaponsName);
					if (arguments.Manufacturers.WeaponsWeaponClass is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClass, arguments.Manufacturers.WeaponsWeaponClass);
					if (arguments.Manufacturers.WeaponsWeaponClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Manufacturers.WeaponsWeaponClassFlags, arguments.Manufacturers.WeaponsWeaponClassFlags);
				}
				if (arguments.Planets is not null)
				{
					if (arguments.Planets.ClimateTypes is not null) AddArguments(ArgumentNames.QuerySearch_Planets.ClimateTypes, arguments.Planets.ClimateTypes);
					if (arguments.Planets.ClimateFlags is not null) AddArguments(ArgumentNames.QuerySearch_Planets.ClimateFlags, arguments.Planets.ClimateFlags);
					if (arguments.Planets.Description is not null) AddArguments(ArgumentNames.QuerySearch_Planets.Description, arguments.Planets.Description);
					if (arguments.Planets.Diameters is not null) AddArguments(ArgumentNames.QuerySearch_Planets.Diameters, arguments.Planets.Diameters);
					if (arguments.Planets.DiameterRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Planets.DiameterRangeLower, arguments.Planets.DiameterRangeLower);
					if (arguments.Planets.DiameterRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Planets.DiameterRangeUpper, arguments.Planets.DiameterRangeUpper);
					if (arguments.Planets.Gravities is not null) AddArguments(ArgumentNames.QuerySearch_Planets.Gravities, arguments.Planets.Gravities);
					if (arguments.Planets.GravityRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Planets.GravityRangeLower, arguments.Planets.GravityRangeLower);
					if (arguments.Planets.GravityRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Planets.GravityRangeUpper, arguments.Planets.GravityRangeUpper);
					if (arguments.Planets.Name is not null) AddArguments(ArgumentNames.QuerySearch_Planets.Name, arguments.Planets.Name);
					if (arguments.Planets.OrbitalPeriods is not null) AddArguments(ArgumentNames.QuerySearch_Planets.OrbitalPeriods, arguments.Planets.OrbitalPeriods);
					if (arguments.Planets.OrbitalPeriodRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeLower, arguments.Planets.OrbitalPeriodRangeLower);
					if (arguments.Planets.OrbitalPeriodRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Planets.OrbitalPeriodRangeUpper, arguments.Planets.OrbitalPeriodRangeUpper);
					if (arguments.Planets.Populations is not null) AddArguments(ArgumentNames.QuerySearch_Planets.Populations, arguments.Planets.Populations);
					if (arguments.Planets.PopulationRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Planets.PopulationRangeLower, arguments.Planets.PopulationRangeLower);
					if (arguments.Planets.PopulationRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Planets.PopulationRangeUpper, arguments.Planets.PopulationRangeUpper);
					if (arguments.Planets.ResidentsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Planets.ResidentsDescription, arguments.Planets.ResidentsDescription);
					if (arguments.Planets.ResidentsName is not null) AddArguments(ArgumentNames.QuerySearch_Planets.ResidentsName, arguments.Planets.ResidentsName);
					if (arguments.Planets.RotationalPeriods is not null) AddArguments(ArgumentNames.QuerySearch_Planets.RotationalPeriods, arguments.Planets.RotationalPeriods);
					if (arguments.Planets.RotationalPeriodRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeLower, arguments.Planets.RotationalPeriodRangeLower);
					if (arguments.Planets.RotationalPeriodRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Planets.RotationalPeriodRangeUpper, arguments.Planets.RotationalPeriodRangeUpper);
					if (arguments.Planets.SurfaceWaters is not null) AddArguments(ArgumentNames.QuerySearch_Planets.SurfaceWaters, arguments.Planets.SurfaceWaters);
					if (arguments.Planets.SurfaceWaterRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeLower, arguments.Planets.SurfaceWaterRangeLower);
					if (arguments.Planets.SurfaceWaterRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Planets.SurfaceWaterRangeUpper, arguments.Planets.SurfaceWaterRangeUpper);
					if (arguments.Planets.TerrainTypes is not null) AddArguments(ArgumentNames.QuerySearch_Planets.TerrainTypes, arguments.Planets.TerrainTypes);
					if (arguments.Planets.TerrainFlags is not null) AddArguments(ArgumentNames.QuerySearch_Planets.TerrainFlags, arguments.Planets.TerrainFlags);
				}
				if (arguments.Species is not null)
				{
					if (arguments.Species.AverageHeights is not null) AddArguments(ArgumentNames.QuerySearch_Species.AverageHeights, arguments.Species.AverageHeights);
					if (arguments.Species.AverageHeightRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Species.AverageHeightRangeLower, arguments.Species.AverageHeightRangeLower);
					if (arguments.Species.AverageHeightRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Species.AverageHeightRangeUpper, arguments.Species.AverageHeightRangeUpper);
					if (arguments.Species.AverageLifespans is not null) AddArguments(ArgumentNames.QuerySearch_Species.AverageLifespans, arguments.Species.AverageLifespans);
					if (arguments.Species.AverageLifespanRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Species.AverageLifespanRangeLower, arguments.Species.AverageLifespanRangeLower);
					if (arguments.Species.AverageLifespanRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Species.AverageLifespanRangeUpper, arguments.Species.AverageLifespanRangeUpper);
					if (arguments.Species.CharactersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Species.CharactersDescription, arguments.Species.CharactersDescription);
					if (arguments.Species.CharactersName is not null) AddArguments(ArgumentNames.QuerySearch_Species.CharactersName, arguments.Species.CharactersName);
					if (arguments.Species.Classifications is not null) AddArguments(ArgumentNames.QuerySearch_Species.Classifications, arguments.Species.Classifications);
					if (arguments.Species.Description is not null) AddArguments(ArgumentNames.QuerySearch_Species.Description, arguments.Species.Description);
					if (arguments.Species.Designations is not null) AddArguments(ArgumentNames.QuerySearch_Species.Designations, arguments.Species.Designations);
					if (arguments.Species.EyeColors is not null) AddArguments(ArgumentNames.QuerySearch_Species.EyeColors, arguments.Species.EyeColors);
					if (arguments.Species.HairColors is not null) AddArguments(ArgumentNames.QuerySearch_Species.HairColors, arguments.Species.HairColors);
					if (arguments.Species.HomeworldDescription is not null) AddArguments(ArgumentNames.QuerySearch_Species.HomeworldDescription, arguments.Species.HomeworldDescription);
					if (arguments.Species.HomeworldName is not null) AddArguments(ArgumentNames.QuerySearch_Species.HomeworldName, arguments.Species.HomeworldName);
					if (arguments.Species.Languages is not null) AddArguments(ArgumentNames.QuerySearch_Species.Languages, arguments.Species.Languages);
					if (arguments.Species.Name is not null) AddArguments(ArgumentNames.QuerySearch_Species.Name, arguments.Species.Name);
					if (arguments.Species.SkinColors is not null) AddArguments(ArgumentNames.QuerySearch_Species.SkinColors, arguments.Species.SkinColors);
				}
				if (arguments.Starships is not null)
				{
					if (arguments.Starships.CargoCapacities is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CargoCapacities, arguments.Starships.CargoCapacities);
					if (arguments.Starships.CargoCapacityRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CargoCapacityRangeLower, arguments.Starships.CargoCapacityRangeLower);
					if (arguments.Starships.CargoCapacityRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CargoCapacityRangeUpper, arguments.Starships.CargoCapacityRangeUpper);
					if (arguments.Starships.Consumables is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CostInCredits, arguments.Starships.Consumables);
					if (arguments.Starships.ConsumableRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CostInCreditRangeLower, arguments.Starships.ConsumableRangeLower);
					if (arguments.Starships.ConsumableRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CostInCreditRangeUpper, arguments.Starships.ConsumableRangeUpper);					  
					if (arguments.Starships.CostInCredits is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CostInCredits, arguments.Starships.CostInCredits);
					if (arguments.Starships.CostInCreditRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CostInCreditRangeLower, arguments.Starships.CostInCreditRangeLower);
					if (arguments.Starships.CostInCreditRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.CostInCreditRangeUpper, arguments.Starships.CostInCreditRangeUpper);
					if (arguments.Starships.Description is not null) AddArguments(ArgumentNames.QuerySearch_Starships.Description, arguments.Starships.Description);
					if (arguments.Starships.HyperdriveRatings is not null) AddArguments(ArgumentNames.QuerySearch_Starships.HyperdriveRatings, arguments.Starships.HyperdriveRatings);
					if (arguments.Starships.HyperdriveRatingRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeLower, arguments.Starships.HyperdriveRatingRangeLower);
					if (arguments.Starships.HyperdriveRatingRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.HyperdriveRatingRangeUpper, arguments.Starships.HyperdriveRatingRangeUpper);
					if (arguments.Starships.Lengths is not null) AddArguments(ArgumentNames.QuerySearch_Starships.Lengths, arguments.Starships.Lengths);
					if (arguments.Starships.LengthRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.LengthRangeLower, arguments.Starships.LengthRangeLower);
					if (arguments.Starships.LengthRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.LengthRangeUpper, arguments.Starships.LengthRangeUpper);
					if (arguments.Starships.ManufacturersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Starships.ManufacturersDescription, arguments.Starships.ManufacturersDescription);
					if (arguments.Starships.ManufacturersName is not null) AddArguments(ArgumentNames.QuerySearch_Starships.ManufacturersName, arguments.Starships.ManufacturersName);
					if (arguments.Starships.MaxAtmospheringSpeeds is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeeds, arguments.Starships.MaxAtmospheringSpeeds);
					if (arguments.Starships.MaxAtmospheringSpeedRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeLower, arguments.Starships.MaxAtmospheringSpeedRangeLower);
					if (arguments.Starships.MaxAtmospheringSpeedRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MaxAtmospheringSpeedRangeUpper, arguments.Starships.MaxAtmospheringSpeedRangeUpper);
					if (arguments.Starships.MaxCrews is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MaxCrews, arguments.Starships.MaxCrews);
					if (arguments.Starships.MaxCrewRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MaxCrewRangeLower, arguments.Starships.MaxCrewRangeLower);
					if (arguments.Starships.MaxCrewRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MaxCrewRangeUpper, arguments.Starships.MaxCrewRangeUpper);
					if (arguments.Starships.MinCrews is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MinCrews, arguments.Starships.MinCrews);
					if (arguments.Starships.MinCrewRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MinCrewRangeLower, arguments.Starships.MinCrewRangeLower);
					if (arguments.Starships.MinCrewRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MinCrewRangeUpper, arguments.Starships.MinCrewRangeUpper);
					if (arguments.Starships.MGLTs is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MGLTs, arguments.Starships.MGLTs);
					if (arguments.Starships.MGLTRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MGLTRangeLower, arguments.Starships.MGLTRangeLower);
					if (arguments.Starships.MGLTRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.MGLTRangeUpper, arguments.Starships.MGLTRangeUpper);
					if (arguments.Starships.Model is not null) AddArguments(ArgumentNames.QuerySearch_Starships.Model, arguments.Starships.Model);
					if (arguments.Starships.Name is not null) AddArguments(ArgumentNames.QuerySearch_Starships.Name, arguments.Starships.Name);
					if (arguments.Starships.Passengers is not null) AddArguments(ArgumentNames.QuerySearch_Starships.Passengers, arguments.Starships.Passengers);
					if (arguments.Starships.PassengerRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Starships.PassengerRangeLower, arguments.Starships.PassengerRangeLower);
					if (arguments.Starships.PassengerRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Starships.PassengerRangeUpper, arguments.Starships.PassengerRangeUpper);
					if (arguments.Starships.PilotsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Starships.PilotsDescription, arguments.Starships.PilotsDescription);
					if (arguments.Starships.PilotsName is not null) AddArguments(ArgumentNames.QuerySearch_Starships.PilotsName, arguments.Starships.PilotsName);
					if (arguments.Starships.StarshipClass is not null) AddArguments(ArgumentNames.QuerySearch_Starships.StarshipClass, arguments.Starships.StarshipClass);
					if (arguments.Starships.StarshipClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Starships.StarshipClassFlags, arguments.Starships.StarshipClassFlags);
				}
				if (arguments.Vehicles is not null)
				{
					if (arguments.Vehicles.CargoCapacities is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CargoCapacities, arguments.Vehicles.CargoCapacities);
					if (arguments.Vehicles.CargoCapacityRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeLower, arguments.Vehicles.CargoCapacityRangeLower);
					if (arguments.Vehicles.CargoCapacityRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CargoCapacityRangeUpper, arguments.Vehicles.CargoCapacityRangeUpper);
					if (arguments.Vehicles.Consumables is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CostInCredits, arguments.Vehicles.Consumables);
					if (arguments.Vehicles.ConsumableRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeLower, arguments.Vehicles.ConsumableRangeLower);
					if (arguments.Vehicles.ConsumableRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeUpper, arguments.Vehicles.ConsumableRangeUpper);				 
					if (arguments.Vehicles.CostInCredits is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CostInCredits, arguments.Vehicles.CostInCredits);
					if (arguments.Vehicles.CostInCreditRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeLower, arguments.Vehicles.CostInCreditRangeLower);
					if (arguments.Vehicles.CostInCreditRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.CostInCreditRangeUpper, arguments.Vehicles.CostInCreditRangeUpper);
					if (arguments.Vehicles.Description is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.Description, arguments.Vehicles.Description);
					if (arguments.Vehicles.Lengths is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.Lengths, arguments.Vehicles.Lengths);
					if (arguments.Vehicles.LengthRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.LengthRangeLower, arguments.Vehicles.LengthRangeLower);
					if (arguments.Vehicles.LengthRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.LengthRangeUpper, arguments.Vehicles.LengthRangeUpper);
					if (arguments.Vehicles.ManufacturersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.ManufacturersDescription, arguments.Vehicles.ManufacturersDescription);
					if (arguments.Vehicles.ManufacturersName is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.ManufacturersName, arguments.Vehicles.ManufacturersName);
					if (arguments.Vehicles.MaxAtmospheringSpeeds is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeeds, arguments.Vehicles.MaxAtmospheringSpeeds);
					if (arguments.Vehicles.MaxAtmospheringSpeedRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeLower, arguments.Vehicles.MaxAtmospheringSpeedRangeLower);
					if (arguments.Vehicles.MaxAtmospheringSpeedRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MaxAtmospheringSpeedRangeUpper, arguments.Vehicles.MaxAtmospheringSpeedRangeUpper);
					if (arguments.Vehicles.MaxCrews is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MaxCrews, arguments.Vehicles.MaxCrews);
					if (arguments.Vehicles.MaxCrewRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeLower, arguments.Vehicles.MaxCrewRangeLower);
					if (arguments.Vehicles.MaxCrewRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MaxCrewRangeUpper, arguments.Vehicles.MaxCrewRangeUpper);
					if (arguments.Vehicles.MinCrews is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MinCrews, arguments.Vehicles.MinCrews);
					if (arguments.Vehicles.MinCrewRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MinCrewRangeLower, arguments.Vehicles.MinCrewRangeLower);
					if (arguments.Vehicles.MinCrewRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.MinCrewRangeUpper, arguments.Vehicles.MinCrewRangeUpper);
					if (arguments.Vehicles.Model is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.Model, arguments.Vehicles.Model);
					if (arguments.Vehicles.Name is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.Name, arguments.Vehicles.Name);
					if (arguments.Vehicles.Passengers is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.Passengers, arguments.Vehicles.Passengers);
					if (arguments.Vehicles.PassengerRangeLower is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.PassengerRangeLower, arguments.Vehicles.PassengerRangeLower);
					if (arguments.Vehicles.PassengerRangeUpper is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.PassengerRangeUpper, arguments.Vehicles.PassengerRangeUpper);
					if (arguments.Vehicles.PilotsDescription is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.PilotsDescription, arguments.Vehicles.PilotsDescription);
					if (arguments.Vehicles.PilotsName is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.PilotsName, arguments.Vehicles.PilotsName);
					if (arguments.Vehicles.VehicleClass is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.VehicleClass, arguments.Vehicles.VehicleClass);
					if (arguments.Vehicles.VehicleClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Vehicles.VehicleClassFlags, arguments.Vehicles.VehicleClassFlags);
				}
				if (arguments.Weapons is not null)
				{
					if (arguments.Weapons.Description is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.Description, arguments.Weapons.Description);
					if (arguments.Weapons.ManufacturersDescription is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.ManufacturersDescription, arguments.Weapons.ManufacturersDescription);
					if (arguments.Weapons.ManufacturersName is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.ManufacturersName, arguments.Weapons.ManufacturersName);
					if (arguments.Weapons.Model is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.Model, arguments.Weapons.Model);
					if (arguments.Weapons.Name is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.Name, arguments.Weapons.Name);
					if (arguments.Weapons.WeaponClass is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.WeaponClass, arguments.Weapons.WeaponClass);
					if (arguments.Weapons.WeaponClassFlags is not null) AddArguments(ArgumentNames.QuerySearch_Weapons.WeaponClassFlags, arguments.Weapons.WeaponClassFlags);
				}

				if (hasprevious is false)
					return null;

				return stringbuilder.ToString();
			}
		}
	}
}
