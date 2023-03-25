using Domain.Enums;
using Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries
{
	public static class IQueryMetaExtensions
	{
		public static IQueryMeta.IResult ProcessMetaQuery(
			this IQueryMeta querymeta, 
			IQueryable<ICharacter>? characters = null,
			IQueryable<IFaction>? factions = null,
			IQueryable<IFilm>? films = null,
			IQueryable<IManufacturer>? manufacturers = null,
			IQueryable<IPlanet>? planets = null,
			IQueryable<ISpecie>? species = null,
			IQueryable<IStarship>? starships = null,
			IQueryable<IVehicle>? vehicles = null,
			IQueryable<IWeapon>? weapons = null)
		{
			DateTime? additionssince = DateTime.TryParse(querymeta.AdditionsSince, out DateTime outadditionssince)
				? outadditionssince
				: new DateTime?();
			DateTime? editesince = DateTime.TryParse(querymeta.AdditionsSince, out DateTime outeditesince)
				? outeditesince
				: new DateTime?();

			if (additionssince is null && editesince is null)
				return new IQueryMeta.IResult.Default();

			bool Predicate(IStarWarsModel starwarsmodel)
			{
				if (additionssince.HasValue && starwarsmodel.Created > additionssince.Value)
					return true;

				if (editesince.HasValue && starwarsmodel.Edited > editesince.Value)
					return true;

				return false;
			}

			IEnumerable<IQueryMetaResult> results = Enumerable.Empty<IQueryMetaResult>();

			if (characters?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Character
			}) is IEnumerable<IQueryMetaResult> characterresults)
				results = results.Concat(characterresults);

			if (factions?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Faction
			}) is IEnumerable<IQueryMetaResult> factionresults)
				results = results.Concat(factionresults);

			if (films?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Film
			}) is IEnumerable<IQueryMetaResult> filmresults)
				results = results.Concat(filmresults);

			if (manufacturers?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Manufacturer
			}) is IEnumerable<IQueryMetaResult> manufacturerresults)
				results = results.Concat(manufacturerresults);

			if (planets?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Planet
			}) is IEnumerable<IQueryMetaResult> planetresults)
				results = results.Concat(planetresults);

			if (species?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Specie
			}) is IEnumerable<IQueryMetaResult> specieresults)
				results = results.Concat(specieresults);

			if (starships?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Starship
			}) is IEnumerable<IQueryMetaResult> starshipresults)
				results = results.Concat(starshipresults);

			if (vehicles?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Vehicle
			}) is IEnumerable<IQueryMetaResult> vehicleresults)
				results = results.Concat(vehicleresults);

			if (weapons?.Where(Predicate).Select(_ => new IQueryMetaResult.Default
			{
				Id = _.Id,
				StarWarsType = StarWarsTypes.Weapon
			}) is IEnumerable<IQueryMetaResult> weaponresults)
				results = results.Concat(weaponresults);

			return new IQueryMeta.IResult.Default
			{
				Results = results,
			}; ;
		}
	}
}