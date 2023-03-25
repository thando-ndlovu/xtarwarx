using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Weapons
{
	public interface IWeaponSearchLocalisation<T> : IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T ManufacturersSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ManufacturersSearchContainables), ManufacturersSearchContainables).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface IWeaponSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchItemLocalisation<T> ManufacturersSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(ManufacturersSearchContainables)).AppendLine(ManufacturersSearchContainables.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IWeaponSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchItemLocalisation? ManufacturersSearchContainables  { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IWeaponSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ManufacturersSearchContainables)).AppendLine(ManufacturersSearchContainables?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		#region Defaults

		public new class Default : IStarWarsModelSearchLocalisation.Default, IWeaponSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchItemLocalisation? ManufacturersSearchContainables { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, IWeaponSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				ManufacturersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchItemLocalisation<T> ManufacturersSearchContainables { get; set; }
		}	 
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, IWeaponSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				ManufacturersSearchContainables = defaultvalue;
			}

			public T Containables { get; set; }
			public T ManufacturersSearchContainables { get; set; }
		}

		#endregion
	}
}
