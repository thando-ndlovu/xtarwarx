using System.Text;

using Xunit.Abstractions;

namespace Domain.Tests.Models
{
	public partial class Specie
	{
		public Specie(ITestOutputHelper testoutputhelper)
		{
			_StringBuilder = new StringBuilder();
			TestOutputHelper = testoutputhelper;
		}

		protected readonly StringBuilder _StringBuilder;
		protected readonly ITestOutputHelper TestOutputHelper;
	}
}
