using System.Collections.Generic;

namespace System.Collections.ObjectModel
{
	public static class ObservableCollectionExtensions
	{
		public static void AddRange<T>(this ObservableCollection<T> observablecollection, IEnumerable<T> items)
		{
			foreach (T item in items)
				observablecollection.Add(item);
		}
	}
}
