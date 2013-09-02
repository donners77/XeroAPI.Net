using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoUser : IEndpointModelBase
    {
        [ItemId]
        Guid? UserID { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }

        [ReadOnly]
        DateTime UpdatedDateUTC { get; set; }

        [ReadOnly]
        bool IsSubscriber { get; set; }

        [ReadOnly]
        string OrganisationRole { get; set; }

        string FullName { get; }
    }
}