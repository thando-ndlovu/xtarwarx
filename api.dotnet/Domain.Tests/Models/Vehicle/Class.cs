using System.Text;

using Xunit.Abstractions;

namespace Domain.Tests.Models
{
	public partial class Vehicle
	{
		public Vehicle(ITestOutputHelper testoutputhelper)
		{
			_StringBuilder = new StringBuilder();
			TestOutputHelper = testoutputhelper;
		}

		protected readonly StringBuilder _StringBuilder;
		protected readonly ITestOutputHelper TestOutputHelper;
	}
}
