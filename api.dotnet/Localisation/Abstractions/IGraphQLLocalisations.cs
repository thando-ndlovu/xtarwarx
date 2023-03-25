using Localisation.Abstractions.GraphQL;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IGraphQLLocalisations : IDisposable
	{
		IStarWarsQueryLocalisation? StarWarsQuery(CultureInfo? cultureInfo = null, IStarWarsQueryLocalisation<bool>? retriever = null);
	}
}
