using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	public class ActivityTimestamps
	{
		/// <summary>
		///     unix time (in milliseconds) of when the activity started
		/// </summary>
		[JsonProperty("start")]
		public long? Start { get; set; }

		/// <summary>
		///     unix time (in milliseconds) of when the activity ends
		/// </summary>
		[JsonProperty("end")]
		public long? End { get; set; }
	}
}
