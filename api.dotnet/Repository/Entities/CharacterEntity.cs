using Domain.Models;

namespace Repository.Entities
{
	public class CharacterEntity : ICharacter.Default
	{
		public CharacterEntity(int id) : base(id) { }
		public CharacterEntity(ICharacter character) : base(character.Id)
		{
			BirthYear = character.BirthYear;
			Created = character.Created;
			Description = character.Description;
			Edited = character.Edited;
			EyeColors = character.EyeColors;
			HairColors = character.HairColors;
			Height = character.Height;
			HomeworldId = character.HomeworldId;
			Mass = character.Mass;
			Name = character.Name;
			Sex = character.Sex;
			SkinColors = character.SkinColors;
			Uris = character.Uris;
		}
	}
}
