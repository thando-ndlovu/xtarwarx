using Domain.Models;

namespace Localisation.Abstractions.Species
{
	public interface ISpecieSingleLocalisation<T> : ISpecie<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T HomeworldTitle { get; set; }
		T HomeworldAbsentText { get; set; }

		T CharactersTitle { get; set; }
		T CharactersEmptyText { get; set; }
	}
	public interface ISpecieSingleLocalisation : ISpecie<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? HomeworldTitle { get; set; }
		string? HomeworldAbsentText { get; set; }

		string? CharactersTitle { get; set; }
		string? CharactersEmptyText{ get; set; }

		#region Methods

		public static ISpecieSingleLocalisation? FromSpecie(ISpecie<string?>? specie)
			=> specie == null
				? null
				: new Default
				{
					Uris = specie.Uris,
					Created = specie.Created,
					Edited = specie.Edited,

					AverageHeight = specie.AverageHeight,
					AverageLifespan = specie.AverageLifespan,
					CharacterIds = specie.CharacterIds,
					Classification = specie.Classification,
					Description = specie.Description,
					Designation = specie.Designation,
					EyeColors = specie.EyeColors,
					HairColors = specie.HairColors,
					HomeworldId = specie.HomeworldId,
					Language = specie.Language,
					Name = specie.Name,
					SkinColors = specie.SkinColors,
				};

		#endregion

		#region Defaults

		public class Default : ISpecie.Default<string?>, ISpecieSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? HomeworldTitle { get; set; }
			public string? HomeworldAbsentText { get; set; }

			public string? CharactersTitle { get; set; }
			public string? CharactersEmptyText { get; set; }
		}
		public class Default<T> : ISpecie.Default<T>, ISpecieSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;

				HomeworldTitle = defaultvalue;
				HomeworldAbsentText = defaultvalue;

				CharactersTitle = defaultvalue;
				CharactersEmptyText = defaultvalue;
			}

			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T HomeworldTitle { get; set; }
			public T HomeworldAbsentText { get; set; }

			public T CharactersTitle { get; set; }
			public T CharactersEmptyText { get; set; }
		}

		#endregion
	}
}
