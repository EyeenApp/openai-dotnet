// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationErrorUpdate : ConversationUpdate
    {
        internal ConversationErrorUpdate(string eventId, InternalRealtimeServerEventErrorError error) : base(eventId, RealtimeConversation.ConversationUpdateKind.Error)
        {
            _error = error;
        }

        internal ConversationErrorUpdate(string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, InternalRealtimeServerEventErrorError error) : base(eventId, kind, additionalBinaryDataProperties)
        {
            _error = error;
        }
    }
}
