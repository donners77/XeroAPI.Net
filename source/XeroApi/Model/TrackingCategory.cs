using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class TrackingCategory : EndpointModelBase, IDsoTrackingCategory
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public string Option { get; set; }

        public Guid TrackingCategoryID { get; set; }

        public IDsoOptions Options { get; set; }
    }
}