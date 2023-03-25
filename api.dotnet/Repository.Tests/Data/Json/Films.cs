using Domain.Models;

using Newtonsoft.Json.Linq;

using Repository.Data.Json.Utils;

using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;
using Xunit.Abstractions;

namespace Repository.Tests.Data.Json
{
	public class Films
	{
		public Films(ITestOutputHelper testOutputHelper)
		{
			TestOutputHelper = testOutputHelper;
		}

		private ITestOutputHelper TestOutputHelper { get; }

		public static IEnumerable<object[]> IsValidMemberData => FilmUtils.ReadManifestResources(FilmUtils.ManifestResourceNames)
			.Select(manifestresource => new object[]
			{
				manifestresource.Key,
				manifestresource.Value,
			});

		[Theory]
		[MemberData(nameof(IsValidMemberData))]
		[Trait(TraitValues.Json, TraitValues.Films)]
		public void IsValid(int id, string json)
		{
			// Arrange											

			IFilm? data = null;
			JObject jobject = JObject.Parse(json);

			// Act

			Exception? exception = Record.Exception(() => data = new IFilm.Default(id, jobject));

			TestOutputHelper.WriteLine(data?.ToString() ?? "null");

			// Assert

			Assert.Null(exception);
		}
	}
}
