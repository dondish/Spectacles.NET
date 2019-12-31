using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	public class ActivityAssets
	{
		/// <summary>
		///     the id for a large asset of the activity, usually a snowflake
		/// </summary>
		[JsonProperty("large_image")]
		public string LargeImage { get; set; }

		/// <summary>
		///     text displayed when hovering over the large image of the activity
		/// </summary>
		[JsonProperty("large_text")]
		public string LargeText { get; set; }

		/// <summary>
		///     the id for a small asset of the activity, usually a snowflake
		/// </summary>
		[JsonProperty("small_image")]
		public string SmallImage { get; set; }

		/// <summary>
		///     text displayed when hovering over the small image of the activity
		/// </summary>
		[JsonProperty("small_text")]
		public string SmallText { get; set; }
	}
}
