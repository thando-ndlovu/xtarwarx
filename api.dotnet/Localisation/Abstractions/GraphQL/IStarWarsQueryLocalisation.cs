
namespace Localisation.Abstractions.GraphQL
{
	public interface IStarWarsQueryLocalisation<T>
	{
		T Name { get; set; }
		T Description { get; set; }	 
		T CharactersName { get; set; }
		T CharactersDescription { get; set; }
		T FactionsName { get; set; }
		T FactionsDescription { get; set; }
		T FilmsName { get; set; }
		T FilmsDescription { get; set; }
		T ManufacturersName { get; set; }
		T ManufacturersDescription { get; set; }
		T PlanetsName { get; set; }
		T PlanetsDescription { get; set; }
		T SpeciesName { get; set; }
		T SpeciesDescription { get; set; }
		T StarshipsName { get; set; }
		T StarshipsDescription { get; set; }
		T VehiclesName { get; set; }
		T VehiclesDescription { get; set; }
		T WeaponsName { get; set; }
		T WeaponsDescription { get; set; }
	}
	public interface IStarWarsQueryLocalisation
	{
		string? Name { get; set; }
		string? Description { get; set; }
		string? CharactersName { get; set; }
		string? CharactersDescription { get; set; }
		string? FactionsName { get; set; }
		string? FactionsDescription { get; set; }
		string? FilmsName { get; set; }
		string? FilmsDescription { get; set; }
		string? ManufacturersName { get; set; }
		string? ManufacturersDescription { get; set; }
		string? PlanetsName { get; set; }
		string? PlanetsDescription { get; set; }
		string? SpeciesName { get; set; }
		string? SpeciesDescription { get; set; }
		string? StarshipsName { get; set; }
		string? StarshipsDescription { get; set; }
		string? VehiclesName { get; set; }
		string? VehiclesDescription { get; set; }
		string? WeaponsName { get; set; }
		string? WeaponsDescription { get; set; }

		#region Defaults

		public class Default : IStarWarsQueryLocalisation
		{
			public string? Name { get; set; }
			public string? Description { get; set; }	 
			public string? CharactersName { get; set; }
			public string? CharactersDescription { get; set; }
			public string? FactionsName { get; set; }
			public string? FactionsDescription { get; set; }
			public string? FilmsName { get; set; }
			public string? FilmsDescription { get; set; }
			public string? ManufacturersName { get; set; }
			public string? ManufacturersDescription { get; set; }
			public string? PlanetsName { get; set; }
			public string? PlanetsDescription { get; set; }
			public string? SpeciesName { get; set; }
			public string? SpeciesDescription { get; set; }
			public string? StarshipsName { get; set; }
			public string? StarshipsDescription { get; set; }
			public string? VehiclesName { get; set; }
			public string? VehiclesDescription { get; set; }
			public string? WeaponsName { get; set; }
			public string? WeaponsDescription { get; set; }
		}
		public class Default<T> : IStarWarsQueryLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				Name = defaultvalue;
				Description = defaultvalue;	  
				CharactersName = defaultvalue;
				CharactersDescription = defaultvalue;
				FactionsName = defaultvalue;
				FactionsDescription = defaultvalue;
				FilmsName = defaultvalue;
				FilmsDescription = defaultvalue;
				ManufacturersName = defaultvalue;
				ManufacturersDescription = defaultvalue;
				PlanetsName = defaultvalue;
				PlanetsDescription = defaultvalue;
				SpeciesName = defaultvalue;
				SpeciesDescription = defaultvalue;
				StarshipsName = defaultvalue;
				StarshipsDescription = defaultvalue;
				VehiclesName = defaultvalue;
				VehiclesDescription = defaultvalue;
				WeaponsName = defaultvalue;
				WeaponsDescription = defaultvalue;
			}

			public T Name { get; set; }
			public T Description { get; set; } 
			public T CharactersName { get; set; }
			public T CharactersDescription { get; set; }
			public T FactionsName { get; set; }
			public T FactionsDescription { get; set; }
			public T FilmsName { get; set; }
			public T FilmsDescription { get; set; }
			public T ManufacturersName { get; set; }
			public T ManufacturersDescription { get; set; }
			public T PlanetsName { get; set; }
			public T PlanetsDescription { get; set; }
			public T SpeciesName { get; set; }
			public T SpeciesDescription { get; set; }
			public T StarshipsName { get; set; }
			public T StarshipsDescription { get; set; }
			public T VehiclesName { get; set; }
			public T VehiclesDescription { get; set; }
			public T WeaponsName { get; set; }
			public T WeaponsDescription { get; set; }
		}

		#endregion
	}
}
