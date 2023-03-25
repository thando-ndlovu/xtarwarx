using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IWeapon
	{
		public new interface ISearchContainables<T> : IStarWarsModel.ISearchContainables<T>
		{
			T Description { get; set; }
			T Model { get; set; }
			T Name { get; set; }
			T WeaponClass { get; set; }
			T WeaponClassFlags { get; set; }

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
					WeaponClass = defaultvalue;
					WeaponClassFlags = defaultvalue;
				}

				public T Description { get; set; }
				public T Model { get; set; }
				public T Name { get; set; }
				public T WeaponClass { get; set; }
				public T WeaponClassFlags { get; set; }
			}

			public bool ShouldReturnWeapon(IWeapon weapon, string? searchString)
			{
				if (Description && DescriptionContainsSearchString(weapon, searchString, out int _)) return true;
				if (Model && ModelContainsSearchString(weapon, searchString, out int _)) return true;
				if (Name && NameContainsSearchString(weapon, searchString, out int _)) return true;
				if (WeaponClass && WeaponClassContainsSearchString(weapon, searchString, out int _)) return true;
				if (WeaponClassFlags && WeaponClassFlagsContainsSearchString(weapon, searchString, out int _)) return true;

				return false;
			}
			public bool ShouldReturnWeapon(IWeapon weapon, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (Description && DescriptionContainsSearchString(weapon, searchString, out int descriptionMatchCount))
				{
					matchCount += descriptionMatchCount;

					shouldreturn = true;
				}
				if (Model && ModelContainsSearchString(weapon, searchString, out int modelMatchCount))
				{
					matchCount += modelMatchCount;

					shouldreturn = true;
				}
				if (Name && NameContainsSearchString(weapon, searchString, out int nameMatchCount))
				{
					matchCount += nameMatchCount;

					shouldreturn = true;
				}
				if (WeaponClass && WeaponClassContainsSearchString(weapon, searchString, out int weaponClassMatchCount))
				{
					matchCount += weaponClassMatchCount;

					shouldreturn = true;
				}
				if (WeaponClassFlags && WeaponClassFlagsContainsSearchString(weapon, searchString, out int weaponClassFlagsMatchCount))
				{
					matchCount += weaponClassFlagsMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool DescriptionContainsSearchString(IWeapon weapon, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(weapon.Description)) return false;

				if (weapon.Description.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool ModelContainsSearchString(IWeapon weapon, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(weapon.Model)) return false;

				if (weapon.Model.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool NameContainsSearchString(IWeapon weapon, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(weapon.Name)) return false;

				if (weapon.Name.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool WeaponClassContainsSearchString(IWeapon weapon, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(weapon.WeaponClass?.Class)) return false;

				if (weapon.WeaponClass.Class.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool WeaponClassFlagsContainsSearchString(IWeapon weapon, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (weapon.WeaponClass?.Flags == null) return false;

				foreach (string weaponclassflag in weapon.WeaponClass.Flags)
					if (weaponclassflag.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
						matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class IWeaponExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IWeapon.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IWeapon.ISearchContainables<T>.Description), searchcontainables.Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IWeapon.ISearchContainables<T>.Model), searchcontainables.Model).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IWeapon.ISearchContainables<T>.Name), searchcontainables.Name).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IWeapon.ISearchContainables<T>.WeaponClass), searchcontainables.WeaponClass).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IWeapon.ISearchContainables<T>.WeaponClassFlags), searchcontainables.WeaponClassFlags).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as IStarWarsModel.ISearchContainables<T>);
		}
	}
}
