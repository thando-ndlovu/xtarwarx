using Domain.Models;

using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Threading;

namespace Repository.Data.Json.Utils
{
	public class FactionUtils : Utils
	{
		public static IEnumerable<string> ManifestResourceNames => typeof(WeaponUtils).Assembly
			.GetManifestResourceNames()
			.Where(manifestresourcename => manifestresourcename.Contains("Repository.Data.Json.Factions"));

		public static IEnumerable<IFaction> Data()
		{
			return ReadManifestResources(ManifestResourceNames)
				.Select(manifestresource => new IFaction.Default(manifestresource.Key, JObject.Parse(manifestresource.Value)));
		}
		public static async IAsyncEnumerable<IFaction> Data([EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
			await foreach (KeyValuePair<int, string> manifestresource in ReadManifestResources(ManifestResourceNames, cancellationToken))
			{
				yield return new IFaction.Default(manifestresource.Key, JObject.Parse(manifestresource.Value));
			}
		}
	}
}
