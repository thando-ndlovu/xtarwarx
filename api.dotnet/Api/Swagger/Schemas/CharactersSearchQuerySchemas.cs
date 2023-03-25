using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class CharactersSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_BirthYears = nameof(ICharactersSearchQuery.BirthYears);
		public const string Id_BirthYearRangeLower = nameof(ICharactersSearchQuery.BirthYearRangeLower);
		public const string Id_BirthYearRangeUpper = nameof(ICharactersSearchQuery.BirthYearRangeUpper);
		public const string Id_Description = nameof(ICharactersSearchQuery.Description);
		public const string Id_EyeColors = nameof(ICharactersSearchQuery.EyeColors);
		public const string Id_HairColors = nameof(ICharactersSearchQuery.HairColors);
		public const string Id_Heights = nameof(ICharactersSearchQuery.Heights);
		public const string Id_HeightRangeLower = nameof(ICharactersSearchQuery.HeightRangeLower);
		public const string Id_HeightRangeUpper = nameof(ICharactersSearchQuery.HeightRangeUpper);
		public const string Id_HomeworldDescription = nameof(ICharactersSearchQuery.HomeworldDescription);
		public const string Id_HomeworldName = nameof(ICharactersSearchQuery.HomeworldName);
		public const string Id_Masses = nameof(ICharactersSearchQuery.Masses);
		public const string Id_MassRangeLower = nameof(ICharactersSearchQuery.MassRangeLower);
		public const string Id_MassRangeUpper = nameof(ICharactersSearchQuery.MassRangeUpper);
		public const string Id_Name = nameof(ICharactersSearchQuery.Name);
		public const string Id_Sexes = nameof(ICharactersSearchQuery.Sexes);
		public const string Id_SkinColors = nameof(ICharactersSearchQuery.SkinColors);

		public new static ICharactersSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new ICharactersSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				BirthYears = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_BirthYears;
					swaggerschema.Name = "BirthYears";
				}), 
				BirthYearRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_BirthYearRangeLower;
					swaggerschema.Name = "BirthYearRangeLower";
				}), 
				BirthYearRangeUpper = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_BirthYearRangeUpper;
					swaggerschema.Name = "BirthYearRangeUpper";
				}), 
				Description = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
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
				Heights = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Heights;
					swaggerschema.Name = "Heights";
				}), 
				HeightRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HeightRangeLower;
					swaggerschema.Name = "HeightRangeLower";
				}), 
				HeightRangeUpper = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HeightRangeUpper;
					swaggerschema.Name = "HeightRangeUpper";
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
				Masses = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Masses;
					swaggerschema.Name = "Masses";
				}), 
				MassRangeLower = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MassRangeLower;
					swaggerschema.Name = "MassRangeLower";
				}), 
				MassRangeUpper = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MassRangeUpper;
					swaggerschema.Name = "MassRangeUpper";
				}), 
				Name = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Name;
					swaggerschema.Name = "Name";
				}), 
				Sexes = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Sexes;
					swaggerschema.Name = "Sexes";
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
