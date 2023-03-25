using System.Collections.Generic;
using System.Linq;

namespace System.Drawing
{
	public static class KnownColorExtensions
	{
		public static IEnumerable<KnownColor> NonSystemColors(this KnownColor _)
			=> Enum.GetValues(typeof(KnownColor))
				.Cast<KnownColor>()
				.Where(knownColor =>
				{
					return 
					knownColor != KnownColor.ActiveBorder &&
					knownColor != KnownColor.ActiveCaption &&
					knownColor != KnownColor.ActiveCaptionText &&
					knownColor != KnownColor.AppWorkspace &&
					knownColor != KnownColor.Control &&
					knownColor != KnownColor.ControlDark &&
					knownColor != KnownColor.ControlDarkDark &&
					knownColor != KnownColor.ControlLight &&
					knownColor != KnownColor.ControlLightLight &&
					knownColor != KnownColor.ControlText &&
					knownColor != KnownColor.Desktop &&
					knownColor != KnownColor.GrayText &&
					knownColor != KnownColor.Highlight &&
					knownColor != KnownColor.HighlightText &&
					knownColor != KnownColor.HotTrack &&
					knownColor != KnownColor.InactiveBorder &&
					knownColor != KnownColor.InactiveCaption &&
					knownColor != KnownColor.InactiveCaptionText &&
					knownColor != KnownColor.Info &&
					knownColor != KnownColor.InfoText &&
					knownColor != KnownColor.Menu &&
					knownColor != KnownColor.MenuText &&
					knownColor != KnownColor.ScrollBar &&
					knownColor != KnownColor.Window &&
					knownColor != KnownColor.WindowFrame &&
					knownColor != KnownColor.WindowText &&
					knownColor != KnownColor.Transparent &&
					knownColor != KnownColor.ButtonFace &&
					knownColor != KnownColor.ButtonHighlight &&
					knownColor != KnownColor.ButtonShadow &&
					knownColor != KnownColor.GradientActiveCaption &&
					knownColor != KnownColor.GradientInactiveCaption &&
					knownColor != KnownColor.MenuBar &&
					knownColor != KnownColor.MenuHighlight;
				});
	}
}
