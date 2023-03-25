using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class FactionsSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_AlliedCharactersDescription = nameof(IFactionsSearchQuery.AlliedCharactersDescription);
		public const string Id_AlliedCharactersName = nameof(IFactionsSearchQuery.AlliedCharactersName);
		public const string Id_AlliedFactionsDescription = nameof(IFactionsSearchQuery.AlliedFactionsDescription);
		public const string Id_AlliedFactionsName = nameof(IFactionsSearchQuery.AlliedFactionsName);
		public const string Id_Description = nameof(IFactionsSearchQuery.Description);
		public const string Id_LeadersDescription = nameof(IFactionsSearchQuery.LeadersDescription);
		public const string Id_LeadersName = nameof(IFactionsSearchQuery.LeadersName);
		public const string Id_MemberCharactersDescription = nameof(IFactionsSearchQuery.MemberCharactersDescription);
		public const string Id_MemberCharactersName = nameof(IFactionsSearchQuery.MemberCharactersName);
		public const string Id_MemberFactionsDescription = nameof(IFactionsSearchQuery.MemberFactionsDescription);
		public const string Id_MemberFactionsName = nameof(IFactionsSearchQuery.MemberFactionsName);
		public const string Id_Name = nameof(IFactionsSearchQuery.Name);
		public const string Id_OrganizationTypes = nameof(IFactionsSearchQuery.OrganizationTypes);

		public new static IFactionsSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();
			
			return new IFactionsSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				AlliedCharactersDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AlliedCharactersDescription;
					swaggerschema.Name = "AlliedCharactersDescription";
				}), 
				AlliedCharactersName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AlliedCharactersName;
					swaggerschema.Name = "AlliedCharactersName";
				}), 
				AlliedFactionsDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AlliedFactionsDescription;
					swaggerschema.Name = "AlliedFactionsDescription";
				}), 
				AlliedFactionsName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_AlliedFactionsName;
					swaggerschema.Name = "AlliedFactionsName";
				}), 
				Description = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
				}), 
				LeadersDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_LeadersDescription;
					swaggerschema.Name = "LeadersDescription";
				}), 
				LeadersName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_LeadersName;
					swaggerschema.Name = "LeadersName";
				}), 
				MemberCharactersDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MemberCharactersDescription;
					swaggerschema.Name = "MemberCharactersDescription";
				}), 
				MemberCharactersName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MemberCharactersName;
					swaggerschema.Name = "MemberCharactersName";
				}), 
				MemberFactionsDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MemberFactionsDescription;
					swaggerschema.Name = "MemberFactionsDescription";
				}), 
				MemberFactionsName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_MemberFactionsName;
					swaggerschema.Name = "MemberFactionsName";
				}), 
				Name = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Name;
					swaggerschema.Name = "Name";
				}), 
				OrganizationTypes = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_OrganizationTypes;
					swaggerschema.Name = "OrganizationTypes";
				}), 
			};
		} 
	}
}
