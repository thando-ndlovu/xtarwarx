using Domain.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Microsoft.EntityFrameworkCore
{
	public static class ModelBuilderExtensions
	{
		public static void BuildCharacter<TCharacter>(this ModelBuilder modelbuilder) where TCharacter : class, ICharacter 
		{
			EntityTypeBuilder<TCharacter> typebuilder = modelbuilder.Entity<TCharacter>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.EyeColors)
				.HasConversion(_ => KnownColorsToString(_), _ => StringToKnownColors(_));
			typebuilder
				.Property(entity => entity.HairColors)
				.HasConversion(_ => KnownColorsToString(_), _ => StringToKnownColors(_));
			typebuilder
				.Property(entity => entity.SkinColors)
				.HasConversion(_ => KnownColorsToString(_), _ => StringToKnownColors(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildFaction<TFaction>(this ModelBuilder modelbuilder) where TFaction : class, IFaction 
		{
			EntityTypeBuilder<TFaction> typebuilder = modelbuilder.Entity<TFaction>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.AlliedCharacterIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.AlliedFactionIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.LeaderIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.MemberCharacterIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.MemberFactionIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.OrganizationTypes)
				.HasConversion(_ => StringsToString(_), _ => StringToStrings(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildFilm<TFilm>(this ModelBuilder modelbuilder) where TFilm : class, IFilm 
		{
			EntityTypeBuilder<TFilm> typebuilder = modelbuilder.Entity<TFilm>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.CastMembers)
				.HasConversion(_ => StringsToString(_), _ => StringToStrings(_));
			typebuilder
				.Property(entity => entity.CharacterIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.FactionIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.ManufacturerIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.PlanetIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.Producers)
				.HasConversion(_ => StringsToString(_), _ => StringToStrings(_));
			typebuilder
				.Property(entity => entity.SpecieIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.StarshipIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.VehicleIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.WeaponIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildManufacturer<TManufacturer>(this ModelBuilder modelbuilder) where TManufacturer : class, IManufacturer
		{
			EntityTypeBuilder<TManufacturer> typebuilder = modelbuilder.Entity<TManufacturer>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.StarshipIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.VehicleIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.WeaponIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildPlanet<TPlanet>(this ModelBuilder modelbuilder) where TPlanet : class, IPlanet
		{
			EntityTypeBuilder<TPlanet> typebuilder = modelbuilder.Entity<TPlanet>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.Climates)
				.HasConversion(_ => ClimatesToString(_), _ => StringToClimates(_));
			typebuilder
				.Property(entity => entity.ResidentIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.Terrains)
				.HasConversion(_ => TerrainsToString(_), _ => StringToTerrains(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildSpecie<TSpecie>(this ModelBuilder modelbuilder) where TSpecie : class, ISpecie
		{
			EntityTypeBuilder<TSpecie> typebuilder = modelbuilder.Entity<TSpecie>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.CharacterIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.EyeColors)
				.HasConversion(_ => KnownColorsToString(_), _ => StringToKnownColors(_));
			typebuilder
				.Property(entity => entity.HairColors)
				.HasConversion(_ => KnownColorsToString(_), _ => StringToKnownColors(_));
			typebuilder
				.Property(entity => entity.SkinColors)
				.HasConversion(_ => KnownColorsToString(_), _ => StringToKnownColors(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildStarship<TStarship>(this ModelBuilder modelbuilder) where TStarship : class, IStarship
		{
			EntityTypeBuilder<TStarship> typebuilder = modelbuilder.Entity<TStarship>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.Consumables)
				.HasConversion(_ => ConsumablesToString(_), _ => StringToConsumables(_));
			typebuilder
				.Property(entity => entity.ManufacturerIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.PilotIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.StarshipClass)
				.HasConversion(_ => StarshipClassToString(_), _ => StringToStarshipClass(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildVehicle<TVehicle>(this ModelBuilder modelbuilder) where TVehicle : class, IVehicle
		{
			EntityTypeBuilder<TVehicle> typebuilder = modelbuilder.Entity<TVehicle>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.Consumables)
				.HasConversion(_ => ConsumablesToString(_), _ => StringToConsumables(_));
			typebuilder
				.Property(entity => entity.ManufacturerIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.PilotIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.VehicleClass)
				.HasConversion(_ => VehicleClassToString(_), _ => StringToVehicleClass(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}
		public static void BuildWeapon<TWeapon>(this ModelBuilder modelbuilder) where TWeapon : class, IWeapon
		{
			EntityTypeBuilder<TWeapon> typebuilder = modelbuilder.Entity<TWeapon>();

			typebuilder.HasKey(entity => entity.Id);

			typebuilder
				.Property(entity => entity.ManufacturerIds)
				.HasConversion(_ => IdsToString(_), _ => StringToIds(_));
			typebuilder
				.Property(entity => entity.WeaponClass)
				.HasConversion(_ => WeaponClassToString(_), _ => StringToWeaponClass(_));
			typebuilder
				.Property(entity => entity.Uris)
				.HasConversion(_ => UriModelsToString(_), _ => StringToUriModels(_));
		}


		private const char Delimenator = ';';

		#region Comparers

		#endregion

		#region ClassAndFlags

		private static string? ClassAndFlagsToClassAndFlagsDeliminated(string? @class = null, IEnumerable<string>? flags = null)
		{
			if (string.IsNullOrWhiteSpace(@class) && (!flags?.Any() ?? !false))
				return null;

			return string.Format(
				format: "[{0}][{1}]",
				arg0: @class,
				arg1: string.Join(Delimenator, flags ?? Enumerable.Empty<string>()));
		}
		private static (string? @class, IEnumerable<string>? flags)? ClassAndFlagsDeliminatedToClassAndFlags(string? classandflagsdeliminated)
		{
			if (string.IsNullOrWhiteSpace(classandflagsdeliminated))
				return null;

			int @classbegin = classandflagsdeliminated.IndexOf('[');
			int @classend = classandflagsdeliminated.IndexOf(']');
			int flagsbegin = classandflagsdeliminated.LastIndexOf('[');
			int flagsend = classandflagsdeliminated.LastIndexOf(']');

			string @class = classandflagsdeliminated.Substring(classbegin + 1, classend - 1 - classbegin);
			string flags = classandflagsdeliminated.Substring(flagsbegin + 1, flagsend - 1 - flagsbegin);

			return (@class, flags.Split(Delimenator, StringSplitOptions.RemoveEmptyEntries).ToList());
		}

		private static string StarshipClassToString(IStarship.IStarshipClass? starshipclass)
		{
			return ClassAndFlagsToClassAndFlagsDeliminated(
				flags: starshipclass?.Flags,
				@class: starshipclass?.Class) ?? string.Empty;
		}
		private static IStarship.IStarshipClass? StringToStarshipClass(string starshipclass)
		{
			(string? @class, IEnumerable<string>? flags)? tuple = ClassAndFlagsDeliminatedToClassAndFlags(starshipclass);

			return tuple.HasValue
				? new IStarship.IStarshipClass.Default
				{
					Flags = tuple.Value.flags,
					Class = tuple.Value.@class,
				}
				: null;
		}

		private static string VehicleClassToString(IVehicle.IVehicleClass? vehicleclass)
		{
			return ClassAndFlagsToClassAndFlagsDeliminated(
				flags: vehicleclass?.Flags,
				@class: vehicleclass?.Class) ?? string.Empty;
		}
		private static IVehicle.IVehicleClass? StringToVehicleClass(string vehicleclass)
		{
			(string? @class, IEnumerable<string>? flags)? tuple = ClassAndFlagsDeliminatedToClassAndFlags(vehicleclass);

			return tuple.HasValue
				? new IVehicle.IVehicleClass.Default
				{
					Flags = tuple.Value.flags,
					Class = tuple.Value.@class,
				}
				: null;
		}

		private static string WeaponClassToString(IWeapon.IWeaponClass? weaponclass)
		{
			return ClassAndFlagsToClassAndFlagsDeliminated(
				flags: weaponclass?.Flags,
				@class: weaponclass?.Class) ?? string.Empty;
		}
		private static IWeapon.IWeaponClass? StringToWeaponClass(string weaponclass)
		{
			(string? @class, IEnumerable<string>? flags)? tuple = ClassAndFlagsDeliminatedToClassAndFlags(weaponclass);

			return tuple.HasValue
				? new IWeapon.IWeaponClass.Default
				{
					Flags = tuple.Value.flags,
					Class = tuple.Value.@class,
				}
				: null;
		}

		#endregion

		#region Consumables

		private static string ConsumablesToString(ITransporter.IConsumable? consumable)
		{
			return consumable == null
				? string.Empty
				: string.Format(
					"TimeUnit:{0};Value:{1}",
					consumable.TimeUnit ?? "null",
					consumable.Value?.ToString() ?? "null");
		}
		private static ITransporter.IConsumable? StringToConsumables(string consumable)
		{
			if (string.IsNullOrWhiteSpace(consumable))
				return null;

			string[] splitconsumable = consumable.Split(";");

			string? timeunit = splitconsumable.Length == 2
				? splitconsumable[0]
				: null;
			string? value = splitconsumable.Length == 2
				? splitconsumable[^1]
				: null;

			if 
			(
				splitconsumable.Length != 2 ||
				string.IsNullOrWhiteSpace(timeunit) || !timeunit.Contains("TimeUnit:") ||
				string.IsNullOrWhiteSpace(value) || !value.Contains("Value:")

			) throw new ArgumentException(
				string.Format("'{0}' is not a valid consumable format", consumable));

			return new ITransporter.IConsumable.Default
			{
				TimeUnit = ITransporter.IConsumable.TimeUnits.AsEnumerable().FirstOrDefault(_ => string.Equals(timeunit, _, StringComparison.OrdinalIgnoreCase)),

				Value = int.TryParse(value, out int outvalue)
					? outvalue
					: new int?()
			};
		}

		#endregion

		#region Climates

		private static string ClimatesToString(IEnumerable<IPlanet.IClimate>? climates)
			=> climates == null
				? string.Empty
				: !climates.Any()
					? string.Empty
					: string.Join(Delimenator, climates.Select(climate => string.Format(
					   "{0}{1}",
					   climate.Type?.ToString() ?? "null",
					   FlagsToDelimenatedFlags(climate.Flags?.ToArray()))));
		private static IEnumerable<IPlanet.IClimate>? StringToClimates(string climates)
			=> climates == null || string.IsNullOrWhiteSpace(climates)
				? null
				: climates.Split(Delimenator)
					.Select(climateString =>
					{
						int indexOfFlagEntry = climateString.IndexOf("[");
						int indexOfFlagExit = climateString.IndexOf("]");

						if (indexOfFlagEntry == 0) throw new Exception("character '[' indicating start of climate flags not found");
						if (indexOfFlagExit == 0) throw new Exception("character ']' indicating end of climate flags not found");

						string typeSubstring = climateString.Substring(0, indexOfFlagEntry);

						return new IPlanet.IClimate.Default
						{
							Type = typeSubstring == "null"
								? null
								: IPlanet.IClimate.Types.AsEnumerable().FirstOrDefault(_ => string.Equals(typeSubstring, _, StringComparison.OrdinalIgnoreCase)),

							Flags = (IEnumerable<string>?)DelimenatedFlagsToFlags(climateString.Replace(typeSubstring, string.Empty))?.ToList()
						};

					}).ToList();

		#endregion

		#region Flags

		private static string FlagsToDelimenatedFlags(string[]? flags = null)
		{
			if (flags == null || !flags.Any())
				return "[]";

			char[] disallowedFlagChars = new char[] { '[', ']', ',' };

			if (flags.Any(flag =>
			{
				if (string.IsNullOrWhiteSpace(flag))
					return false;

				if (flag.Contains(Delimenator))
					return true;

				char[] flagChars = flag.ToCharArray();

				if (flagChars.Any(flagChar => disallowedFlagChars.Contains(flagChar)))
					return true;

				return false;

			})) throw new ArgumentException($"No flag may contain any of the following characters: {0}", string.Join(", ", disallowedFlagChars));

			return string.Format("[{0}]", string.Join(",", flags));
		}
		private static string[]? DelimenatedFlagsToFlags(string delimenatedFlags)
			=> string.IsNullOrWhiteSpace(delimenatedFlags) || delimenatedFlags == "[]"
				? null
				: delimenatedFlags
					.Replace("[", string.Empty)
					.Replace("]", string.Empty)
					.Split(",")
					.ToArray();

		#endregion

		#region KnownColors

		private static IEnumerable<KnownColor>? StringToKnownColors(string knowncolors)
		{
			if (string.IsNullOrWhiteSpace(knowncolors))
				return null;

			return knowncolors
				.Split(Delimenator)
				.Select(color => Enum.Parse<KnownColor>(color));
		}
		private static string KnownColorsToString(IEnumerable<KnownColor>? knowncolors)
		{
			if (knowncolors == null)
				return string.Empty;

			return string.Join(Delimenator, knowncolors.Select(knowncolor => knowncolor.ToString()));
		}

		#endregion

		#region Ids

		private static string IdsToString(IEnumerable<int>? ids)
		=> ids == null
			? string.Empty
			: string.Join(Delimenator, ids);
		private static IEnumerable<int>? StringToIds(string ids)
			=> string.IsNullOrWhiteSpace(ids)
				? null
				: ids.Split(Delimenator)
					.Select(id => int.TryParse(id, out int outId) ? outId : -1)
					.Where(id => id != -1)
					.ToList();

		#endregion

		#region Strings

		private static string StringsToString(IEnumerable<string>? strings)
		{
			if (strings == null)
				return string.Empty;

			if (strings.Any(str => str.Contains(Delimenator)))
				throw new ArithmeticException($"No string in stringList may contain the character '{Delimenator}'");

			return string.Join(Delimenator, strings);
		}
		private static IEnumerable<string>? StringToStrings(string strings)
			=> string.IsNullOrWhiteSpace(strings)
				? null
				: strings.Split(Delimenator).ToList();

		#endregion

		#region Terrains

		private static string TerrainsToString(IEnumerable<IPlanet.ITerrain>? terrains)
			=> terrains == null
				? string.Empty
				: !terrains.Any()
					? string.Empty
					: string.Join(Delimenator, terrains.Select(terrain => string.Format(
					   "{0}{1}",
					   terrain.Type ?? "null",
					   FlagsToDelimenatedFlags(terrain.Flags?.ToArray()))));
		private static IEnumerable<IPlanet.ITerrain>? StringToTerrains(string terrains)
			=> terrains == null || string.IsNullOrWhiteSpace(terrains)
				? null
				: terrains.Split(Delimenator)
					.Select(terrainString =>
					{
						int indexOfFlagEntry = terrainString.IndexOf("[");
						int indexOfFlagExit = terrainString.IndexOf("]");

						if (indexOfFlagEntry == 0) throw new Exception("character '[' indicating start of terrain flags not found");
						if (indexOfFlagExit == 0) throw new Exception("character ']' indicating end of terrain flags not found");

						string typeSubstring = terrainString.Substring(0, indexOfFlagEntry);

						return new IPlanet.ITerrain.Default
						{
							Type = typeSubstring == "null"
								? null
								: IPlanet.ITerrain.Types.AsEnumerable().FirstOrDefault(_ => string.Equals(typeSubstring, _, StringComparison.OrdinalIgnoreCase)),

							Flags = (IEnumerable<string>?)DelimenatedFlagsToFlags(terrainString.Replace(typeSubstring, string.Empty))?.ToList()
						};

					}).ToList();

		#endregion

		#region Uris

		private static string UriModelsToString(IEnumerable<IStarWarsModel.IURI>? urimodels)
		{
			if (urimodels == null)
				return string.Empty;

			IEnumerable<string> urideliminatedlist = urimodels
				.Select(uriTuple =>
				{
					return string.Format("{0} {1}", uriTuple.Key, uriTuple.Uri?.ToString().Replace(" ", "%20"));
				});

			return string.Join(" ", urideliminatedlist);
		}
		private static IEnumerable<IStarWarsModel.IURI>? StringToUriModels(string urimodels)
		{
			if (urimodels == null)
				return null;

			List<IStarWarsModel.IURI> UriPairs = new();

			IStarWarsModel.IURI? temp = null;

			foreach (string urikeyoruri in urimodels.Split(" "))
			{
				if (string.IsNullOrWhiteSpace(temp?.Key))
					(temp ??= new IStarWarsModel.IURI.Default()).Key = urikeyoruri;
				else if (temp?.Uri == null)
					(temp ??= new IStarWarsModel.IURI.Default()).Uri = Uri.TryCreate(urikeyoruri, UriKind.RelativeOrAbsolute, out Uri? uri) && uri != null
						? uri
						: null;

				if (!string.IsNullOrWhiteSpace(temp?.Key) && temp?.Uri != null)
				{
					UriPairs.Add(temp);

					temp = null;
				}
			}

			return UriPairs;
		}

		#endregion
	}
}
