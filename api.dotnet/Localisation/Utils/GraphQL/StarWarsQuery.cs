using Localisation.Abstractions.GraphQL;

namespace Localisation.Utils.GraphQL
{
	public class StarWarsQuery
	{
		public const string ResourceName = "GraphQL.StarWarsQuery";

		public static readonly IStarWarsQueryLocalisation<string> Keys = new IStarWarsQueryLocalisation.Default<string>(string.Empty)
		{
			Description = "StarWarsQuery_Description",
			Name = "StarWarsQuery_Name",   
			CharactersDescription = "StarWarsQuery_CharactersDescription",
			CharactersName = "StarWarsQuery_CharactersName",
			FactionsDescription = "StarWarsQuery_FactionsDescription",
			FactionsName = "StarWarsQuery_FactionsName",
			FilmsDescription = "StarWarsQuery_FilmsDescription",
			FilmsName = "StarWarsQuery_FilmsName",
			ManufacturersDescription = "StarWarsQuery_ManufacturersDescription",
			ManufacturersName = "StarWarsQuery_ManufacturersName",
			PlanetsDescription = "StarWarsQuery_PlanetsDescription",
			PlanetsName = "StarWarsQuery_PlanetsName",
			SpeciesDescription = "StarWarsQuery_SpeciesDescription",
			SpeciesName = "StarWarsQuery_SpeciesName",
			StarshipsDescription = "StarWarsQuery_StarshipsDescription",
			StarshipsName = "StarWarsQuery_StarshipsName",
			VehiclesDescription = "StarWarsQuery_VehiclesDescription",
			VehiclesName = "StarWarsQuery_VehiclesName",
			WeaponsDescription = "StarWarsQuery_WeaponsDescription",
			WeaponsName = "StarWarsQuery_WeaponsName",
		};
	}

	public static class StarWarsQueryExtensions
	{
		public static IStarWarsQueryLocalisation? GetStarWarsQuery(this LocalisationResourceManager? localisationResourceManager, IStarWarsQueryLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarWarsQueryLocalisation.Default
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.Name) : null,			 
					CharactersDescription = retriever?.CharactersDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.CharactersDescription) : null,
					CharactersName = retriever?.CharactersName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.CharactersName) : null,	
					FactionsDescription = retriever?.FactionsDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.FactionsDescription) : null,
					FactionsName = retriever?.FactionsName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.FactionsName) : null,	
					FilmsDescription = retriever?.FilmsDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.FilmsDescription) : null,
					FilmsName = retriever?.FilmsName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.FilmsName) : null,	
					ManufacturersDescription = retriever?.ManufacturersDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.ManufacturersDescription) : null,
					ManufacturersName = retriever?.ManufacturersName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.ManufacturersName) : null,	
					PlanetsDescription = retriever?.PlanetsDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.PlanetsDescription) : null,
					PlanetsName = retriever?.PlanetsName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.PlanetsName) : null,	
					SpeciesDescription = retriever?.SpeciesDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.SpeciesDescription) : null,
					SpeciesName = retriever?.SpeciesName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.SpeciesName) : null,	
					StarshipsDescription = retriever?.StarshipsDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.StarshipsDescription) : null,
					StarshipsName = retriever?.StarshipsName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.StarshipsName) : null,	
					VehiclesDescription = retriever?.VehiclesDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.VehiclesDescription) : null,
					VehiclesName = retriever?.VehiclesName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.VehiclesName) : null,	
					WeaponsDescription = retriever?.WeaponsDescription ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.WeaponsDescription) : null,
					WeaponsName = retriever?.WeaponsName ?? true ? localisationResourceManager.GetString(StarWarsQuery.Keys.WeaponsName) : null,
				};
	}
}
