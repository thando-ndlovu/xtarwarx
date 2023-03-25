using System.Collections.Generic;
using System.Text;

using Xunit.Abstractions;

namespace Localisation.Tests
{
	public partial class Vehicles
	{
		public Vehicles(ITestOutputHelper outputHelper)
		{
			_OutputHelper = outputHelper;

			_StringBuilder = new StringBuilder();
		}

		protected readonly StringBuilder _StringBuilder;
		protected readonly ITestOutputHelper _OutputHelper;

		public static IEnumerable<object[]> VehiclesMemberData => MemberData.CultureNamesMemberData;
	}
}
