namespace StreamChat.Core.LowLevelClient
{
    /// <summary>
    /// <inheritdoc cref="IEnumeratedStruct"/>
    /// </summary>
    public interface IEnumeratedStruct<out TType> : IEnumeratedStruct
        where TType : struct
    {
        TType Parse(string value);
    }
    
    /// <summary>
    /// Struct that is used to represent enumerated values
    /// </summary>
    public interface IEnumeratedStruct
    {
        string Value { get; }
    }
}