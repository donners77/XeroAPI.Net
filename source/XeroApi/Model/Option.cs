using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class Option : ModelBase, IDsoOption
    {
        public Guid? TrackingOptionID { get; set; }

        public string Name { get; set; }
    }
}