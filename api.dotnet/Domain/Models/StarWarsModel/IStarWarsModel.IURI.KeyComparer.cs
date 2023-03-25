using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IStarWarsModel
    {
		public partial interface IURI 
		{
			public class KeyComparer : IComparer<string?>, IEqualityComparer<string?>
			{
				public IEnumerable<string>? OrderedKeys { get; set; }

				protected void GetUriKeysIndexes(string? xKey, string? yKey, out int? xIndex, out int? yIndex)
				{
					IEnumerable<string> urikeysenumerable = Keys.AsEnumerable()
						.OrderBy(key => key);

					xIndex = null;
					yIndex = null;

					if (xKey is not null)
					{
						if (urikeysenumerable.Contains(xKey) is false)
							throw new ArgumentException(
								message: string.Format("Invalid x Key: {0}", xKey));

						int index = -1;
						foreach (string key in OrderedKeys ?? urikeysenumerable)
						{
							index++;
							if (Equals(key, xKey))
							{
								xIndex = index;
								break;
							}
						}
					}
					if (yKey is not null)
					{
						if (urikeysenumerable.Contains(yKey) is false)
							throw new ArgumentException(
								message: string.Format("Invalid y Key: {0}", yKey));

						int index = -1;
						foreach (string key in OrderedKeys ?? urikeysenumerable)
						{
							index++;
							if (Equals(key, yKey))
							{
								yIndex = index;
								break;
							}
						}
					}
				}

				public int Compare(string? x, string? y)
				{
					GetUriKeysIndexes(x, y, out int? xIndex, out int? yIndex);

					return System.Collections.Generic.Comparer<int?>
						.Default
						.Compare(xIndex, yIndex);
				}
				public bool Equals(string? x, string? y)
				{
					GetUriKeysIndexes(x, y, out int? xIndex, out int? yIndex);

					return Equals(xIndex, yIndex);
				}
				public int GetHashCode(string? obj)
				{
					return obj?.GetHashCode() ?? 0;
				}

				public static KeyComparer FromOrder(bool strict = false, params string[] orderedKeys)
				{
					if (strict)
						return new KeyComparer
						{
							OrderedKeys = orderedKeys
						};

					IEnumerable<string> keys = orderedKeys.Distinct();
					IEnumerable<string> remainingKeys = Keys
						.AsEnumerable()
						.Where(key => !keys.Contains(key));

					return new KeyComparer
					{
						OrderedKeys = Enumerable.Empty<string>()
							.Concat(keys)
							.Concat(remainingKeys),     
					};
				}
			}
		}
    }
}
