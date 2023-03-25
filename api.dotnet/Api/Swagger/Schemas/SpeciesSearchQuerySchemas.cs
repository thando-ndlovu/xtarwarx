using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class SpeciesSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_AverageHeights = nameof(ISpeciesSearchQuery.AverageHeights);
		public const string Id_AverageHeightRangeLower = nameof(ISpeciesSearchQuery.AverageHeightRangeLower);
		public const string Id_AverageHeightRangeUpper = nameof(ISpeciesSearchQuery.AverageHeightRangeUpper);
		public const string Id_AverageLifespans = nameof(ISpeciesSearchQuery.AverageLifespans);
		public const string Id_AverageLifespanRangeLower = nameof(ISpeciesSearchQuery.AverageLifespanRangeLower);
		public const string Id_AverageLifespanRangeUpper = nameof(ISpeciesSearchQuery.AverageLifespanRangeUpper);
		public const string Id_CharactersDescription = nameof(ISpeciesSearchQuery.CharactersDescription);
		public const string Id_CharactersName = nameof(ISpeciesSearchQuery.CharactersName);
		public const string Id_Classifications = nameof(ISpeciesSearchQuery.Classifications);
		public const string Id_Description = nameof(ISpeciesSearchQuery.Description);
		public const string Id_Designations = nameof(ISpeciesSearchQuery.Designations);
		public const string Id_EyeColors = nameof(ISpeciesSearchQuery.EyeColors);
		public const string Id_HairColors = nameof(ISpeciesSearchQuery.HairColors);
		public const string Id_HomeworldDescription = nameof(ISpeciesSearchQuery.HomeworldDescription);
		public const string Id_HomeworldName = nameof(ISpeciesSearchQuery.HomeworldName);
		public const string Id_Languages = nameof(ISpeciesSearchQuery.Languages);
		public const string Id_Name = nameof(ISpeciesSearchQuery.Name);
		public const string Id_SkinColors = nameof(ISpeciesSearchQuery.SkinColors);

		public new static ISpeciesSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new ISpeciesSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				AverageHeights = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AverageHeights;
					swaggerschema.Name = "AverageHeights";
				}),
				AverageHeightRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AverageHeightRangeLower;
					swaggerschema.Name = "AverageHeightRangeLower";
				}),
				AverageHeightRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_AverageHeightRangeUpper;
					swaggerschema.Name = "AverageHeightRangeUpper";
				}),
				AverageLifespans = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AverageLifespans;
					swaggerschema.Name = "AverageLifespans";
				}),
				AverageLifespanRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AverageLifespanRangeLower;
					swaggerschema.Name = "AverageLifespanRangeLower";
				}),
				AverageLifespanRangeUpper = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AverageLifespanRangeUpper;
					swaggerschema.Name = "AverageLifespanRangeUpper";
				}),
				CharactersDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_CharactersDescription;
					swaggerschema.Name = "CharactersDescription";
				}),
				CharactersName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_CharactersName;
					swaggerschema.Name = "CharactersName";
				}),
				Classifications = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Classifications;
					swaggerschema.Name = "Classifications";
				}),
				Description = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
				}),
				Designations = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Designations;
					swaggerschema.Name = "Designations";
				}),
				EyeColors = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_EyeColors;
					swaggerschema.Name = "EyeColors";
				}),
				HairColors = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HairColors;
					swaggerschema.Name = "HairColors";
				}),
				HomeworldDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HomeworldDescription;
					swaggerschema.Name = "HomeworldDescription";
				}),
				HomeworldName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HomeworldName;
					swaggerschema.Name = "HomeworldName";
				}),
				Languages = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Languages;
					swaggerschema.Name = "Languages";
				}),
				Name = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Name;
					swaggerschema.Name = "Name";
				}),
				SkinColors = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_SkinColors;
					swaggerschema.Name = "SkinColors";
				}),
			};
		} 
	}
}
