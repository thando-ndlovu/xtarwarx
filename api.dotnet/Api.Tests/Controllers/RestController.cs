using Api.Queries;

using Domain.Enums;
using Domain.Models;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Xunit;
using Xunit.Abstractions;

using Controller = Api.Controllers.RestController;

using JArray = Newtonsoft.Json.Linq.JArray;
using JObject = Newtonsoft.Json.Linq.JObject;
using JToken = Newtonsoft.Json.Linq.JToken;
using JsonTextReader = Newtonsoft.Json.JsonTextReader;

namespace Api.Tests.Controllers
{
	public class RestController
	{
		public RestController(ITestOutputHelper testoutputhelper)
		{
			_StringBuilder = new StringBuilder();
			_TestOutputHelper = testoutputhelper;
			_JsonSerializerOptions = new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
				WriteIndented = false,
			};
		}

		private readonly StringBuilder _StringBuilder;
		private readonly ITestOutputHelper _TestOutputHelper;
		private readonly JsonSerializerOptions _JsonSerializerOptions;
		private readonly static IEnumerable<IEnumerable<object>> RestControllerMemberData = Utils.ApiTypes.AsEnumerable()
			.Select(apitype =>
			{
				return Enumerable.Empty<object>()
					.Append(apitype)
					.Append(new IQuery.Default { Ids = new int[] { 1 } });
			});

		private void Assert<T>(IQuery.IResult<object>? expected, IQuery.IResult<object>? actual)where T : class, IStarWarsModel
		{					
			static void Cast(IEnumerable<object>? items, out IEnumerable<T>? casteditems, out IEqualityComparer<T>? comparer)
			{
				casteditems = null; 
				comparer = null; 

				switch (true)
				{
					case true when typeof(T) == typeof(ICharacter):

						comparer = new ICharacter.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new ICharacter.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IFaction):

						comparer = new IFaction.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IFaction.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IFilm):

						comparer = new IFilm.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IFilm.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IManufacturer):

