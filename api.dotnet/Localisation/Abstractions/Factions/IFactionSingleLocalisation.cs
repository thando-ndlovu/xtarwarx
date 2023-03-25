using Domain.Models;

namespace Localisation.Abstractions.Factions
{
	public interface IFactionSingleLocalisation<T> : IFaction<T>
	{
		T AlliedCharactersTitle { get; set; }
		T AlliedCharactersEmptyText { get; set; }

		T AlliedFactionsTitle { get; set; }
		T AlliedFactionsEmptyText { get; set; }

		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T LeadersTitle { get; set; }
		T LeadersEmptyText { get; set; }

		T MemberCharactersTitle { get; set; }
		T MemberCharactersEmptyText { get; set; }

		T MemberFactionsTitle { get; set; }
		T MemberFactionsEmptyText { get; set; }
	}
	public interface IFactionSingleLocalisation : IFaction<string?>
	{
		string? AlliedCharactersTitle { get; set; }
		string? AlliedCharactersEmptyText { get; set; }

		string? AlliedFactionsTitle { get; set; }
		string? AlliedFactionsEmptyText { get; set; }

		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? LeadersTitle { get; set; }
		string? LeadersEmptyText { get; set; }
		
		string? MemberCharactersTitle { get; set; }
		string? MemberCharactersEmptyText { get; set; }

		string? MemberFactionsTitle { get; set; }
		string? MemberFactionsEmptyText { get; set; }

		#region Methods

		public static IFactionSingleLocalisation? FromFaction(IFaction<string?>? faction)
			=> faction == null
				? null
				: new Default
				{
					Uris = faction.Uris,
					Created = faction.Created,
					Edited = faction.Edited,

					AlliedCharacterIds = faction.AlliedCharacterIds,
					AlliedFactionIds = faction.AlliedFactionIds,
					LeaderIds = faction.LeaderIds,
					MemberCharacterIds = faction.MemberCharacterIds,
					MemberFactionIds = faction.MemberFactionIds,

					Description = faction.Description,
					Name = faction.Name,
					OrganizationTypes = faction.OrganizationTypes,
				};

		#endregion

		#region Defaults

		public class Default : IFaction.Default<string?>, IFactionSingleLocalisation
		{
			public Default() : base(null) { }

			public string? AlliedCharactersTitle { get; set; }
			public string? AlliedCharactersEmptyText { get; set; }

			public string? AlliedFactionsTitle { get; set; }
			public string? AlliedFactionsEmptyText { get; set; }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? LeadersTitle { get; set; }
			public string? LeadersEmptyText { get; set; }

			public string? MemberCharactersTitle { get; set; }
			public string? MemberCharactersEmptyText { get; set; }

			public string? MemberFactionsTitle { get; set; }
			public string? MemberFactionsEmptyText { get; set; }
		}
		public class Default<T> : IFaction.Default<T>, IFactionSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				AlliedCharactersTitle = defaultvalue;
				AlliedCharactersEmptyText = defaultvalue;
				
				AlliedFactionsTitle = defaultvalue;
				AlliedFactionsEmptyText = defaultvalue;
				
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;
				
				LeadersTitle = defaultvalue;
				LeadersEmptyText = defaultvalue;
				
				MemberCharactersTitle = defaultvalue;
				MemberCharactersEmptyText = defaultvalue;

				MemberFactionsTitle = defaultvalue;
				MemberFactionsEmptyText = defaultvalue;
			}
			
			public T AlliedCharactersTitle { get; set; }
			public T AlliedCharactersEmptyText { get; set; }

			public T AlliedFactionsTitle { get; set; }
			public T AlliedFactionsEmptyText { get; set; }

			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T LeadersTitle { get; set; }
			public T LeadersEmptyText { get; set; }

			public T MemberCharactersTitle { get; set; }
			public T MemberCharactersEmptyText { get; set; }

			public T MemberFactionsTitle { get; set; }
			public T MemberFactionsEmptyText { get; set; }
		}

		#endregion
	}
}
