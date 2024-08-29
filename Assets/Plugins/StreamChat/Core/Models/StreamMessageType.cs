using System;
using StreamChat.Core.InternalDTO.Models;
using StreamChat.Core.LowLevelClient;

namespace StreamChat.Core.Models
{
    public readonly struct StreamMessageType : IEquatable<StreamMessageType>,
        ILoadableFrom<MessageType, StreamMessageType>, ISavableTo<MessageType>
    {
        public StreamMessageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static readonly StreamMessageType Regular = new StreamMessageType("regular");
        public static readonly StreamMessageType Ephemeral = new StreamMessageType("ephemeral");
        public static readonly StreamMessageType Error = new StreamMessageType("error");
        public static readonly StreamMessageType Reply = new StreamMessageType("reply");
        public static readonly StreamMessageType System = new StreamMessageType("system");
        public static readonly StreamMessageType Deleted = new StreamMessageType("deleted");

        public override string ToString() => _value;

        public bool Equals(StreamMessageType other) => _value == other._value;

        public override bool Equals(object obj) => obj is MessageType other && Equals(other);

        public override int GetHashCode() => _value.GetHashCode();

        public static bool operator ==(StreamMessageType left, StreamMessageType right) => left.Equals(right);

        public static bool operator !=(StreamMessageType left, StreamMessageType right) => !left.Equals(right);

        public static implicit operator StreamMessageType(string value) => new StreamMessageType(value);

        public static implicit operator string(StreamMessageType type) => type._value;

        StreamMessageType ILoadableFrom<MessageType, StreamMessageType>.LoadFromDto(MessageType dto) => new StreamMessageType(dto);

        MessageType ISavableTo<MessageType>.SaveToDto() => new MessageType(_value);

        private readonly string _value;
    }
}