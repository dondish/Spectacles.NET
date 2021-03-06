using System.Collections.Generic;
using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	/// <summary>
	/// Represents a member of a guild on Discord.
	/// </summary>
	public class GuildMember
	{
		/// <summary>
		///     the user this guild member represents
		/// </summary>
		[JsonProperty("user")]
		public User User { get; set; }

		/// <summary>
		///     this users guild nickname (if one is set)
		/// </summary>
		[JsonProperty("nick")]
		public string Nickname { get; set; }

		/// <summary>
		///     array of role object ids
		/// </summary>
		[JsonProperty("roles")]
		public List<string> Roles { get; set; }

		/// <summary>
		///     when the user joined the guild
		/// </summary>
		[JsonProperty("joined_at")]
		public string JoinedAt { get; set; }

		/// <summary>
		/// The time of when the member used their Nitro boost on the guild, if it was used
		/// </summary>
		[JsonProperty("premium_since")]
		public string PremiumSince { get; set; }

		/// <summary>
		///     whether the user is deafened
		/// </summary>
		[JsonProperty("deaf")]
		public bool Deaf { get; set; }

		/// <summary>
		///     whether the user is muted
		/// </summary>
		[JsonProperty("mute")]
		public bool Mute { get; set; }
	}
}
