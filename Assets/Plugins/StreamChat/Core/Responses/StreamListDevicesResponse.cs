using StreamChat.Core.Helpers;
using StreamChat.Core.InternalDTO.Responses;
using StreamChat.Core.LowLevelClient;
using StreamChat.Core.LowLevelClient.Models;
using StreamChat.Core.LowLevelClient.Responses;

namespace StreamChat.Core.Responses
{
    public partial class StreamListDevicesResponse : ResponseObjectBase, ILoadableFrom<ListDevicesResponseInternalDTO, StreamListDevicesResponse>
    {
        /// <summary>
        /// List of devices
        /// </summary>
        public System.Collections.Generic.List<Device> Devices { get; set; }

        /// <summary>
        /// Duration of the request in human-readable format
        /// </summary>
        public string Duration { get; set; }

        StreamListDevicesResponse ILoadableFrom<ListDevicesResponseInternalDTO, StreamListDevicesResponse>.LoadFromDto(ListDevicesResponseInternalDTO dto)
        {
            Devices = Devices.TryLoadFromDtoCollection(dto.Devices);
            Duration = dto.Duration;
            AdditionalProperties = dto.AdditionalProperties;

            return this;
        }
    }
}