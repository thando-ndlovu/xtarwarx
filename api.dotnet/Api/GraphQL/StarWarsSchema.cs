using GraphQL.Types;

using System;

namespace Api.GraphQL
{
	public partial class StarWarsSchema : Schema
	{
		public StarWarsSchema(IServiceProvider serviceprovider) : base(serviceprovider) { }
	}
}
