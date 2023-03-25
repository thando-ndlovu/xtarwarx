using Domain.Models;

namespace Repository.Entities
{
	public class SpecieEntity : ISpecie.Default
	{
		public SpecieEntity(int id) : base(id) { }
		public SpecieEntity(ISpecie specie) : base(specie.Id)
		{
			AverageHeight = specie.AverageHeight;
			AverageLifespan = specie.AverageLifespan;
			CharacterIds = specie.CharacterIds;
			Classification = specie.Classification;
			Created = specie.Created;
			EyeColors = specie.EyeColors;
			HairColors = specie.HairColors;
			HomeworldId = specie.HomeworldId;
			Language = specie.Language;
			Name = specie.Name;
			SkinColors = specie.SkinColors;
			Uris = specie.Uris;
		}
	}
}
