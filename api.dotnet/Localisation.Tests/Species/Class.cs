using System.Collections.Generic;
using System.Text;

using Xunit.Abstractions;

namespace Localisation.Tests
{
	public partial class Species
	{
		public Species(ITestOutputHelper outputHelper)
		{
			_OutputHelper = outputHelper;

			_StringBuilder = new StringBuilder();
		}

		protected readonly StringBuilder _StringBuilder;
		protected readonly ITestOutputHelper _OutputHelper;

		public static IEnumerable<object[]> SpeciesMemberData => MemberData.CultureNamesMemberData;
	}
}
