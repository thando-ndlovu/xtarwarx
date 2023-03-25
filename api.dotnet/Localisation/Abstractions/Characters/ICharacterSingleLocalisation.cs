using Domain.Models;

using System.Text;

namespace Localisation.Abstractions.Characters
{
	public interface ICharacterSingleLocalisation<T> : ICharacter<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }
		T HomeworldTitle { get; set; }
		T HomeworldAbsentText { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("HomeworldAbsentText: {0},", HomeworldAbsentText)
				.AppendFormat("HomeworldTitle: {0},", HomeworldTitle)
				.AppendFormat("ImagesEmptyText: {0},", ImagesEmptyText)
				.AppendFormat("ImagesTitle: {0},", ImagesTitle)
				.AppendLine()
				.AppendFormat("BirthYear: {0},", BirthYear)
				.AppendFormat("Created: {0},", Created)
				.AppendFormat("Description: {0},", Description)
				.AppendFormat("Edited: {0},", Edited)
				.AppendFormat("EyeColors: {0},", EyeColors)
				.AppendFormat("HairColors: {0},", HairColors)
				.AppendFormat("Height: {0},", Height)
				.AppendFormat("HomeworldId: {0},", HomeworldId)
				.AppendFormat("Mass: {0},", Mass)
				.AppendFormat("Name: {0},", Name)
				.AppendFormat("Sex: {0},", Sex)
				.AppendFormat("Uris: {0},", Uris)
				.ToString();
		}
	}
	public interface ICharacterSingleLocalisation : ICharacter<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }
		string? HomeworldTitle { get; set; }
		string? HomeworldAbsentText { get; set; }

		#region Methods

		public static ICharacterSingleLocalisation? FromCharacter(ICharacter<string?>? character)
			=> character == null
				? null
				: new Default
				{
					Uris = character.Uris,
					Created = character.Created,
					Edited = character.Edited,

					BirthYear = character.BirthYear,
					Description = character.Description,
					EyeColors = character.EyeColors,
					HairColors = character.HairColors,
					Height = character.Height,
					HomeworldId = character.HomeworldId,
					Mass = character.Mass,
					Name = character.Name,
					Sex = character.Sex,
					SkinColors = character.SkinColors,
				};

		#endregion

		#region Defaults

		public class Default : ICharacter.Default<string?>, ICharacterSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? HomeworldTitle { get; set; }
			public string? HomeworldAbsentText { get; set; }
		}
		public class Default<T> : ICharacter.Default<T>, ICharacterSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;

				HomeworldTitle = defaultvalue;
				HomeworldAbsentText = defaultvalue;
			}

			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T HomeworldTitle { get; set; }
			public T HomeworldAbsentText { get; set; }
		}

		#endregion
	}
}
