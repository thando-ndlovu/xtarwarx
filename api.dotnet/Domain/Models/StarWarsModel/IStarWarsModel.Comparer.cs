using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IStarWarsModel 
	{
		public class Comparer<T> : IComparer<T>, IEqualityComparer<T> where T : IStarWarsModel
		{
			public class Keys
			{
				public const string Created = "Created";
				public const string Edited = "Edited";
				public const string Id = "Id";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Created)
						.Append(Edited)
						.Append(Id);
				}
			}

			protected object? KeyComparer { get; set; }
			public string? ComparerKey { get; set; }
			public string[]? EqualityComparerKeys { get; set; }

			public virtual int Compare(T? x, T? y)
			{
				return ComparerKey switch
				{
					Keys.Created => ((IComparer<DateTime?>)(KeyComparer ??= System.Collections.Generic.Comparer<DateTime?>.Default))
						.Compare(x?.Created, y?.Created),

					Keys.Edited => ((IComparer<DateTime?>)(KeyComparer ??= System.Collections.Generic.Comparer<DateTime?>.Default))
						.Compare(x?.Edited, y?.Edited),

					Keys.Id => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Id, y?.Id),

					_ => ((IComparer<T?>)(KeyComparer ??= System.Collections.Generic.Comparer<T?>.Default))
						.Compare(x, y)
				};
			}
			public virtual bool Equals(T? x, T? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.Created => (x.Created is null && y.Created is null) || Equals(x.Created, y.Created),
						Keys.Edited => (x.Edited is null && y.Edited is null) || Equals(x.Edited, y.Edited),
						Keys.Id => x.Id == y.Id,

						_ => throw new ArgumentException("Key '{0}' is invalid"),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public virtual int GetHashCode(T obj)
			{
				return obj.GetHashCode();
			}
		}
	}
}
