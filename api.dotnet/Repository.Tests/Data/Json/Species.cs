﻿using Domain.Models;

using Newtonsoft.Json.Linq;

using Repository.Data.Json.Utils;

using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;
using Xunit.Abstractions;

namespace Repository.Tests.Data.Json
{
	public class Species
	{
		public Species(ITestOutputHelper testOutputHelper)
		{
			TestOutputHelper = testOutputHelper;
		}

		private ITestOutputHelper TestOutputHelper { get; }

		public static IEnumerable<object[]> IsValidMemberData => SpecieUtils.ReadManifestResources(SpecieUtils.ManifestResourceNames)
			.Select(manifestresource => new object[]
			{
				manifestresource.Key,
				manifestresource.Value,
			});

		[Theory]
		[MemberData(nameof(IsValidMemberData))]
		[Trait(TraitValues.Json, TraitValues.Species)]
		public void IsValid(int id, string json)
		{
			// Arrange											

			ISpecie? data = null;
			JObject jobject = JObject.Parse(json);

			// Act

			Exception? exception = Record.Exception(() => data = new ISpecie.Default(id, jobject));

			TestOutputHelper.WriteLine(data?.ToString() ?? "null");

			// Assert

			Assert.Null(exception);
		}
	}
}
