using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IManufacturer
	{
		public new interface ISearchContainables<T> : IStarWarsModel.ISearchContainables<T>
		{
			T Description { get; set; }
			T Name { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearchContainables : ISearchContainables<bool>, IStarWarsModel.ISearchContainables
		{
			public new class Default : Default<bool>, ISearchContainables
			{
				public Default() : base(false) { }
			}
			public new class Default<T> : IStarWarsModel.ISearchContainables.Default<T>, ISearchContainables<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Description = defaultvalue;
					Name = defaultvalue;
				}

				public T Description { get; set; }
				public T Name { get; set; }
			}

			public bool ShouldReturnManufacturer(IManufacturer manufacturer, string? searchString)
			{
				if (Description && DescriptionContainsSearchString(manufacturer, searchString, out int _)) return true;
				if (Name && NameContainsSearchString(manufacturer, searchString, out int _)) return true;

				return false;
			}
			public bool ShouldReturnManufacturer(IManufacturer manufacturer, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (Description && DescriptionContainsSearchString(manufacturer, searchString, out int descriptionMatchCount))
				{
					matchCount += descriptionMatchCount;

					shouldreturn = true;
				}
				if (Name && NameContainsSearchString(manufacturer, searchString, out int nameMatchCount))
				{
					matchCount += nameMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool DescriptionContainsSearchString(IManufacturer manufacturer, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(manufacturer.Description)) return false;

				if (manufacturer.Description.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool NameContainsSearchString(IManufacturer manufacturer, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(manufacturer.Name)) return false;

				if (manufacturer.Name.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class IManufacturerExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IManufacturer.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IManufacturer.ISearchContainables<T>.Description), searchcontainables.Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IManufacturer.ISearchContainables<T>.Name), searchcontainables.Name).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as IStarWarsModel.ISearchContainables<T>);
		}
	}
}
