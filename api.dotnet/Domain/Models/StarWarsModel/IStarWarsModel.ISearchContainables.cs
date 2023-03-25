using System.Text;

namespace Domain.Models
{
	public partial interface IStarWarsModel
	{
		public interface ISearchContainables<T> 
		{
			public string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public interface ISearchContainables : ISearchContainables<bool> 
		{
			public class Default : ISearchContainables { }
			public class Default<T> : ISearchContainables<T>
			{
				public Default(T defaultvalue) { }
			}
		}
	}

	public static class IStarWarsModelExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IStarWarsModel.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			return stringbuilder;
		}
	}
}
