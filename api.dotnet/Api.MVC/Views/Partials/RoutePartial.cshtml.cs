using System;

namespace Api.MVC.Views.Partials
{
	public class RoutePartial
	{
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? ImgSrc { get; set; }
		public string? Href { get; set; }
		public Uri? External { get; set; }
		public bool WithShadow { get; set; } = true;
	}
}
