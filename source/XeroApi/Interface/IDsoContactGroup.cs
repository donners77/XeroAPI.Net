using System;

namespace XeroApi.Interface
{
    public interface IDsoContactGroup : IEndpointModelBase
    {
        Guid ContactGroupID { get; set; }
        string Name { get; set; }
        string Status { get; set; }
        IDsoContacts Contacts { get; set; }
    }
}