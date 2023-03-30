using System.Collections.Generic;
using System.Linq;

namespace Api
{
	public class Routes
	{
		public const string HttpBaseAddress = "http://*:5000";
		public const string HttpsBaseAddress = "https://*:5001";
		
		public const string Api_GraphQL = "/Api/GraphQL";
		public const string Api_Rest = "/Api/Rest";

		public const string Api_Rest_Characters = Api_Rest + Path_Characters;
		public const string Api_Rest_Factions = Api_Rest + Path_Factions;
		public const string Api_Rest_Films = Api_Rest + Path_Films;
		public const string Api_Rest_Manufacturers = Api_Rest + Path_Manufacturers;
		public const string Api_Rest_Planets = Api_Rest + Path_Planets;
		public const string Api_Rest_Search = Api_Rest + Path_Search;
		public const string Api_Rest_Species = Api_Rest + Path_Species;
		public const string Api_Rest_Starships = Api_Rest + Path_Starships;
		public const string Api_Rest_Vehicles = Api_Rest + Path_Vehicles;
		public const string Api_Rest_Weapons = Api_Rest + Path_Weapons;
		
		public const string Api_Rest_Meta = Api_Rest + Path_Meta;

		public const string Home = "/Home";

		public const string GraphQL = "/GraphQL";
		public const string GraphQL_Altair = GraphQL + "/Altair";
		public const string GraphQL_GraphiQL = GraphQL + "/GraphiQL";
		public const string GraphQL_Playground = GraphQL + "/Playground";

		public const string Path_Characters = "/Characters";
		public const string Path_Factions = "/Factions";
		public const string Path_Films = "/Films";
		public const string Path_Manufacturers = "/Manufacturers";
		public const string Path_Planets = "/Planets";
		public const string Path_Search = "/Search";
		public const string Path_Species = "/Species";
		public const string Path_Starships = "/Starships";
		public const string Path_Vehicles = "/Vehicles";
		public const string Path_Weapons = "/Weapons";

		public const string Path_Meta = "/Meta";

		public const string Rest = "/Rest";
		public const string Rest_Swagger = "/Rest/Swagger";

		public static IEnumerable<string> Api_Rest_AsEnumerable()
		{
			return Enumerable.Empty<string>()
				.Append(Api_Rest)
				.Append(Api_Rest_Characters)
				.Append(Api_Rest_Factions)
				.Append(Api_Rest_Films)
				.Append(Api_Rest_Manufacturers)
				.Append(Api_Rest_Planets)
				.Append(Api_Rest_Search)
				.Append(Api_Rest_Species)
				.Append(Api_Rest_Starships)
				.Append(Api_Rest_Vehicles)
				.Append(Api_Rest_Weapons)
				.Append(Api_Rest_Meta);
		}
		public static IEnumerable<string> Path_AsEnumerable()
		{
			return Enumerable.Empty<string>()
				.Append(Path_Characters)
				.Append(Path_Factions)
				.Append(Path_Films)
				.Append(Path_Manufacturers)
				.Append(Path_Planets)
				.Append(Path_Search)
				.Append(Path_Species)
				.Append(Path_Starships)
				.Append(Path_Vehicles)
				.Append(Path_Weapons)
				.Append(Path_Meta);
		}
	}
}
