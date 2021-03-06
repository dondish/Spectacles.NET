using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	/// <summary>
	/// Represents an attachment in a message.
	/// </summary>
	public class Attachment
	{
		/// <summary>
		///     attachment id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     name of file attached
		/// </summary>
		[JsonProperty("filename")]
		public string FileName { get; set; }

		/// <summary>
		///     size of file in bytes
		/// </summary>
		[JsonProperty("size")]
		public int Size { get; set; }

		/// <summary>
		///     source url of file
		/// </summary>
		[JsonProperty("url")]
		public string URL { get; set; }

		/// <summary>
		///     a proxied url of file
		/// </summary>
		[JsonProperty("proxy_url")]
		public string ProxyURL { get; set; }

		/// <summary>
		///     height of file (if image)
		/// </summary>
		[JsonProperty("height")]
		public int? Height { get; set; }

		/// <summary>
		///     width of file (if image)
		/// </summary>
		[JsonProperty("width")]
		public int? Width { get; set; }
	}
}
