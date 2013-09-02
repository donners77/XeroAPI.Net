using System;

namespace XeroApi.Interface
{
    public interface IDsoOption : IEndpointModelBase
    {
        Guid? TrackingOptionID { get; set; }
        string Name { get; set; }
    }
}