using System;
using System.Text;

namespace Domain.Models
{
	public partial interface ITransporter
	{
		public new interface ISearchContainables<T> : IStarWarsModel.ISearchContainables<T>
		{
			T Description { get; set; }
			T Model { get; set; }
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
					Model = defaultvalue;
					Name = defaultvalue;
				}

				public T Description { get; set; }
				public T Model { get; set; }
				public T Name { get; set; }
			}

			public bool ShouldReturnTransporter(ITransporter transporter, string? searchString)
			{
				if (Description && DescriptionContainsSearchString(transporter, searchString, out int _)) return true;
				if (Model && ModelContainsSearchString(transporter, searchString, out int _)) return true;
				if (Name && NameContainsSearchString(transporter, searchString, out int _)) return true;

				return false;
			}
			public bool ShouldReturnTransporter(ITransporter transporter, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (Description && DescriptionContainsSearchString(transporter, searchString, out int descriptionMatchCount))
				{
					matchCount += descriptionMatchCount;

					shouldreturn = true;
				}
				if (Model && ModelContainsSearchString(transporter, searchString, out int modelMatchCount))
				{
					matchCount += modelMatchCount;

					shouldreturn = true;
				}
				if (Name && NameContainsSearchString(transporter, searchString, out int nameMatchCount))
				{
					matchCount += nameMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool DescriptionContainsSearchString(ITransporter transporter, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(transporter.Description)) return false;

				if (transporter.Description.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool ModelContainsSearchString(ITransporter transporter, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(transporter.Model)) return false;

				if (transporter.Model.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool NameContainsSearchString(ITransporter transporter, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(transporter.Name)) return false;

				if (transporter.Name.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class ITransporterExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, ITransporter.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearchContainables<T>.Description), searchcontainables.Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearchContainables<T>.Model), searchcontainables.Model).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ITransporter.ISearchContainables<T>.Name), searchcontainables.Name).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as IStarWarsModel.ISearchContainables<T>);
		}
	}
}
