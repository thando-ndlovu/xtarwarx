using Domain.Models;

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Localisation.Utils.Characters
{
	public class CharacterDescriptions
	{
		public const string ResourceName = "Characters.CharacterDescriptions";

		public static readonly ICharacter<string> Keys = new ICharacter.Default<string>(string.Empty)
		{
			BirthYear = "CharacterDescriptions_BirthYear",
			Description = "CharacterDescriptions_Description",
			EyeColors = "CharacterDescriptions_EyeColors",
			HairColors = "CharacterDescriptions_HairColors",
			Height = "CharacterDescriptions_Height",
			HomeworldId = "CharacterDescriptions_HomeworldId",
			Id = "CharacterDescriptions_Id",
			Mass = "CharacterDescriptions_Mass",
			Name = "CharacterDescriptions_Name",
			Sex = "CharacterDescriptions_Sex",
			SkinColors = "CharacterDescriptions_SkinColors",
			Uris = "CharacterDescriptions_Uris",
			Created = "CharacterDescriptions_Created",
			Edited = "CharacterDescriptions_Edited",
		};
	}

	public static class CharacterDescriptionsExtensions
	{
		public static ICharacter<string?>? GetCharacterDescriptions(this LocalisationResourceManager? localisationResourceManager, ICharacter<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ICharacter.Default<string?>(null)
				{
					BirthYear = retriever?.BirthYear ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.BirthYear) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Edited) : null,
					EyeColors = retriever?.EyeColors ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.EyeColors) : null,
					HairColors = retriever?.HairColors ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.HairColors) : null,
					Height = retriever?.Height ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Height) : null,
					HomeworldId = retriever?.HomeworldId ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.HomeworldId) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Id) : null,
					Mass = retriever?.Mass ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Mass) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Name) : null,
					Sex = retriever?.Sex ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Sex) : null,
					SkinColors = retriever?.SkinColors ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.SkinColors) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(CharacterDescriptions.Keys.Uris) : null,
				};
	}
}
