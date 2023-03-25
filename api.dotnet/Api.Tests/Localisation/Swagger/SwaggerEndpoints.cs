using Domain.Models;

using Localisation.Abstractions;
using Localisation.Abstractions.Swagger;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Swagger
	{
		[Theory]
		[MemberData(nameof(SwaggersMemberData))]
		[Trait("ISwaggerLocalisation", "")]
		public void SwaggerEndpoints(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISwaggerLocalisations swaggerLocalisation = new SwaggerLocalisations();

			// Act

			ISwaggerEndpointsLocalisation? swaggerEndpoints = null;

			Exception? exception = Record.Exception(() => swaggerEndpoints = swaggerLocalisation.SwaggerEndpoints(cultureInfo));


			_OutputHelper.WriteLine(message: _StringBuilder.Clear()
				.AppendFormat("CharactersDescription: {0},", swaggerEndpoints?.Characters?.Description)
				.AppendFormat("CharactersSummary: {0},", swaggerEndpoints?.Characters?.Summary)
				.AppendFormat("FactionsDescription: {0},", swaggerEndpoints?.Factions?.Description)
				.AppendFormat("FactionsSummary: {0},", swaggerEndpoints?.Factions?.Summary)
				.AppendFormat("FilmsDescription: {0},", swaggerEndpoints?.Films?.Description)
				.AppendFormat("FilmsSummary: {0},", swaggerEndpoints?.Films?.Summary)
				.AppendFormat("ManufacturersDescription: {0},", swaggerEndpoints?.Manufacturers?.Description)
				.AppendFormat("ManufacturersSummary: {0},", swaggerEndpoints?.Manufacturers?.Summary)
				.AppendFormat("PlanetsDescription: {0},", swaggerEndpoints?.Planets?.Description)
				.AppendFormat("PlanetsSummary: {0},", swaggerEndpoints?.Planets?.Summary)
				.AppendFormat("SpeciesDescription: {0},", swaggerEndpoints?.Species?.Description)
				.AppendFormat("SpeciesSummary: {0},", swaggerEndpoints?.Species?.Summary)
				.AppendFormat("StarshipsDescription: {0},", swaggerEndpoints?.Starships?.Description)
				.AppendFormat("StarshipsSummary: {0},", swaggerEndpoints?.Starships?.Summary)
				.AppendFormat("VehiclesDescription: {0},", swaggerEndpoints?.Vehicles?.Description)
				.AppendFormat("VehiclesSummary: {0},", swaggerEndpoints?.Vehicles?.Summary)
				.AppendFormat("WeaponssDescription: {0},", swaggerEndpoints?.Weapons?.Description)
				.AppendFormat("WeaponssSummary: {0},", swaggerEndpoints?.Weapons?.Summary)
				.ToString());

			// Assert

			Assert.Null(exception);
			Assert.NotNull(swaggerEndpoints);
		}
	}
}
