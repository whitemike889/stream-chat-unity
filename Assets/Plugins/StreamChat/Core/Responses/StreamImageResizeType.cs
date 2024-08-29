using StreamChat.Core.InternalDTO.Models;
using StreamChat.Core.LowLevelClient;

namespace StreamChat.Core.Responses
{
    public readonly struct StreamImageResizeType : System.IEquatable<StreamImageResizeType>,
        ILoadableFrom<ImageResizeType, StreamImageResizeType>, ISavableTo<ImageResizeType>
    {
        private readonly string _value;

        public StreamImageResizeType(string value)
        {
            _value = value ?? throw new System.ArgumentNullException(nameof(value));
        }

        // Predefined values
        public static readonly StreamImageResizeType Clip = new StreamImageResizeType("clip");
        public static readonly StreamImageResizeType Crop = new StreamImageResizeType("crop");
        public static readonly StreamImageResizeType Scale = new StreamImageResizeType("scale");
        public static readonly StreamImageResizeType Fill = new StreamImageResizeType("fill");

        public override string ToString() => _value;

        public bool Equals(StreamImageResizeType other) => _value == other._value;

        public override bool Equals(object obj) => obj is StreamImageResizeType other && Equals(other);

        public override int GetHashCode() => _value.GetHashCode();

        public static bool operator ==(StreamImageResizeType left, StreamImageResizeType right) => left.Equals(right);

        public static bool operator !=(StreamImageResizeType left, StreamImageResizeType right) => !left.Equals(right);

        public static implicit operator StreamImageResizeType(string value) => new StreamImageResizeType(value);

        public static implicit operator string(StreamImageResizeType type) => type._value;

        StreamImageResizeType ILoadableFrom<ImageResizeType, StreamImageResizeType>.LoadFromDto(ImageResizeType dto) => new StreamImageResizeType(dto.ToString());

        ImageResizeType ISavableTo<ImageResizeType>.SaveToDto() => new ImageResizeType(_value);
    }

}