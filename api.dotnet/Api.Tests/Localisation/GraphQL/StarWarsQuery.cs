using Localisation.Abstractions;
using Localisation.Abstractions.GraphQL;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class GraphQL
	{
		[Theory]
		[MemberData(nameof(GraphQLMemberData))]
		[Trait("IGraphQLLocalisation", "")]
		public void StarWarsQuery(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IGraphQLLocalisations graphQLLocalisations = new GraphQLLocalisations();

			// Act

			IStarWarsQueryLocalisation? starwarsquery = null;

			Exception? exception = Record.Exception(() => starwarsquery = graphQLLocalisations.StarWarsQuery(cultureInfo));

			_OutputHelper.WriteLine(message: _StringBuilder.Clear()
				.AppendFormat("Name: {0},", starwarsquery?.Name)
				.AppendFormat("Description: {0},", starwarsquery?.Description)
				.AppendFormat("CharactersDescription: {0},", starwarsquery?.CharactersDescription)
				.AppendFormat("CharactersName: {0},", starwarsquery?.CharactersName)
				.AppendFormat("FactionsDescription: {0},", starwarsquery?.FactionsDescription)
				.AppendFormat("FactionsName: {0},", starwarsquery?.FactionsName)
				.AppendFormat("FilmsDescription: {0},", starwarsquery?.FilmsDescription)
				.AppendFormat("FilmsName: {0},", starwarsquery?.FilmsName)
				.AppendFormat("ManufacturersDescription: {0},", starwarsquery?.ManufacturersDescription)
				.AppendFormat("ManufacturersName: {0},", starwarsquery?.ManufacturersName)
				.AppendFormat("PlanetsDescription: {0},", starwarsquery?.PlanetsDescription)
				.AppendFormat("PlanetsName: {0},", starwarsquery?.PlanetsName)
				.AppendFormat("SpeciesDescription: {0},", starwarsquery?.SpeciesDescription)
				.AppendFormat("SpeciesName: {0},", starwarsquery?.SpeciesName)
				.AppendFormat("StarshipsDescription: {0},", starwarsquery?.StarshipsDescription)
				.AppendFormat("StarshipsName: {0},", starwarsquery?.StarshipsName)
				.AppendFormat("VehiclesDescription: {0},", starwarsquery?.VehiclesDescription)
				.AppendFormat("VehiclesName: {0},", starwarsquery?.VehiclesName)
				.AppendFormat("WeaponssDescription: {0},", starwarsquery?.WeaponsDescription)
				.AppendFormat("WeaponssName: {0},", starwarsquery?.WeaponsName)
				.ToString());

			// Assert

			Assert.Null(exception);
			Assert.NotNull(starwarsquery);
		}
	}
}
