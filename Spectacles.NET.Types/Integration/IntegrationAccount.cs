using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	/// <summary>
	/// The information account for an integration.
	/// </summary>
	public class IntegrationAccount
	{
		/// <summary>
		///     integration account id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     integration account name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
