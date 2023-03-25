using System.Collections.Generic;

namespace GraphQL.Server.Ui.Playground
{
	public class GraphQLPlaygroundSettings
	{
		public class EditorSettings
		{
			public static class Keys
			{
				public const string CursorShape = "editor.cursorShape";
				public const string FontFamily = "editor.fontFamily";
				public const string FontSize = "editor.fontSize";
				public const string ReuseHeaders = "editor.reuseHeaders";
				public const string Theme = "editor.theme";
			}
			public static class Options
			{
				public static class CursorShape
				{
					public const string Line = "line";
					public const string Block = "block";
					public const string Underline = "underline";
				}
				public static class Theme
				{
					public const string Dark = "dark";
					public const string Light = "light";
				}
			}

			public string? CursorShape { get; set; }
			public string? FontFamily { get; set; }
			public int? FontSize { get; set; }
			public bool? ReuseHeaders { get; set; }
			public string? Theme { get; set; }

			public IDictionary<string, object> AsDictionary()
			{
				IDictionary<string, object> dictionary = new Dictionary<string, object>();

				if (!string.IsNullOrEmpty(CursorShape))
					dictionary.Add(Keys.CursorShape, CursorShape);

				if (!string.IsNullOrEmpty(FontFamily))
					dictionary.Add(Keys.CursorShape, FontFamily);

				if (FontSize.HasValue)
					dictionary.Add(Keys.FontSize, FontSize.Value);

				if (ReuseHeaders.HasValue)
					dictionary.Add(Keys.ReuseHeaders, ReuseHeaders.Value);

				if (!string.IsNullOrEmpty(Theme))
					dictionary.Add(Keys.Theme, Theme);

				return dictionary;
			}

			public static readonly EditorSettings Default = new()
			{
				CursorShape = Options.CursorShape.Line,
				FontFamily = "'Source Code Pro', 'Consolas', 'Inconsolata', 'Droid Sans Mono', 'Monaco', monospace",
				FontSize = 14,
				ReuseHeaders = true,
				Theme = Options.Theme.Dark,
			};
		}
		public class GeneralSettings
		{
			public static class Keys
			{
				public const string BetaUpdates = "general.betaUpdates";
			}

			public bool? BetaUpdates { get; set; }

			public IDictionary<string, object> AsDictionary()
			{
				IDictionary<string, object> dictionary = new Dictionary<string, object>();

				if (BetaUpdates.HasValue)
					dictionary.Add(Keys.BetaUpdates, BetaUpdates.Value);

				return dictionary;
			}

			public static readonly GeneralSettings Default = new()
			{
				BetaUpdates = false,
			};
		}
		public class PrettierSettings
		{
			public static class Keys
			{
				public const string PrintWidth = "prettier.printWidth";
				public const string TabWidth = "prettier.tabWidth";
				public const string UseTabs = "prettier.useTabs";
			}

			public int? PrintWidth { get; set; }
			public int? TabWidth { get; set; }
			public bool? UseTabs { get; set; }

			public IDictionary<string, object> AsDictionary()
			{
				IDictionary<string, object> dictionary = new Dictionary<string, object>();

				if (PrintWidth.HasValue)
					dictionary.Add(Keys.PrintWidth, PrintWidth.Value);

				if (TabWidth.HasValue)
					dictionary.Add(Keys.TabWidth, TabWidth.Value);

				if (UseTabs.HasValue)
					dictionary.Add(Keys.UseTabs, UseTabs.Value);

				return dictionary;
			}

			public static readonly PrettierSettings Default = new()
			{
				PrintWidth = 80,
				TabWidth = 2,
				UseTabs = false,
			};
		}
		public class RequestSettings
		{
			public static class Keys
			{
				public const string Credentials = "request.credentials";
			}
			public static class Options
			{
				public const string Omit = "omit";
				public const string Include = "include";
				public const string SameOrigin = "same-origin";
			}

			public string? Credentials { get; set; }

			public IDictionary<string, object> AsDictionary()
			{
				IDictionary<string, object> dictionary = new Dictionary<string, object>();

				if (!string.IsNullOrEmpty(Credentials))
					dictionary.Add(Keys.Credentials, Credentials);

				return dictionary;
			}

			public static readonly RequestSettings Default = new()
			{
				Credentials = Options.Omit,
			};
		}
		public class SchemaSettings
		{
			public static class Keys
			{
				public const string DisableComments = "schema.disableComments";
			}

