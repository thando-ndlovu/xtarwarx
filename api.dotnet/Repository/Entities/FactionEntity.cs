using Domain.Models;

namespace Repository.Entities
{
	public class FactionEntity : IFaction.Default
	{
		public FactionEntity(int id) : base(id) { }
		public FactionEntity(IFaction faction) : base(faction.Id) 
		{
			AlliedCharacterIds = faction.AlliedCharacterIds;
			AlliedFactionIds = faction.AlliedFactionIds;
			Created = faction.Created;
			Description = faction.Description;
			Edited = faction.Edited;
			LeaderIds = faction.LeaderIds;
			MemberCharacterIds = faction.MemberCharacterIds;
			MemberFactionIds = faction.MemberFactionIds;
			Name = faction.Name;
			OrganizationTypes = faction.OrganizationTypes;
			Uris = faction.Uris;
		}
	}
}
