using Api.Queries;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class QuerySchemas : BaseSchemas
	{
		public const string Query_Id_Ids = nameof(IQuery.Ids); 
		public const string Query_Id_IdsToSkip = nameof(IQuery.IdsToSkip); 
		public const string Query_Id_ItemsPerPage = nameof(IQuery.ItemsPerPage); 
		public const string Query_Id_OrderBy = nameof(IQuery.OrderBy); 
		public const string Query_Id_Page = nameof(IQuery.Page); 					 

		public const string QueryMeta_Id_AdditionsSince = nameof(IQueryMeta.AdditionsSince); 
		public const string QueryMeta_Id_EditsSince = nameof(IQueryMeta.EditsSince); 

		public static IQuery<SwaggerSchema?> Query()
		{
			return new IQuery.Default<SwaggerSchema?>(null)
			{
				Ids = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Query_Id_Ids;
					swaggerschema.Name = "Ids";
				}),	   
				IdsToSkip = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Query_Id_IdsToSkip;
					swaggerschema.Name = "IdsToSkip";
				}),
				ItemsPerPage = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Query_Id_ItemsPerPage;
					swaggerschema.Name = "ItemsPerPage";
				}),
				OrderBy = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Query_Id_OrderBy;
					swaggerschema.Name = "OrderBy";
				}),
				Page = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Query_Id_Page;
					swaggerschema.Name = "Page";
				}),
			};
		} 
		public static IQueryMeta<SwaggerSchema?> QueryMeta()
		{
			return new IQueryMeta.Default<SwaggerSchema?>(null)
			{
				AdditionsSince = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = QueryMeta_Id_AdditionsSince;
					swaggerschema.Name = "AdditionsSince";
				}),
				EditsSince = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = QueryMeta_Id_EditsSince;
					swaggerschema.Name = "EditsSince";
				}),
			};
		}
	}
}
