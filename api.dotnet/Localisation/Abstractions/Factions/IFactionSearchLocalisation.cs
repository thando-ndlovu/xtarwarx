using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Factions
{
	public interface IFactionSearchLocalisation<T> : IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T AlliedCharactersSearchContainables { get; set; }
		T AlliedFactionsSearchContainables { get; set; }
		T LeadersSearchContainables { get; set; }
		T MemberCharactersSearchContainables { get; set; }
		T MemberFactionsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(AlliedCharactersSearchContainables), AlliedCharactersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(AlliedFactionsSearchContainables), AlliedFactionsSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LeadersSearchContainables), LeadersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MemberCharactersSearchContainables), MemberCharactersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MemberFactionsSearchContainables), MemberFactionsSearchContainables).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface IFactionSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchItemLocalisation<T> AlliedCharactersSearchContainables { get; set; }
		ISearchItemLocalisation<T> AlliedFactionsSearchContainables { get; set; }
		ISearchItemLocalisation<T> LeadersSearchContainables { get; set; }
		ISearchItemLocalisation<T> MemberCharactersSearchContainables { get; set; }
		ISearchItemLocalisation<T> MemberFactionsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(AlliedCharactersSearchContainables)).AppendLine(AlliedCharactersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(AlliedFactionsSearchContainables)).AppendLine(AlliedFactionsSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(LeadersSearchContainables)).AppendLine(LeadersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(MemberCharactersSearchContainables)).AppendLine(MemberCharactersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(MemberFactionsSearchContainables)).AppendLine(MemberFactionsSearchContainables.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IFactionSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchItemLocalisation? AlliedCharactersSearchContainables { get; set; }
		ISearchItemLocalisation? AlliedFactionsSearchContainables { get; set; }
		ISearchItemLocalisation? LeadersSearchContainables { get; set; }
		ISearchItemLocalisation? MemberCharactersSearchContainables { get; set; }
		ISearchItemLocalisation? MemberFactionsSearchContainables { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IFactionSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(AlliedCharactersSearchContainables)).AppendLine(AlliedCharactersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(AlliedFactionsSearchContainables)).AppendLine(AlliedFactionsSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(LeadersSearchContainables)).AppendLine(LeadersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MemberCharactersSearchContainables)).AppendLine(MemberCharactersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MemberFactionsSearchContainables)).AppendLine(MemberFactionsSearchContainables?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		#region Defaults

		public new class Default : IStarWarsModelSearchLocalisation.Default, IFactionSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchItemLocalisation? AlliedCharactersSearchContainables { get; set; }
			public ISearchItemLocalisation? AlliedFactionsSearchContainables { get; set; }
			public ISearchItemLocalisation? LeadersSearchContainables { get; set; }
			public ISearchItemLocalisation? MemberCharactersSearchContainables { get; set; }
			public ISearchItemLocalisation? MemberFactionsSearchContainables { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, IFactionSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				AlliedCharactersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				AlliedFactionsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				LeadersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				MemberCharactersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				MemberFactionsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchItemLocalisation<T> AlliedCharactersSearchContainables { get; set; }
			public ISearchItemLocalisation<T> AlliedFactionsSearchContainables { get; set; }
			public ISearchItemLocalisation<T> LeadersSearchContainables { get; set; }
			public ISearchItemLocalisation<T> MemberCharactersSearchContainables { get; set; }
			public ISearchItemLocalisation<T> MemberFactionsSearchContainables { get; set; }

		}
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, IFactionSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				AlliedCharactersSearchContainables = defaultvalue;
				AlliedFactionsSearchContainables = defaultvalue;
				LeadersSearchContainables = defaultvalue;
				MemberCharactersSearchContainables = defaultvalue;
				MemberFactionsSearchContainables = defaultvalue;
			}

			public T Containables { get; set; }
			public T AlliedCharactersSearchContainables { get; set; }
			public T AlliedFactionsSearchContainables { get; set; }
			public T LeadersSearchContainables { get; set; }
			public T MemberCharactersSearchContainables { get; set; }
			public T MemberFactionsSearchContainables { get; set; }
		}

		#endregion
	}
}
