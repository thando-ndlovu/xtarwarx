
namespace System
{
	public static class TimeSpanExtensions
	{
		public static string ToMicrowaveFormat(this TimeSpan timeSpan, bool includeMilliseconds = false)
		{
			string time = string.Format(
				"{0}:{1}:{2}",
				timeSpan.Hours.ToString("00"),
				timeSpan.Minutes.ToString("00"),
				timeSpan.Seconds.ToString("00"));

			if (includeMilliseconds)
				time += string.Format(":{0}", timeSpan.Milliseconds.ToString("0000"));

			return time;
		}
	}
}
