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
	public class Weapons
	{
		public Weapons(ITestOutputHelper testOutputHelper)
		{
			TestOutputHelper = testOutputHelper;
		}

		private ITestOutputHelper TestOutputHelper { get; }

		public static IEnumerable<object[]> IsValidMemberData => WeaponUtils.ReadManifestResources(WeaponUtils.ManifestResourceNames)
			.Select(manifestresource => new object[]
			{
				manifestresource.Key,
				manifestresource.Value,
			});

		[Theory(Skip = "No Data")]
		[MemberData(nameof(IsValidMemberData))]
		[Trait(TraitValues.Json, TraitValues.Weapons)]
		public void IsValid(int id, string json)
		{
			// Arrange											

			IWeapon? data = null;
			JObject jobject = JObject.Parse(json);

			// Act

			Exception? exception = Record.Exception(() => data = new IWeapon.Default(id, jobject));

			TestOutputHelper.WriteLine(data?.ToString() ?? "null");

			// Assert

			Assert.Null(exception);
		}
	}
}
