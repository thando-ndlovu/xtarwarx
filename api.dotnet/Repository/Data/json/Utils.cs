using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Repository.Data.Json.Utils
{
	public class Utils
	{
		public static Assembly Assembly => typeof(Utils).Assembly;
		public static IEnumerable<KeyValuePair<int, string>> ReadManifestResources(IEnumerable<string> manifestresourcenames)
		{
			Assembly assembly = typeof(Utils).Assembly;

			return manifestresourcenames
				.Select(manifestresourcename =>
				{
					if (int.TryParse(manifestresourcename.Split(".")[^2], out int id))
					{
						using Stream? s = assembly.GetManifestResourceStream(manifestresourcename);

						if (s != null)
						{
							using StreamReader sr = new(s);

							string json = sr.ReadToEnd();

							return new KeyValuePair<int, string>(id, json);
						}
					}

					return new KeyValuePair<int, string>?();

				}).OfType<KeyValuePair<int, string>>();
		}
		public static async IAsyncEnumerable<KeyValuePair<int, string>> ReadManifestResources(IEnumerable<string> manifestresourcenames, [EnumeratorCancellation]CancellationToken cancellationToken = default)
		{
			Assembly assembly = typeof(Utils).Assembly;

			foreach (string manifestresourcename in manifestresourcenames)
				if (int.TryParse(manifestresourcename.Split(".")[^2], out int id))
				{
					using Stream? s = assembly.GetManifestResourceStream(manifestresourcename);

					if (s != null)
					{
						using StreamReader sr = new(s);

						string json = await sr.ReadToEndAsync();

						yield return new KeyValuePair<int, string>(id, json);
					}
				}
		}
	}
}
