using Api.Queries;
using Api.Repository.Options;
using Api.Swagger.Options;
using Api.Swagger.Schemas;

using Domain.Models;

using GraphQL.Server.Ui.Altair;
using GraphQL.Server.Ui.GraphiQL;
using GraphQL.Server.Ui.Playground;
using GraphQL.Server.Ui.Voyager;

using Localisation;
using Localisation.Abstractions.Characters;
using Localisation.Abstractions.Factions;
using Localisation.Abstractions.Films;
using Localisation.Abstractions.Manufacturers;
using Localisation.Abstractions.Planets;
using Localisation.Abstractions.Species;
using Localisation.Abstractions.Starships;
using Localisation.Abstractions.StarWarsModels;
using Localisation.Abstractions.Swagger;
using Localisation.Abstractions.Vehicles;
using Localisation.Abstractions.Weapons;
using Localisation.Utils.Swagger;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Swashbuckle.AspNetCore.SwaggerUI;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Api.MVC
{
	public partial class Startup
	{
		private IServiceCollection ConfigureServicesSwagger(IServiceCollection servicecollection)
		{
			servicecollection.AddSwagger(swaggeroptions =>
			{
				swaggeroptions.DocumentsFilepaths = swaggerdocument =>
				{
					string directorypath = Path.Combine(
						WebHostEnvironment.WebRootPath,
						"swaggerdocs",
						swaggerdocument.Openapi ?? string.Empty);

					Directory.CreateDirectory(directorypath);

					IEnumerable<string> paths = Enumerable.Empty<string>();

					if (swaggerdocument.Culture?.Culture is CultureInfo)
					{
						paths = paths.Append(Path.Combine(directorypath, string.Format("docs.{0}.json", swaggerdocument.Culture.Culture.Name)));

						if (swaggerdocument.Culture.IsDefault)
							paths = paths.Append(Path.Combine(directorypath, "docs.json"));
					}

					return paths;
				};
				swaggeroptions.Documents = serviceprovider =>
				{
					ILocalisation localisation = serviceprovider.GetRequiredService<ILocalisation>();

					return LocalisationCultures.AsEnumerable()
						.Select(localisationculture =>
						{
							ISwaggerEndpointsLocalisation? endpointslocalisation = localisation
								.SwaggerLocalisations?
								.SwaggerEndpoints(localisationculture);
							ISwaggerParametersLocalisation? parameterslocalisation = localisation
								.SwaggerLocalisations?
								.SwaggerParameters(localisationculture);

							Dictionary<string, SwaggerPath> paths = Routes.Path_AsEnumerable()
								.ToDictionary(
									keySelector: path => path,
									elementSelector: path =>
									{
										SwaggerOperation getswaggeroperation = new()
										{
											Deprecated = false,
											Responses = new Dictionary<string, SwaggerPathResponse>
											{
												{
													"200",
													new SwaggerPathResponse
													{
														Description = "Success",
													}
												}
											},
											Tags = new string[]
											{
												"StarWarX Api"
											},
										};

										IEnumerable<string>? query_orderby_sortkeys = null;
										Func<string, string?>? query_orderby_titles = null;
										Func<string, string?>? query_orderby_descriptions = null;

										switch (path)
										{
											case Routes.Path_Characters:
												{
													query_orderby_sortkeys = ICharacter.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.CharacterLocalisations?.CharacterSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.CharacterLocalisations?.CharacterSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Characters?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Characters?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Characters?.Summary;
												}
												break;
											case Routes.Path_Factions:
												{
													query_orderby_sortkeys = IFaction.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.FactionLocalisations?.FactionSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.FactionLocalisations?.FactionSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Factions?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Factions?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Factions?.Summary;
												}
												break;
											case Routes.Path_Films:
												{
													query_orderby_sortkeys = IFilm.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.FilmLocalisations?.FilmSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.FilmLocalisations?.FilmSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Films?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Films?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Films?.Summary;
												}
												break;
											case Routes.Path_Manufacturers:
												{
													query_orderby_sortkeys = IManufacturer.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.ManufacturerLocalisations?.ManufacturerSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.ManufacturerLocalisations?.ManufacturerSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Manufacturers?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Manufacturers?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Manufacturers?.Summary;
												}
												break;
											case Routes.Path_Planets:
												{
													query_orderby_sortkeys = IPlanet.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.PlanetLocalisations?.PlanetSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.PlanetLocalisations?.PlanetSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Planets?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Planets?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Planets?.Summary;
												}
												break;
											case Routes.Path_Species:
												{
													query_orderby_sortkeys = ISpecie.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.SpecieLocalisations?.SpecieSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.SpecieLocalisations?.SpecieSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Species?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Species?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Species?.Summary;
												}
												break;
											case Routes.Path_Starships:
												{
													query_orderby_sortkeys = IStarship.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.StarshipLocalisations?.StarshipSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.StarshipLocalisations?.StarshipSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Starships?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Starships?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Starships?.Summary;
												}
												break;
											case Routes.Path_Vehicles:
												{
													query_orderby_sortkeys = IVehicle.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.VehicleLocalisations?.VehicleSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.VehicleLocalisations?.VehicleSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Vehicles?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Vehicles?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Vehicles?.Summary;
												}
												break;
											case Routes.Path_Weapons:
												{
													query_orderby_sortkeys = IWeapon.ISortKeys.Keys.AsEnumerable();
													query_orderby_titles = sortkey => localisation.WeaponLocalisations?.WeaponSortKeysTitles(localisationculture)?.GetValue(sortkey);
													query_orderby_descriptions = sortkey => localisation.WeaponLocalisations?.WeaponSortKeysDescriptions(localisationculture)?.GetValue(sortkey);

													getswaggeroperation.Description = endpointslocalisation?.Weapons?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Weapons?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Weapons?.Summary;
												}
												break;
											case Routes.Path_Search:
												{
													getswaggeroperation.Description = endpointslocalisation?.Search?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Search?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Search?.Summary;
												}
												break;
											case Routes.Path_Meta:
												{
													getswaggeroperation.Description = endpointslocalisation?.Meta?.Description;
													getswaggeroperation.OperationId = endpointslocalisation?.Meta?.OperationId;
													getswaggeroperation.Summary = endpointslocalisation?.Meta?.Summary;
												}
												break;

											default: break;
										}

										getswaggeroperation.Parameters = path switch
										{
											Routes.Path_Search => Enumerable.Empty<SwaggerSchema>()
												.Concat(CharactersSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(FactionsSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(FilmsSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(ManufacturersSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(PlanetsSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(SpeciesSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(StarshipsSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(VehiclesSearchSwaggerSchemas(localisation, localisationculture))
												.Concat(WeaponsSearchSwaggerSchemas(localisation, localisationculture))
												.Where(swaggerschema => swaggerschema.Id != StarWarsModelSearchQuerySchemas.Id_SearchString)
												.Prepend(StarWarsModelSearchQuerySchemas.Default().SearchString)
												.OfType<SwaggerSchema>(),

											Routes.Path_Meta => QuerySchemas
												.QueryMeta()
												.AsEnumerable()
												.OfType<SwaggerSchema>()
												.Select(swaggerschema =>
												{
													switch (swaggerschema.Id)
													{
														case QuerySchemas.QueryMeta_Id_AdditionsSince:
															{
																swaggerschema.Description = parameterslocalisation?.QueryMeta_AdditionsSince_Desription;
															}
															break;
														case QuerySchemas.QueryMeta_Id_EditsSince:
															{
																swaggerschema.Description = parameterslocalisation?.QueryMeta_EditsSince_Desription;
															}
															break;

														default: break;
													}

													return swaggerschema;
												}),

											_ => QuerySchemas
													.Query()
													.AsEnumerable()
													.OfType<SwaggerSchema>()
													.Select(swaggerschema =>
													{
														switch (swaggerschema.Id)
														{
															case QuerySchemas.Query_Id_Ids:
																{
																	swaggerschema.Description = parameterslocalisation?.Query_Ids_Desription;
																}
																break;		  
															case QuerySchemas.Query_Id_IdsToSkip:
																{
																	swaggerschema.Description = parameterslocalisation?.Query_IdsToSkip_Desription;
																}
																break;
															case QuerySchemas.Query_Id_ItemsPerPage:
																{
																	swaggerschema.Description = parameterslocalisation?.Query_ItemsPerPage_Desription;
																}
																break;
															case QuerySchemas.Query_Id_OrderBy:
																{
																	swaggerschema.Description = parameterslocalisation?.Query_OrderBy_Desription;
																	swaggerschema.Examples = query_orderby_sortkeys?
																		.OrderBy(sortkey => sortkey)
																		.ToDictionary(
																			keySelector: sortkey => sortkey,
																			elementSelector: sortkey => new SwaggerExample
																			{
																				Description = query_orderby_descriptions?.Invoke(sortkey),
																				Summary = query_orderby_titles?.Invoke(sortkey),
																				Value = sortkey,
																			});
																}
																break;
															case QuerySchemas.Query_Id_Page:
																{
																	swaggerschema.Description = parameterslocalisation?.Query_Page_Desription;
																}
																break;

															default: break;
														}

														return swaggerschema;
													}),
										};

										return new SwaggerPath
										{
											{ "get", getswaggeroperation }
										};
									});

							return new SwaggerDocument
							{
								Culture = new SwaggerCulture
								{
									Culture = localisationculture,
									IsDefault = localisationculture.Name == localisation.DefaultCultureInfo?.Name,
								},
								Info = new SwaggerInfo
								{
									Description = localisation.GetString(SwaggerGeneral.Keys.Description, SwaggerGeneral.ResourceName, localisationculture),
									License = new SwaggerLicense
									{
										Name = "Apache 2.0",
										Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.html", UriKind.Absolute),
									},
									Title = localisation.GetString(SwaggerGeneral.Keys.Title, SwaggerGeneral.ResourceName, localisationculture),
									Version = "1.0",
								},
								Openapi = SwaggerDocument.Versions.V_303,
								Paths = paths,
								Servers = new SwaggerServer[]
								{
									new SwaggerServer
									{
										Description = "Default Server",
										Url = new Uri(Routes.Api_Rest, UriKind.Relative),
									}
								},
								Tags = new SwaggerTag[]
								{
									new SwaggerTag
									{
										Name = "StarWarX Api",
										Description = "All REST Api endpoints"
									}
								},
							};
						});
				};
			});

			return servicecollection;
		}							 

		private static readonly ISearchItemLocalisation<bool> SearchItemLocalisation = new ISearchItemLocalisation.Default<bool>(false)
		{
			Description = true,
		};
		private static readonly ISearchListLocalisation<bool> SearchListLocalisation = new ISearchListLocalisation.Default<bool>(false)
		{
			Description = SearchItemLocalisation.Description,
		};
		private static readonly ISearchRangeLocalisation<bool> SearchRangeLocalisation = new ISearchRangeLocalisation.Default<bool>(false)
		{
			Description = SearchItemLocalisation.Description,
			LowerDescription = true,
			UpperDescription = true,
		};

		private static ICharacterSearchLocalisation? GetCharacterSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.CharacterLocalisations?.CharacterSearch(
				cultureinfo,
				new ICharacterSearchLocalisation.DefaultTyped<bool>(false)
				{
					BirthYearRange = SearchRangeLocalisation,
					BirthYearsList = SearchListLocalisation,
					EyeColorsList = SearchListLocalisation,
					HairColorsList = SearchListLocalisation,
					HeightsList = SearchListLocalisation,
					HeightRange = SearchRangeLocalisation,
					MassesList = SearchListLocalisation,
					MassRange = SearchRangeLocalisation,
					SexesList = SearchListLocalisation,
					SkinColorsList = SearchListLocalisation,
				});
		}
		private static IFactionSearchLocalisation? GetFactionSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.FactionLocalisations?.FactionSearch(
				cultureinfo,
				new IFactionSearchLocalisation.DefaultTyped<bool>(false) { });
		}
		private static IFilmSearchLocalisation? GetFilmSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.FilmLocalisations?.FilmSearch(
				cultureinfo,
				new IFilmSearchLocalisation.DefaultTyped<bool>(false)
				{
					DurationsList = SearchListLocalisation,
					DurationRange = SearchRangeLocalisation,
					EpisodeIdsList = SearchListLocalisation,
					EpisodeIdRange = SearchRangeLocalisation,
					ReleaseDatesList = SearchListLocalisation,
					ReleaseDateRange = SearchRangeLocalisation,
				});
		}
		private static IManufacturerSearchLocalisation? GetManufacturerSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.ManufacturerLocalisations?.ManufacturerSearch(
				cultureinfo,
				new IManufacturerSearchLocalisation.DefaultTyped<bool>(false) { });
		}
		private static IPlanetSearchLocalisation? GetPlanetSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.PlanetLocalisations?.PlanetSearch(
				cultureinfo,
				new IPlanetSearchLocalisation.DefaultTyped<bool>(false)
				{
					ClimateFlagsList = SearchListLocalisation,
					ClimateTypesList = SearchListLocalisation,
					DiametersList = SearchListLocalisation,
					DiameterRange = SearchRangeLocalisation,
					GravitiesList = SearchListLocalisation,
					GravityRange = SearchRangeLocalisation,
					OrbitalPeriodsList = SearchListLocalisation,
					OrbitalPeriodRange = SearchRangeLocalisation,
					PopulationsList = SearchListLocalisation,
					PopulationRange = SearchRangeLocalisation,
					RotationalPeriodsList = SearchListLocalisation,
					RotationalPeriodRange = SearchRangeLocalisation,
					SurfaceWatersList = SearchListLocalisation,
					SurfaceWaterRange = SearchRangeLocalisation,
					TerrainFlagsList = SearchListLocalisation,
					TerrainTypesList = SearchListLocalisation,
				});
		}
		private static ISpecieSearchLocalisation? GetSpecieSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.SpecieLocalisations?.SpecieSearch(
				cultureinfo,
				new ISpecieSearchLocalisation.DefaultTyped<bool>(false)
				{
					AverageHeightsList = SearchListLocalisation,
					AverageHeightRange = SearchRangeLocalisation,
					AverageLifespansList = SearchListLocalisation,
					AverageLifespanRange = SearchRangeLocalisation,
					ClassificationsList = SearchListLocalisation,
					DesignationsList = SearchListLocalisation,
					EyeColorsList = SearchListLocalisation,
					HairColorsList = SearchListLocalisation,
					LanguagesList = SearchListLocalisation,
					SkinColorsList = SearchListLocalisation,
				});
		}
		private static IStarshipSearchLocalisation? GetStarshipSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.StarshipLocalisations?.StarshipSearch(
				cultureinfo,
				new IStarshipSearchLocalisation.DefaultTyped<bool>(false)
				{
					CargoCapacitiesList = SearchListLocalisation,
					CargoCapacityRange = SearchRangeLocalisation,
					CostInCreditsList = SearchListLocalisation,
					CostInCreditRange = SearchRangeLocalisation,
					HyperdriveRatingsList = SearchListLocalisation,
					HyperdriveRatingRange = SearchRangeLocalisation,
					LengthsList = SearchListLocalisation,
					LengthRange = SearchRangeLocalisation,
					MaxAtmospheringSpeedsList = SearchListLocalisation,
					MaxAtmospheringSpeedRange = SearchRangeLocalisation,
					MaxCrewsList = SearchListLocalisation,
					MaxCrewRange = SearchRangeLocalisation,
					MinCrewsList = SearchListLocalisation,
					MinCrewRange = SearchRangeLocalisation,
					MGLTsList = SearchListLocalisation,
					MGLTRange = SearchRangeLocalisation,
					PassengersList = SearchListLocalisation,
					PassengerRange = SearchRangeLocalisation,
				});
		}
		private static IVehicleSearchLocalisation? GetVehicleSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.VehicleLocalisations?.VehicleSearch(
				cultureinfo,
				new IVehicleSearchLocalisation.DefaultTyped<bool>(false)
				{
					CargoCapacitiesList = SearchListLocalisation,
					CargoCapacityRange = SearchRangeLocalisation,
					CostInCreditsList = SearchListLocalisation,
					CostInCreditRange = SearchRangeLocalisation,
					LengthsList = SearchListLocalisation,
					LengthRange = SearchRangeLocalisation,
					MaxAtmospheringSpeedsList = SearchListLocalisation,
					MaxAtmospheringSpeedRange = SearchRangeLocalisation,
					MaxCrewsList = SearchListLocalisation,
					MaxCrewRange = SearchRangeLocalisation,
					MinCrewsList = SearchListLocalisation,
					MinCrewRange = SearchRangeLocalisation,
					PassengersList = SearchListLocalisation,
					PassengerRange = SearchRangeLocalisation,
				});
		}
		private static IWeaponSearchLocalisation? GetWeaponSearchLocalisation(ILocalisation localisation, CultureInfo cultureinfo)
		{
			return localisation.WeaponLocalisations?.WeaponSearch(
				cultureinfo,
				new IWeaponSearchLocalisation.DefaultTyped<bool>(false) { });
		}

		private static IEnumerable<SwaggerSchema> CharactersSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			ICharacterSearchLocalisation? charactersearchlocalisation = GetCharacterSearchLocalisation(localisation, cultureinfo);

			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IPlanet.ISearchContainables<string?>? planetsearchcontainableslocalisation = localisation.PlanetLocalisations?
				.PlanetSearchContainablesDescriptions(cultureinfo);

			return CharactersSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Character."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Character.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						CharactersSearchQuerySchemas.Id_BirthYears => charactersearchlocalisation?.BirthYearsList?.Description,
						CharactersSearchQuerySchemas.Id_BirthYearRangeLower => charactersearchlocalisation?.BirthYearRange?.LowerDescription,
						CharactersSearchQuerySchemas.Id_BirthYearRangeUpper => charactersearchlocalisation?.BirthYearRange?.UpperDescription,
						CharactersSearchQuerySchemas.Id_Description => charactersearchcontainableslocalisation?.Description,
						CharactersSearchQuerySchemas.Id_EyeColors => charactersearchlocalisation?.EyeColorsList?.Description,
						CharactersSearchQuerySchemas.Id_HairColors => charactersearchlocalisation?.HairColorsList?.Description,
						CharactersSearchQuerySchemas.Id_Heights => charactersearchlocalisation?.HeightsList?.Description,
						CharactersSearchQuerySchemas.Id_HeightRangeLower => charactersearchlocalisation?.HeightRange?.LowerDescription,
						CharactersSearchQuerySchemas.Id_HeightRangeUpper => charactersearchlocalisation?.HeightRange?.UpperDescription,
						CharactersSearchQuerySchemas.Id_HomeworldDescription => planetsearchcontainableslocalisation?.Description,
						CharactersSearchQuerySchemas.Id_HomeworldName => planetsearchcontainableslocalisation?.Name,
						CharactersSearchQuerySchemas.Id_Masses => charactersearchlocalisation?.MassesList?.Description,
						CharactersSearchQuerySchemas.Id_MassRangeLower => charactersearchlocalisation?.MassRange?.LowerDescription,
						CharactersSearchQuerySchemas.Id_MassRangeUpper => charactersearchlocalisation?.MassRange?.UpperDescription,
						CharactersSearchQuerySchemas.Id_Name => charactersearchcontainableslocalisation?.Name,
						CharactersSearchQuerySchemas.Id_Sexes => charactersearchlocalisation?.SexesList?.Description,
						CharactersSearchQuerySchemas.Id_SkinColors => charactersearchlocalisation?.SkinColorsList?.Description,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> FactionsSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IFaction.ISearchContainables<string?>? factionsearchcontainableslocalisation = localisation.FactionLocalisations?
				.FactionSearchContainablesDescriptions(cultureinfo);

			return FactionsSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Faction."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Faction.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						FactionsSearchQuerySchemas.Id_AlliedCharactersDescription => charactersearchcontainableslocalisation?.Description,
						FactionsSearchQuerySchemas.Id_AlliedCharactersName => charactersearchcontainableslocalisation?.Name,
						FactionsSearchQuerySchemas.Id_AlliedFactionsDescription => factionsearchcontainableslocalisation?.Description,
						FactionsSearchQuerySchemas.Id_AlliedFactionsName => factionsearchcontainableslocalisation?.Name,
						FactionsSearchQuerySchemas.Id_Description => factionsearchcontainableslocalisation?.Description,
						FactionsSearchQuerySchemas.Id_LeadersDescription => charactersearchcontainableslocalisation?.Description,
						FactionsSearchQuerySchemas.Id_LeadersName => charactersearchcontainableslocalisation?.Name,
						FactionsSearchQuerySchemas.Id_MemberCharactersDescription => charactersearchcontainableslocalisation?.Description,
						FactionsSearchQuerySchemas.Id_MemberCharactersName => charactersearchcontainableslocalisation?.Name,
						FactionsSearchQuerySchemas.Id_MemberFactionsDescription => factionsearchcontainableslocalisation?.Description,
						FactionsSearchQuerySchemas.Id_MemberFactionsName => factionsearchcontainableslocalisation?.Name,
						FactionsSearchQuerySchemas.Id_Name => factionsearchcontainableslocalisation?.Name,
						FactionsSearchQuerySchemas.Id_OrganizationTypes => factionsearchcontainableslocalisation?.OrganizationTypes,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> FilmsSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			IFilmSearchLocalisation? filmsearchlocalisation = GetFilmSearchLocalisation(localisation, cultureinfo);

			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IFaction.ISearchContainables<string?>? factionsearchcontainableslocalisation = localisation.FactionLocalisations?
				.FactionSearchContainablesDescriptions(cultureinfo);
			IFilm.ISearchContainables<string?>? filmsearchcontainableslocalisation = localisation.FilmLocalisations?
				.FilmSearchContainablesDescriptions(cultureinfo);
			IManufacturer.ISearchContainables<string?>? manufacturersearchcontainableslocalisation = localisation.ManufacturerLocalisations?
				.ManufacturerSearchContainablesDescriptions(cultureinfo);
			IPlanet.ISearchContainables<string?>? planetsearchcontainableslocalisation = localisation.PlanetLocalisations?
				.PlanetSearchContainablesDescriptions(cultureinfo);
			ISpecie.ISearchContainables<string?>? speciesearchcontainableslocalisation = localisation.SpecieLocalisations?
				.SpecieSearchContainablesDescriptions(cultureinfo);
			IStarship.ISearchContainables<string?>? starshipsearchcontainableslocalisation = localisation.StarshipLocalisations?
				.StarshipSearchContainablesDescriptions(cultureinfo);
			IVehicle.ISearchContainables<string?>? vehiclesearchcontainableslocalisation = localisation.VehicleLocalisations?
				.VehicleSearchContainablesDescriptions(cultureinfo);
			IWeapon.ISearchContainables<string?>? weaponsearchcontainableslocalisation = localisation.WeaponLocalisations?
				.WeaponSearchContainablesDescriptions(cultureinfo);

			return FilmsSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Film."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Film.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						FilmsSearchQuerySchemas.Id_CastMembers => filmsearchcontainableslocalisation?.CastMembers,
						FilmsSearchQuerySchemas.Id_CharactersDescription => charactersearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_CharactersName => charactersearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_Description => filmsearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_Director => filmsearchcontainableslocalisation?.Director,
						FilmsSearchQuerySchemas.Id_Durations => filmsearchlocalisation?.DurationsList?.Description,
						FilmsSearchQuerySchemas.Id_DurationRangeLower => filmsearchlocalisation?.DurationRange?.LowerDescription,
						FilmsSearchQuerySchemas.Id_DurationRangeUpper => filmsearchlocalisation?.DurationRange?.UpperDescription,
						FilmsSearchQuerySchemas.Id_EpisodeIds => filmsearchlocalisation?.EpisodeIdsList?.Description,
						FilmsSearchQuerySchemas.Id_EpisodeIdRangeLower => filmsearchlocalisation?.EpisodeIdRange?.LowerDescription,
						FilmsSearchQuerySchemas.Id_EpisodeIdRangeUpper => filmsearchlocalisation?.EpisodeIdRange?.UpperDescription,
						FilmsSearchQuerySchemas.Id_FactionsDescription => factionsearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_FactionsName => factionsearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_ManufacturersDescription => manufacturersearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_ManufacturersName => manufacturersearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_OpeningCrawl => filmsearchcontainableslocalisation?.OpeningCrawl,
						FilmsSearchQuerySchemas.Id_PlanetsDescription => planetsearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_PlanetsName => planetsearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_Producers => filmsearchcontainableslocalisation?.Producers,
						FilmsSearchQuerySchemas.Id_ReleaseDates => filmsearchlocalisation?.ReleaseDatesList?.Description,
						FilmsSearchQuerySchemas.Id_ReleaseDateRangeLower => filmsearchlocalisation?.ReleaseDateRange?.LowerDescription,
						FilmsSearchQuerySchemas.Id_ReleaseDateRangeUpper => filmsearchlocalisation?.ReleaseDateRange?.UpperDescription,
						FilmsSearchQuerySchemas.Id_SpeciesDescription => speciesearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_SpeciesName => speciesearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_StarshipsDescription => starshipsearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_StarshipsModel => starshipsearchcontainableslocalisation?.Model,
						FilmsSearchQuerySchemas.Id_StarshipsName => starshipsearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_StarshipsStarshipClass => starshipsearchcontainableslocalisation?.StarshipClass,
						FilmsSearchQuerySchemas.Id_StarshipsStarshipClassFlags => starshipsearchcontainableslocalisation?.StarshipClassFlags,
						FilmsSearchQuerySchemas.Id_Title => filmsearchcontainableslocalisation?.Title,
						FilmsSearchQuerySchemas.Id_VehiclesDescription => vehiclesearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_VehiclesModel => vehiclesearchcontainableslocalisation?.Model,
						FilmsSearchQuerySchemas.Id_VehiclesName => vehiclesearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_VehiclesVehicleClass => vehiclesearchcontainableslocalisation?.VehicleClass,
						FilmsSearchQuerySchemas.Id_VehiclesVehicleClassFlags => vehiclesearchcontainableslocalisation?.VehicleClassFlags,
						FilmsSearchQuerySchemas.Id_WeaponsDescription => weaponsearchcontainableslocalisation?.Description,
						FilmsSearchQuerySchemas.Id_WeaponsModel => weaponsearchcontainableslocalisation?.Model,
						FilmsSearchQuerySchemas.Id_WeaponsName => weaponsearchcontainableslocalisation?.Name,
						FilmsSearchQuerySchemas.Id_WeaponsWeaponClass => weaponsearchcontainableslocalisation?.WeaponClass,
						FilmsSearchQuerySchemas.Id_WeaponsWeaponClassFlags => weaponsearchcontainableslocalisation?.WeaponClassFlags,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> ManufacturersSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			IManufacturer.ISearchContainables<string?>? manufacturersearchcontainableslocalisation = localisation.ManufacturerLocalisations?
				.ManufacturerSearchContainablesDescriptions(cultureinfo);
			IPlanet.ISearchContainables<string?>? planetsearchcontainableslocalisation = localisation.PlanetLocalisations?
				.PlanetSearchContainablesDescriptions(cultureinfo);
			IStarship.ISearchContainables<string?>? starshipsearchcontainableslocalisation = localisation.StarshipLocalisations?
				.StarshipSearchContainablesDescriptions(cultureinfo);
			IVehicle.ISearchContainables<string?>? vehiclesearchcontainableslocalisation = localisation.VehicleLocalisations?
				.VehicleSearchContainablesDescriptions(cultureinfo);
			IWeapon.ISearchContainables<string?>? weaponsearchcontainableslocalisation = localisation.WeaponLocalisations?
				.WeaponSearchContainablesDescriptions(cultureinfo);

			return ManufacturersSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Manufacturer."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Manufacturer.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						ManufacturersSearchQuerySchemas.Id_Description => manufacturersearchcontainableslocalisation?.Description,
						ManufacturersSearchQuerySchemas.Id_HeadquatersPlanetDescription => planetsearchcontainableslocalisation?.Description,
						ManufacturersSearchQuerySchemas.Id_HeadquatersPlanetName => planetsearchcontainableslocalisation?.Name,
						ManufacturersSearchQuerySchemas.Id_Name => manufacturersearchcontainableslocalisation?.Name,
						ManufacturersSearchQuerySchemas.Id_StarshipsDescription => starshipsearchcontainableslocalisation?.Description,
						ManufacturersSearchQuerySchemas.Id_StarshipsModel => starshipsearchcontainableslocalisation?.Model,
						ManufacturersSearchQuerySchemas.Id_StarshipsName => starshipsearchcontainableslocalisation?.Name,
						ManufacturersSearchQuerySchemas.Id_StarshipsStarshipClass => starshipsearchcontainableslocalisation?.StarshipClass,
						ManufacturersSearchQuerySchemas.Id_StarshipsStarshipClassFlags => starshipsearchcontainableslocalisation?.StarshipClassFlags,
						ManufacturersSearchQuerySchemas.Id_VehiclesDescription => vehiclesearchcontainableslocalisation?.Description,
						ManufacturersSearchQuerySchemas.Id_VehiclesModel => vehiclesearchcontainableslocalisation?.Model,
						ManufacturersSearchQuerySchemas.Id_VehiclesName => vehiclesearchcontainableslocalisation?.Name,
						ManufacturersSearchQuerySchemas.Id_VehiclesVehicleClass => vehiclesearchcontainableslocalisation?.VehicleClass,
						ManufacturersSearchQuerySchemas.Id_VehiclesVehicleClassFlags => vehiclesearchcontainableslocalisation?.VehicleClassFlags,
						ManufacturersSearchQuerySchemas.Id_WeaponsDescription => weaponsearchcontainableslocalisation?.Description,
						ManufacturersSearchQuerySchemas.Id_WeaponsModel => weaponsearchcontainableslocalisation?.Model,
						ManufacturersSearchQuerySchemas.Id_WeaponsName => weaponsearchcontainableslocalisation?.Name,
						ManufacturersSearchQuerySchemas.Id_WeaponsWeaponClass => weaponsearchcontainableslocalisation?.WeaponClass,
						ManufacturersSearchQuerySchemas.Id_WeaponsWeaponClassFlags => weaponsearchcontainableslocalisation?.WeaponClassFlags,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> PlanetsSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			IPlanetSearchLocalisation? planetsearchlocalisation = GetPlanetSearchLocalisation(localisation, cultureinfo);

			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IPlanet.ISearchContainables<string?>? planetsearchcontainableslocalisation = localisation.PlanetLocalisations?
				.PlanetSearchContainablesDescriptions(cultureinfo);

			return PlanetsSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Planet."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Planet.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						PlanetsSearchQuerySchemas.Id_ClimateTypes => planetsearchlocalisation?.ClimateTypesList?.Description,
						PlanetsSearchQuerySchemas.Id_ClimateFlags => planetsearchlocalisation?.ClimateFlagsList?.Description,
						PlanetsSearchQuerySchemas.Id_Description => planetsearchcontainableslocalisation?.Description,
						PlanetsSearchQuerySchemas.Id_Diameters => planetsearchlocalisation?.DiametersList?.Description,
						PlanetsSearchQuerySchemas.Id_DiameterRangeLower => planetsearchlocalisation?.DiameterRange?.LowerDescription,
						PlanetsSearchQuerySchemas.Id_DiameterRangeUpper => planetsearchlocalisation?.DiameterRange?.UpperDescription,
						PlanetsSearchQuerySchemas.Id_Gravities => planetsearchlocalisation?.GravitiesList?.Description,
						PlanetsSearchQuerySchemas.Id_GravityRangeLower => planetsearchlocalisation?.GravityRange?.LowerDescription,
						PlanetsSearchQuerySchemas.Id_GravityRangeUpper => planetsearchlocalisation?.GravityRange?.UpperDescription,
						PlanetsSearchQuerySchemas.Id_Name => planetsearchcontainableslocalisation?.Name,
						PlanetsSearchQuerySchemas.Id_OrbitalPeriods => planetsearchlocalisation?.OrbitalPeriodsList?.Description,
						PlanetsSearchQuerySchemas.Id_OrbitalPeriodRangeLower => planetsearchlocalisation?.OrbitalPeriodRange?.LowerDescription,
						PlanetsSearchQuerySchemas.Id_OrbitalPeriodRangeUpper => planetsearchlocalisation?.OrbitalPeriodRange?.UpperDescription,
						PlanetsSearchQuerySchemas.Id_Populations => planetsearchlocalisation?.PopulationsList?.Description,
						PlanetsSearchQuerySchemas.Id_PopulationRangeLower => planetsearchlocalisation?.PopulationRange?.LowerDescription,
						PlanetsSearchQuerySchemas.Id_PopulationRangeUpper => planetsearchlocalisation?.PopulationRange?.UpperDescription,
						PlanetsSearchQuerySchemas.Id_ResidentsDescription => charactersearchcontainableslocalisation?.Description,
						PlanetsSearchQuerySchemas.Id_ResidentsName => charactersearchcontainableslocalisation?.Name,
						PlanetsSearchQuerySchemas.Id_RotationalPeriods => planetsearchlocalisation?.RotationalPeriodsList?.Description,
						PlanetsSearchQuerySchemas.Id_RotationalPeriodRangeLower => planetsearchlocalisation?.RotationalPeriodRange?.LowerDescription,
						PlanetsSearchQuerySchemas.Id_RotationalPeriodRangeUpper => planetsearchlocalisation?.RotationalPeriodRange?.UpperDescription,
						PlanetsSearchQuerySchemas.Id_SurfaceWaters => planetsearchlocalisation?.SurfaceWatersList?.Description,
						PlanetsSearchQuerySchemas.Id_SurfaceWaterRangeLower => planetsearchlocalisation?.SurfaceWaterRange?.LowerDescription,
						PlanetsSearchQuerySchemas.Id_SurfaceWaterRangeUpper => planetsearchlocalisation?.SurfaceWaterRange?.UpperDescription,
						PlanetsSearchQuerySchemas.Id_TerrainTypes => planetsearchlocalisation?.TerrainTypesList?.Description,
						PlanetsSearchQuerySchemas.Id_TerrainFlags => planetsearchlocalisation?.TerrainFlagsList?.Description,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> SpeciesSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			ISpecieSearchLocalisation? speciesearchlocalisation = GetSpecieSearchLocalisation(localisation, cultureinfo);

			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IPlanet.ISearchContainables<string?>? planetsearchcontainableslocalisation = localisation.PlanetLocalisations?
				.PlanetSearchContainablesDescriptions(cultureinfo);
			ISpecie.ISearchContainables<string?>? speciesearchcontainableslocalisation = localisation.SpecieLocalisations?
				.SpecieSearchContainablesDescriptions(cultureinfo);

			return SpeciesSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Specie."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Specie.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						SpeciesSearchQuerySchemas.Id_AverageHeights => speciesearchlocalisation?.AverageHeightsList?.Description,
						SpeciesSearchQuerySchemas.Id_AverageHeightRangeLower => speciesearchlocalisation?.AverageHeightRange?.LowerDescription,
						SpeciesSearchQuerySchemas.Id_AverageHeightRangeUpper => speciesearchlocalisation?.AverageHeightRange?.UpperDescription,
						SpeciesSearchQuerySchemas.Id_AverageLifespans => speciesearchlocalisation?.AverageLifespansList?.Description,
						SpeciesSearchQuerySchemas.Id_AverageLifespanRangeLower => speciesearchlocalisation?.AverageLifespanRange?.LowerDescription,
						SpeciesSearchQuerySchemas.Id_AverageLifespanRangeUpper => speciesearchlocalisation?.AverageLifespanRange?.UpperDescription,
						SpeciesSearchQuerySchemas.Id_CharactersDescription => charactersearchcontainableslocalisation?.Description,
						SpeciesSearchQuerySchemas.Id_CharactersName => charactersearchcontainableslocalisation?.Name,
						SpeciesSearchQuerySchemas.Id_Classifications => speciesearchlocalisation?.ClassificationsList?.Description,
						SpeciesSearchQuerySchemas.Id_Description => speciesearchcontainableslocalisation?.Description,
						SpeciesSearchQuerySchemas.Id_Designations => speciesearchlocalisation?.DesignationsList?.Description,
						SpeciesSearchQuerySchemas.Id_EyeColors => speciesearchlocalisation?.EyeColorsList?.Description,
						SpeciesSearchQuerySchemas.Id_HairColors => speciesearchlocalisation?.HairColorsList?.Description,
						SpeciesSearchQuerySchemas.Id_HomeworldDescription => planetsearchcontainableslocalisation?.Description,
						SpeciesSearchQuerySchemas.Id_HomeworldName => planetsearchcontainableslocalisation?.Name,
						SpeciesSearchQuerySchemas.Id_Languages => speciesearchlocalisation?.LanguagesList?.Description,
						SpeciesSearchQuerySchemas.Id_Name => speciesearchcontainableslocalisation?.Name,
						SpeciesSearchQuerySchemas.Id_SkinColors => speciesearchlocalisation?.SkinColorsList?.Description,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> StarshipsSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			IStarshipSearchLocalisation? starshipsearchlocalisation = GetStarshipSearchLocalisation(localisation, cultureinfo);

			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IManufacturer.ISearchContainables<string?>? manufacturersearchcontainableslocalisation = localisation.ManufacturerLocalisations?
				.ManufacturerSearchContainablesDescriptions(cultureinfo);
			IStarship.ISearchContainables<string?>? starshipsearchcontainableslocalisation = localisation.StarshipLocalisations?
				.StarshipSearchContainablesDescriptions(cultureinfo);

			return StarshipsSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Starship."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Starship.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						StarshipsSearchQuerySchemas.Id_CargoCapacities => starshipsearchlocalisation?.CargoCapacitiesList?.Description,
						StarshipsSearchQuerySchemas.Id_CargoCapacityRangeLower => starshipsearchlocalisation?.CargoCapacityRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_CargoCapacityRangeUpper => starshipsearchlocalisation?.CargoCapacityRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_Consumables => starshipsearchlocalisation?.ConsumablesList?.Description,
						StarshipsSearchQuerySchemas.Id_ConsumableRangeLower => starshipsearchlocalisation?.ConsumableRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_ConsumableRangeUpper => starshipsearchlocalisation?.ConsumableRange?.UpperDescription,	  
						StarshipsSearchQuerySchemas.Id_CostInCredits => starshipsearchlocalisation?.CostInCreditsList?.Description,
						StarshipsSearchQuerySchemas.Id_CostInCreditRangeLower => starshipsearchlocalisation?.CostInCreditRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_CostInCreditRangeUpper => starshipsearchlocalisation?.CostInCreditRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_Description => starshipsearchcontainableslocalisation?.Description,
						StarshipsSearchQuerySchemas.Id_HyperdriveRatings => starshipsearchlocalisation?.HyperdriveRatingsList?.Description,
						StarshipsSearchQuerySchemas.Id_HyperdriveRatingRangeLower => starshipsearchlocalisation?.HyperdriveRatingRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_HyperdriveRatingRangeUpper => starshipsearchlocalisation?.HyperdriveRatingRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_Lengths => starshipsearchlocalisation?.LengthsList?.Description,
						StarshipsSearchQuerySchemas.Id_LengthRangeLower => starshipsearchlocalisation?.LengthRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_LengthRangeUpper => starshipsearchlocalisation?.LengthRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_ManufacturersDescription => manufacturersearchcontainableslocalisation?.Description,
						StarshipsSearchQuerySchemas.Id_ManufacturersName => manufacturersearchcontainableslocalisation?.Name,
						StarshipsSearchQuerySchemas.Id_MaxAtmospheringSpeeds => starshipsearchlocalisation?.MaxAtmospheringSpeedsList?.Description,
						StarshipsSearchQuerySchemas.Id_MaxAtmospheringSpeedRangeLower => starshipsearchlocalisation?.MaxAtmospheringSpeedRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_MaxAtmospheringSpeedRangeUpper => starshipsearchlocalisation?.MaxAtmospheringSpeedRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_MaxCrews => starshipsearchlocalisation?.MaxCrewsList?.Description,
						StarshipsSearchQuerySchemas.Id_MaxCrewRangeLower => starshipsearchlocalisation?.MaxCrewRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_MaxCrewRangeUpper => starshipsearchlocalisation?.MaxCrewRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_MinCrews => starshipsearchlocalisation?.MinCrewsList?.Description,
						StarshipsSearchQuerySchemas.Id_MinCrewRangeLower => starshipsearchlocalisation?.MinCrewRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_MinCrewRangeUpper => starshipsearchlocalisation?.MinCrewRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_MGLTs => starshipsearchlocalisation?.MGLTsList?.Description,
						StarshipsSearchQuerySchemas.Id_MGLTRangeLower => starshipsearchlocalisation?.MGLTRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_MGLTRangeUpper => starshipsearchlocalisation?.MGLTRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_Model => starshipsearchcontainableslocalisation?.Model,
						StarshipsSearchQuerySchemas.Id_Name => starshipsearchcontainableslocalisation?.Name,
						StarshipsSearchQuerySchemas.Id_Passengers => starshipsearchlocalisation?.PassengersList?.Description,
						StarshipsSearchQuerySchemas.Id_PassengerRangeLower => starshipsearchlocalisation?.PassengerRange?.LowerDescription,
						StarshipsSearchQuerySchemas.Id_PassengerRangeUpper => starshipsearchlocalisation?.PassengerRange?.UpperDescription,
						StarshipsSearchQuerySchemas.Id_PilotsDescription => charactersearchcontainableslocalisation?.Description,
						StarshipsSearchQuerySchemas.Id_PilotsName => charactersearchcontainableslocalisation?.Name,
						StarshipsSearchQuerySchemas.Id_StarshipClass => starshipsearchcontainableslocalisation?.StarshipClass,
						StarshipsSearchQuerySchemas.Id_StarshipClassFlags => starshipsearchcontainableslocalisation?.StarshipClassFlags,

						_ => null,
					};

					return swaggerschema;
				});
		}
		private static IEnumerable<SwaggerSchema> VehiclesSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			IVehicleSearchLocalisation? vehiclesearchlocalisation = GetVehicleSearchLocalisation(localisation, cultureinfo);

			ICharacter.ISearchContainables<string?>? charactersearchcontainableslocalisation = localisation.CharacterLocalisations?
				.CharacterSearchContainablesDescriptions(cultureinfo);
			IManufacturer.ISearchContainables<string?>? manufacturersearchcontainableslocalisation = localisation.ManufacturerLocalisations?
				.ManufacturerSearchContainablesDescriptions(cultureinfo);
			IVehicle.ISearchContainables<string?>? vehiclesearchcontainableslocalisation = localisation.VehicleLocalisations?
				.VehicleSearchContainablesDescriptions(cultureinfo);

			return VehiclesSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Vehicle."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Vehicle.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						VehiclesSearchQuerySchemas.Id_CargoCapacities => vehiclesearchlocalisation?.CargoCapacitiesList?.Description,
						VehiclesSearchQuerySchemas.Id_CargoCapacityRangeLower => vehiclesearchlocalisation?.CargoCapacityRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_CargoCapacityRangeUpper => vehiclesearchlocalisation?.CargoCapacityRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_Consumables => vehiclesearchlocalisation?.ConsumablesList?.Description,
						VehiclesSearchQuerySchemas.Id_ConsumableRangeLower => vehiclesearchlocalisation?.ConsumableRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_ConsumableRangeUpper => vehiclesearchlocalisation?.ConsumableRange?.UpperDescription,			 
						VehiclesSearchQuerySchemas.Id_CostInCredits => vehiclesearchlocalisation?.CostInCreditsList?.Description,
						VehiclesSearchQuerySchemas.Id_CostInCreditRangeLower => vehiclesearchlocalisation?.CostInCreditRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_CostInCreditRangeUpper => vehiclesearchlocalisation?.CostInCreditRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_Description => vehiclesearchcontainableslocalisation?.Description,
						VehiclesSearchQuerySchemas.Id_Lengths => vehiclesearchlocalisation?.LengthsList?.Description,
						VehiclesSearchQuerySchemas.Id_LengthRangeLower => vehiclesearchlocalisation?.LengthRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_LengthRangeUpper => vehiclesearchlocalisation?.LengthRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_ManufacturersDescription => manufacturersearchcontainableslocalisation?.Description,
						VehiclesSearchQuerySchemas.Id_ManufacturersName => manufacturersearchcontainableslocalisation?.Name,
						VehiclesSearchQuerySchemas.Id_MaxAtmospheringSpeeds => vehiclesearchlocalisation?.MaxAtmospheringSpeedsList?.Description,
						VehiclesSearchQuerySchemas.Id_MaxAtmospheringSpeedRangeLower => vehiclesearchlocalisation?.MaxAtmospheringSpeedRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_MaxAtmospheringSpeedRangeUpper => vehiclesearchlocalisation?.MaxAtmospheringSpeedRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_MaxCrews => vehiclesearchlocalisation?.MaxCrewsList?.Description,
						VehiclesSearchQuerySchemas.Id_MaxCrewRangeLower => vehiclesearchlocalisation?.MaxCrewRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_MaxCrewRangeUpper => vehiclesearchlocalisation?.MaxCrewRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_MinCrews => vehiclesearchlocalisation?.MinCrewsList?.Description,
						VehiclesSearchQuerySchemas.Id_MinCrewRangeLower => vehiclesearchlocalisation?.MinCrewRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_MinCrewRangeUpper => vehiclesearchlocalisation?.MinCrewRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_Model => vehiclesearchcontainableslocalisation?.Model,
						VehiclesSearchQuerySchemas.Id_Name => vehiclesearchcontainableslocalisation?.Name,
						VehiclesSearchQuerySchemas.Id_Passengers => vehiclesearchlocalisation?.PassengersList?.Description,
						VehiclesSearchQuerySchemas.Id_PassengerRangeLower => vehiclesearchlocalisation?.PassengerRange?.LowerDescription,
						VehiclesSearchQuerySchemas.Id_PassengerRangeUpper => vehiclesearchlocalisation?.PassengerRange?.UpperDescription,
						VehiclesSearchQuerySchemas.Id_PilotsDescription => charactersearchcontainableslocalisation?.Description,
						VehiclesSearchQuerySchemas.Id_PilotsName => charactersearchcontainableslocalisation?.Name,
						VehiclesSearchQuerySchemas.Id_VehicleClass => vehiclesearchcontainableslocalisation?.VehicleClass,
						VehiclesSearchQuerySchemas.Id_VehicleClassFlags => vehiclesearchcontainableslocalisation?.VehicleClassFlags,

						_ => null,
					};

				return swaggerschema;
			});
		}
		private static IEnumerable<SwaggerSchema> WeaponsSearchSwaggerSchemas(ILocalisation localisation, CultureInfo cultureinfo)
		{
			IManufacturer.ISearchContainables<string?>? manufacturersearchcontainableslocalisation = localisation.ManufacturerLocalisations?
				.ManufacturerSearchContainablesDescriptions(cultureinfo);
			IWeapon.ISearchContainables<string?>? weaponsearchcontainableslocalisation = localisation.WeaponLocalisations?
				.WeaponSearchContainablesDescriptions(cultureinfo);

			return WeaponsSearchQuerySchemas
				.Default()
				.AsEnumerable()
				.OfType<SwaggerSchema>()
				.Select(swaggerschema =>
				{
					if (swaggerschema.Name is string && !swaggerschema.Name.StartsWith("Weapon."))
						swaggerschema.Name = swaggerschema.Name.Insert(0, "Weapon.");

					swaggerschema.Description = swaggerschema.Id switch
					{
						WeaponsSearchQuerySchemas.Id_Description => weaponsearchcontainableslocalisation?.Description,
						WeaponsSearchQuerySchemas.Id_ManufacturersDescription => manufacturersearchcontainableslocalisation?.Description,
						WeaponsSearchQuerySchemas.Id_ManufacturersName => manufacturersearchcontainableslocalisation?.Name,
						WeaponsSearchQuerySchemas.Id_Model => weaponsearchcontainableslocalisation?.Model,
						WeaponsSearchQuerySchemas.Id_Name => weaponsearchcontainableslocalisation?.Name,
						WeaponsSearchQuerySchemas.Id_WeaponClass => weaponsearchcontainableslocalisation?.WeaponClass,
						WeaponsSearchQuerySchemas.Id_WeaponClassFlags => weaponsearchcontainableslocalisation?.WeaponClassFlags,

						_ => null,
					};

					return swaggerschema;
				});
		}
	}
}

