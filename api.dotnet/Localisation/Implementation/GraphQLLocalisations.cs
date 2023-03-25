using Localisation.Abstractions;
using Localisation.Abstractions.GraphQL;
using Localisation.Utils.GraphQL;

using System.Globalization;

using GraphQLUtils = Localisation.Utils.GraphQL;

namespace Localisation.Implementation
{
	public class GraphQLLocalisations : Base.BaseLocalisations, IGraphQLLocalisations
	{
		public IStarWarsQueryLocalisation? StarWarsQuery(CultureInfo? cultureInfo = null, IStarWarsQueryLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(GraphQLUtils.StarWarsQuery.ResourceName, localisationcultureinfo)?
				.GetStarWarsQuery(retriever);
		}
	}
}
