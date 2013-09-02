using System;

namespace XeroApi.Interface
{
    public interface IDsoTrackingCategory : IEndpointModelBase
    {
        string Name { get; set; }
        string Status { get; set; }
        string Option { get; set; }
        Guid TrackingCategoryID { get; set; }
        IDsoOptions Options { get; set; }
    }
}