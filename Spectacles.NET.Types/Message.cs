using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Spectacles.NET.Types
{
	/// <summary>
	///     Represents a message sent in a channel within Discord.
	/// </summary>
	public class Message
	{
		/// <summary>
		///     id of the message
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     id of the channel the message was sent in
		/// </summary>
		[JsonProperty("channel_id")]
		public string ChannelId { get; set; }

		/// <summary>
		///     id of the guild the message was sent in
		/// </summary>
		[JsonProperty("guild_id")]
		public string GuildId { get; set; }

		/// <summary>
		///     the author of this message
		/// </summary>
		[JsonProperty("author")]
		public User Author { get; set; }

		/// <summary>
		///     member properties for this message's author
		/// </summary>
		[JsonProperty("member")]
		public GuildMember Member { get; set; }

		/// <summary>
		///     contents of the message
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }

		/// <summary>
		///     when this message was sent
		/// </summary>
		[JsonProperty("timestamp")]
		public DateTime Timestamp { get; set; }

		/// <summary>
		///     when this message was edited (or null if never)
		/// </summary>
		[JsonProperty("edited_timestamp")]
		public DateTime? EditedTimestamp { get; set; }

		/// <summary>
		///     whether this was a TTS message
		/// </summary>
		[JsonProperty("tts")]
		public bool TTS { get; set; }

		/// <summary>
		///     whether this message mentions everyone
		/// </summary>
		[JsonProperty("mention_everyone")]
		public bool MentionEveryone { get; set; }

		/// <summary>
		///     users specifically mentioned in the message
		/// </summary>
		[JsonProperty("mentions")]
		public List<MentionUser> Mentions { get; set; }

		/// <summary>
		///     roles specifically mentioned in this message
		/// </summary>
		[JsonProperty("mention_roles")]
		public List<string> RoleMentions { get; set; }

		/// <summary>
		///     channels specifically mentioned in this message
		///     <warn>
		///         Not all channel mentions in a message will appear in mention_channels. Only textual channels that are visible
		///         to everyone in a lurkable guild will ever be included. Only crossposted messages (via Channel Following)
		///         currently include mention_channels at all. If no mentions in the message meet these requirements, this field
		///         will not be sent.
		///     </warn>
		/// </summary>
		[JsonProperty("mention_channels")]
		public List<ChannelMention> ChannelMentions { get; set; }

		/// <summary>
		///     any attached files
		/// </summary>
		[JsonProperty("attachments")]
		public List<Attachment> Attachments { get; set; }

		/// <summary>
		///     any embedded content
		/// </summary>
		[JsonProperty("embeds")]
		public List<Embed> Embeds { get; set; }

		/// <summary>
		///     reactions to the message
		/// </summary>
		[JsonProperty("reactions")]
		public List<Reaction> Reactions { get; set; }

		/// <summary>
		///     used for validating a message was sent
		/// </summary>
		[JsonProperty("nonce")]
		public string Nonce { get; set; }

		/// <summary>
		///     whether this message is pinned
		/// </summary>
		[JsonProperty("pinned")]
		public bool Pinned { get; set; }

		// ReSharper disable once CommentTypo
		/// <summary>
		///     if the message is generated by a webhook, this is the webhook's id
		/// </summary>
		[JsonProperty("webhook_id")]
		public string WebhookId { get; set; }

		/// <summary>
		///     <see cref="MessageType" />
		/// </summary>
		[JsonProperty("type")]
		public MessageType Type { get; set; }

		/// <summary>
		///     sent with Rich Presence-related chat embeds
		/// </summary>
		[JsonProperty("activity")]
		public MessageActivity Activity { get; set; }

		/// <summary>
		///     sent with Rich Presence-related chat embeds
		/// </summary>
		[JsonProperty("application")]
		public MessageApplication Application { get; set; }
	}
}