						comparer = new IManufacturer.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IManufacturer.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IPlanet):

						comparer = new IPlanet.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IPlanet.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(ISpecie):

						comparer = new ISpecie.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new ISpecie.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IStarship):

						comparer = new IStarship.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IStarship.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IVehicle):

						comparer = new IVehicle.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IVehicle.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					case true when typeof(T) == typeof(IWeapon):

						comparer = new IWeapon.Comparer() as IEqualityComparer<T>;
						casteditems = items?.Select(item => new IWeapon.Default(1, item as JObject ?? JObject.FromObject(item)) as T).OfType<T>();

						break;

					default: break;
				}
			}

			string expectedjson = JsonSerializer.Serialize(expected, _JsonSerializerOptions);
			string actualjson = JsonSerializer.Serialize(actual, _JsonSerializerOptions);

			_TestOutputHelper.WriteLine(
				message: _StringBuilder.Clear()
					.AppendLine("ExpectedResult").AppendLine(expectedjson)
					.AppendLine()
					.AppendLine("ActualResult").AppendLine(actualjson)
					.ToString());

			Cast(expected?.Items, out IEnumerable<T>? expecteditems, out IEqualityComparer<T>? expectedcomparer);
			Cast(actual?.Items, out IEnumerable<T>? actualitems, out IEqualityComparer<T>? actualcomparer);

			Xunit.Assert.Equal(expectedjson, actualjson);
			Xunit.Assert.Equal(expected?.Page, actual?.Page);
			Xunit.Assert.Equal(expected?.Pages, actual?.Pages);
			Xunit.Assert.Equal(expecteditems, actualitems, expectedcomparer ?? actualcomparer ?? EqualityComparer<T>.Default);
		} 
		private void Assert(IQueryMeta.IResult? expected, IQueryMeta.IResult? actual)
		{
			_TestOutputHelper.WriteLine(
				message: _StringBuilder.Clear()
					.AppendLine("Expected Result")
					.AppendLine(JsonSerializer.Serialize(expected, _JsonSerializerOptions))
					.AppendLine()
					.AppendLine("Actual Result")
					.AppendLine(JsonSerializer.Serialize(actual, _JsonSerializerOptions))
					.ToString());

			Xunit.Assert.Equal(expected, actual);
		}
		private void Assert(IQuerySearch.IResult? expected, IQuerySearch.IResult? actual)
		{
			_TestOutputHelper.WriteLine(
				message: _StringBuilder.Clear()
					.AppendLine("ExpectedResult")
					.AppendLine(JsonSerializer.Serialize(expected, _JsonSerializerOptions))
					.AppendLine()
					.AppendLine("ActualResult")
					.AppendLine(JsonSerializer.Serialize(actual, _JsonSerializerOptions))
					.ToString());

			Xunit.Assert.Equal(expected?.Page, actual?.Page);
			Xunit.Assert.Equal(expected?.Pages, actual?.Pages);
			Xunit.Assert.Equal(expected?.Items, actual?.Items);
		}

		#region Weapons

		public static IEnumerable<object[]> SearchMemberData => Utils.ApiTypes.AsEnumerable()
			.Select(apitype =>
			{
				return Enumerable.Empty<object>()
					.Append(apitype)
					.Append(new IQuerySearch.Default {  SearchString = "Skywalker" })
					.Append(new Func<IServiceProvider, IQuerySearch, Task<IQuerySearch.IResult?>>(async (serviceprovider, query) =>
					{
						Controller controller = new(serviceprovider);

						if (query is IQuerySearch.Default querydefault)
							return await controller.Search(querydefault);

						return null;

					})).ToArray();
			});

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(Controller.Search), "")]
		public async void Search(string apitype, IQuerySearch query, Func<IServiceProvider, IQuerySearch, Task<IQuerySearch.IResult?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Search)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuerySearch.IResult? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuerySearch.IResult actualresult = new IQuerySearch.IResult.Default
			{
				Page = actualresultjobject.GetValue(nameof(IQuerySearch.IResult.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuerySearch.IResult.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuerySearch.IResult.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken =>
					{
						JObject jobject = JObject.FromObject(jtoken);

						IQuerySearchResult result = new IQuerySearchResult.Default { };

						if (jobject.GetValue(nameof(IQuerySearchResult.Id), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is int idvalue)
							result.Id = idvalue;	

						if (jobject.GetValue(nameof(IQuerySearchResult.MatchCount), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is int matchcountvalue)
							result.MatchCount = matchcountvalue;

						if (jobject.GetValue(nameof(IQuerySearchResult.Id), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is string starwarstypevalue)
							if (Enum.TryParse(starwarstypevalue, true, out StarWarsTypes starWarsType))
								result.StarWarsType = starWarsType;

						return result;
					}),
			};

			// Assert

			Assert(expectedresult, actualresult);
		}

		#endregion

		#region Characters

		public static IEnumerable<object[]> CharactersMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Characters(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(CharactersMemberData))]
		[Trait(nameof(Controller.Characters), "")]
		public async void Characters(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange
						
			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new () 
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Characters)
						.AppendJoin(
							separator: string.Empty, 
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());
																										   
			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new ICharacter.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<ICharacter>(expectedresult, actualresult);
		}

		#endregion

		#region Factions

		public static IEnumerable<object[]> FactionsMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Factions(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(FactionsMemberData))]
		[Trait(nameof(Controller.Factions), "")]
		public async void Factions(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Factions)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IFaction.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IFaction>(expectedresult, actualresult);
		}

		#endregion

		#region Films

		public static IEnumerable<object[]> FilmsMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Films(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(FilmsMemberData))]
		[Trait(nameof(Controller.Films), "")]
		public async void Films(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Films)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IFilm.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IFilm>(expectedresult, actualresult);
		}

		#endregion

		#region Manufacturers

		public static IEnumerable<object[]> ManufacturersMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Manufacturers(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(ManufacturersMemberData))]
		[Trait(nameof(Controller.Manufacturers), "")]
		public async void Manufacturers(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Manufacturers)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IManufacturer.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IManufacturer>(expectedresult, actualresult);
		}

		#endregion

		#region Planets

		public static IEnumerable<object[]> PlanetsMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Planets(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(PlanetsMemberData))]
		[Trait(nameof(Controller.Planets), "")]
		public async void Planets(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Planets)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IPlanet.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IPlanet>(expectedresult, actualresult);
		}

		#endregion

		#region Species

		public static IEnumerable<object[]> SpeciesMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Species(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(SpeciesMemberData))]
		[Trait(nameof(Controller.Species), "")]
		public async void Species(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Species)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new ISpecie.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<ISpecie>(expectedresult, actualresult);
		}

		#endregion

		#region Starships

		public static IEnumerable<object[]> StarshipsMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Starships(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(StarshipsMemberData))]
		[Trait(nameof(Controller.Starships), "")]
		public async void Starships(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Starships)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IStarship.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IStarship>(expectedresult, actualresult);
		}

		#endregion

		#region Vehicles

		public static IEnumerable<object[]> VehiclesMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Vehicles(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(VehiclesMemberData))]
		[Trait(nameof(Controller.Vehicles), "")]
		public async void Vehicles(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Vehicles)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IVehicle.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IVehicle>(expectedresult, actualresult);
		}

		#endregion

		#region Weapons

		public static IEnumerable<object[]> WeaponsMemberData => RestControllerMemberData
			.Select(memberdata =>
			{
				return memberdata.Append(new Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>>(async (serviceprovider, query) =>
				{
					Controller controller = new(serviceprovider);

					if (query is IQuery.Default querydefault)
						return await controller.Weapons(querydefault);

					return null;

				})).ToArray();
			});

		[Theory]
		[MemberData(nameof(WeaponsMemberData))]
		[Trait(nameof(Controller.Weapons), "")]
		public async void Weapons(string apitype, IQuery query, Func<IServiceProvider, IQuery, Task<IQuery.IResult<object>?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Weapons)
						.AppendJoin(
							separator: string.Empty,
							values: query.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQuery.IResult<object>? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, query);
			IQuery.IResult<object> actualresult = new IQuery.IResult.Default<object>
			{
				Page = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Page), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Pages = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Pages), StringComparison.OrdinalIgnoreCase)?
					.ToObject<int?>(),
				Items = actualresultjobject.GetValue(nameof(IQuery.IResult<object>.Items), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(jtoken => new IWeapon.Default(1, JObject.FromObject(jtoken)).ToObject()),
			};

			// Assert

			Assert<IWeapon>(expectedresult, actualresult);
		}

		#endregion

		#region Meta

		public static IEnumerable<object[]> MetaMemberData => Utils.ApiTypes.AsEnumerable()
			.Select(apitype =>
			{
				return Enumerable.Empty<object>()
					.Append(apitype)
					.Append(new IQueryMeta.Default { })
					.Append(new Func<IServiceProvider, IQueryMeta, Task<IQueryMeta.IResult?>>(async (serviceprovider, query) =>
					{
						Controller controller = new(serviceprovider);

						if (query is IQueryMeta.Default querydefault)
							return await controller.Meta(querydefault);

						return null;

					})).ToArray();
			});

		[Theory]
		[MemberData(nameof(MetaMemberData))]
		[Trait(nameof(Controller.Meta), "")]
		public async void Meta(string apitype, IQueryMeta querymeta, Func<IServiceProvider, IQueryMeta, Task<IQueryMeta.IResult?>> expectedresultaction)
		{
			// Arrange

			Utils.ApiTypes.GetWebApplicationFactoryFields(
				apitype: apitype,
				httpclient: out HttpClient outhttpclient,
				serviceprovider: out IServiceProvider outserviceprovider);

			using IServiceScope servicescope = outserviceprovider.CreateScope();
			using HttpRequestMessage httprequestmessage = new()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(
					uriString: _StringBuilder.Clear()
						.Append(Routes.HttpsBaseAddress)
						.Append(Routes.Api_Rest_Meta)
						.AppendJoin(
							separator: string.Empty,
							values: querymeta.AsQueryData().Select((querydata, index) => string.Format("{0}{1}", index == 0 ? '?' : '&', querydata)))
						.ToString())
			};

			// Act

			using HttpResponseMessage httpresponsemessage = await outhttpclient.SendAsync(httprequestmessage);

			JObject actualresultjobject = JObject.Parse(await httpresponsemessage.Content.ReadAsStringAsync());

			IQueryMeta.IResult? expectedresult = await expectedresultaction.Invoke(servicescope.ServiceProvider, querymeta);
			IQueryMeta.IResult? actualresult = new IQueryMeta.IResult.Default(
				results: actualresultjobject
					.ToObject<JArray?>()?
					.Select(jtoken => JObject.FromObject(jtoken))
					.Select(jobject =>
					{
						IQueryMetaResult result = new IQueryMetaResult.Default { };

						if (jobject.GetValue(nameof(IQueryMetaResult.Id), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is int idvalue)
							result.Id = idvalue;

						if (jobject.GetValue(nameof(IQueryMetaResult.Id), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is string starwarstypevalue)
							if (Enum.TryParse(starwarstypevalue, true, out StarWarsTypes starWarsType))
								result.StarWarsType = starWarsType;

						return result;

					}) ?? Enumerable.Empty<IQueryMetaResult>());

			// Assert

			Assert(expectedresult, actualresult);
		}

		#endregion
	}
}
