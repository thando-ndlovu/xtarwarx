using System.Collections.Generic;

namespace System.Collections.ObjectModel
{
	public class ObservableCollectionGrouped<T> : ObservableCollection<T>
	{
		public ObservableCollectionGrouped() : base() { }
		public ObservableCollectionGrouped(IList<T> list) : base(list) { }
		public ObservableCollectionGrouped(IEnumerable<T> enumerable) : base(enumerable) { }

		public bool ShowGroupName { get; set; } 
		public string? LongGroupName { get; set; }
		public string? ShortGroupName { get; set; }
	}
}
