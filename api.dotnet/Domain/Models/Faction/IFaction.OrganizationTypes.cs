using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IFaction
	{
		public static class OrganizationTypeTypes
		{
			public const string Authoritarian = "Authoritarian";
			public const string BountyHunters = "BountyHunters";
			public const string Confederation = "Confederation";
			public const string Cult = "Cult";
			public const string DemocraticUnion = "DemocraticUnion";
			public const string Empire = "Empire";
			public const string Humanocentrism = "Humanocentrism";
			public const string Hunters = "Hunters";
			public const string Mercenaries = "Mercenaries";
			public const string Millitant = "Millitant";
			public const string MillitaryUnit = "MillitaryUnit";
			public const string Political = "Political";
			public const string QuasiReligion = "QuasiReligion";
			public const string RebelCell = "RebelCell";
			public const string RepublicRebelCell = "RepublicRebelCell";
			public const string Soldiers = "Soldiers";
			public const string SplinterMillitaryGroup = "SplinterMillitaryGroup";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Authoritarian)
					.Append(BountyHunters)
					.Append(Confederation)
					.Append(Cult)
					.Append(DemocraticUnion)
					.Append(Empire)
					.Append(Humanocentrism)
					.Append(Hunters)
					.Append(Mercenaries)
					.Append(Millitant)
					.Append(MillitaryUnit)
					.Append(Political)
					.Append(QuasiReligion)
					.Append(RebelCell)
					.Append(RepublicRebelCell)
					.Append(Soldiers)
					.Append(SplinterMillitaryGroup);
			}
		}
	}
}