			public class PollingSettings
			{
				public static class Keys
				{
					public const string Enable = "schema.polling.enable";
					public const string EndpointFilter = "schema.polling.endpointFilter";
					public const string Interval = "schema.polling.interval";
				}

				public bool? Enable { get; set; }
				public string? EndpointFilter { get; set; }
				public int? Interval { get; set; }

				public IDictionary<string, object> AsDictionary()
				{
					IDictionary<string, object> dictionary = new Dictionary<string, object>();

					if (Enable.HasValue)
						dictionary.Add(Keys.Enable, Enable.Value);

					if (!string.IsNullOrEmpty(EndpointFilter))
						dictionary.Add(Keys.EndpointFilter, EndpointFilter);

					if (Interval.HasValue)
						dictionary.Add(Keys.Interval, Interval.Value);

					return dictionary;
				}

				public static readonly PollingSettings Default = new()
				{
					Enable = true,
					EndpointFilter = "*localhost*",
					Interval = 2000,
				};
			}

			public bool? DisableComments { get; set; }
			public PollingSettings? Polling { get; set; }

			public IDictionary<string, object> AsDictionary()
			{
				IDictionary<string, object> dictionary = new Dictionary<string, object>();

				if (DisableComments.HasValue)
					dictionary.Add(Keys.DisableComments, DisableComments.Value);

				if (Polling != null)
					foreach (KeyValuePair<string, object> pollingpair in Polling.AsDictionary())
						dictionary.TryAdd(pollingpair.Key, pollingpair.Value);

				return dictionary;
			}

			public static readonly SchemaSettings Default = new()
			{
				DisableComments = false,
				Polling = PollingSettings.Default,
			};
		}
		public class TracingSettings
		{
			public static class Keys
			{
				public const string HideTracingResponse = "tracing.hideTracingResponse";
				public const string TracingSupported = "tracing.tracingSupported";
			}

			public bool? HideTracingResponse { get; set; }
			public bool? TracingSupported { get; set; }

			public IDictionary<string, object> AsDictionary()
			{
				IDictionary<string, object> dictionary = new Dictionary<string, object>();

				if (HideTracingResponse.HasValue)
					dictionary.Add(Keys.HideTracingResponse, HideTracingResponse.Value);

				if (TracingSupported.HasValue)
					dictionary.Add(Keys.TracingSupported, TracingSupported.Value);

				return dictionary;
			}

			public static readonly TracingSettings Default = new()
			{
				HideTracingResponse = true,
				TracingSupported = true,
			};
		}

		public EditorSettings? Editor { get; set; }
		public GeneralSettings? General { get; set; }
		public PrettierSettings? Prettier { get; set; }
		public RequestSettings? Request { get; set; }
		public SchemaSettings? Schema { get; set; }
		public TracingSettings? Tracing { get; set; }

		public IDictionary<string, object> AsDictionary()
		{
			IDictionary<string, object> dictionary = new Dictionary<string, object>();

			if (Editor != null)
				foreach (KeyValuePair<string, object> editorpair in Editor.AsDictionary())
					dictionary.TryAdd(editorpair.Key, editorpair.Value);

			if (General != null)
				foreach (KeyValuePair<string, object> generalpair in General.AsDictionary())
					dictionary.TryAdd(generalpair.Key, generalpair.Value);

			if (Prettier != null)
				foreach (KeyValuePair<string, object> prettierpair in Prettier.AsDictionary())
					dictionary.TryAdd(prettierpair.Key, prettierpair.Value);

			if (Request != null)
				foreach (KeyValuePair<string, object> requestpair in Request.AsDictionary())
					dictionary.TryAdd(requestpair.Key, requestpair.Value);

			if (Schema != null)
				foreach (KeyValuePair<string, object> schemapair in Schema.AsDictionary())
					dictionary.TryAdd(schemapair.Key, schemapair.Value);

			if (Tracing != null)
				foreach (KeyValuePair<string, object> tracingpair in Tracing.AsDictionary())
					dictionary.TryAdd(tracingpair.Key, tracingpair.Value);

			return dictionary;
		}
		public static readonly GraphQLPlaygroundSettings Default = new()
		{
			Editor = EditorSettings.Default,
			General = GeneralSettings.Default,
			Prettier = PrettierSettings.Default,
			Request = RequestSettings.Default,
			Schema = SchemaSettings.Default,
			Tracing = TracingSettings.Default,
		};
	}
}
