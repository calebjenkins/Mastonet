﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Mastonet.Entities
{
    public class Conversation
    {
        /// <summary>
        /// The conversation ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Accounts in the conversation
        /// </summary>
        [JsonProperty("accounts")]
        public IEnumerable<Account> Accounts { get; set; } = Enumerable.Empty<Account>();

        /// <summary>
        /// Last status of the conversation
        /// </summary>
        [JsonProperty("last_status")]
        public Status? LastStatus { get; set; }

        /// <summary>
        /// If the converstation is unread
        /// </summary>
        [JsonProperty("unread")]
        public bool Unread { get; set; }
    }
}
