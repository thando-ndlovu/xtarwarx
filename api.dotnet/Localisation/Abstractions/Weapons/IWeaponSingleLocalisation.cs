using Domain.Models;

namespace Localisation.Abstractions.Weapons
{
	public interface IWeaponSingleLocalisation<T> : IWeapon<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T ManufacturersTitle { get; set; }
		T ManufacturersEmptyText { get; set; }
	}
	public interface IWeaponSingleLocalisation : IWeapon<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? ManufacturersTitle { get; set; }
		string? ManufacturersEmptyText { get; set; }

		#region Methods

		public static IWeaponSingleLocalisation? FromWeapon(IWeapon<string?>? weapon)
			=> weapon == null
				? null
				: new Default
				{
					Uris = weapon.Uris,
					Created = weapon.Created,
					Edited = weapon.Edited,

					Description = weapon.Description,
					ManufacturerIds = weapon.ManufacturerIds,
					Model = weapon.Model,
					Name = weapon.Name,
					WeaponClass = weapon.WeaponClass,
				};

		#endregion

		#region Defaults

		public class Default : IWeapon.Default<string?>, IWeaponSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? ManufacturersTitle { get; set; }
			public string? ManufacturersEmptyText { get; set; }
		}
		public class Default<T> : IWeapon.Default<T>, IWeaponSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;

				ManufacturersTitle = defaultvalue;
				ManufacturersEmptyText = defaultvalue;
			}
			
			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T ManufacturersTitle { get; set; }
			public T ManufacturersEmptyText { get; set; }
		}

		#endregion
	}
}
