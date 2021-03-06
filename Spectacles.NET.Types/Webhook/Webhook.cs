using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	/// <summary>
	///     Webhooks are a low-effort way to post messages to channels in Discord. They do not require a bot user or
	///     authentication to use.
	/// </summary>
	public class Webhook
	{
		/// <summary>
		///     the id of the webhook
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		///     the guild id this webhook is for
		/// </summary>
		[JsonProperty("guild_id")]
		public long? GuildId { get; set; }

		/// <summary>
		///     the channel id this webhook is for
		/// </summary>
		[JsonProperty("channel_id")]
		public long ChannelId { get; set; }

		/// <summary>
		///     the user this webhook was created by (not returned when getting a webhook with its token)
		/// </summary>
		[JsonProperty("user")]
		public User User { get; set; }

		/// <summary>
		///     the default name of the webhook
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     the default avatar of the webhook
		/// </summary>
		[JsonProperty("avatar")]
		public string Avatar { get; set; }

		/// <summary>
		///     the secure token of the webhook
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
	}
}
