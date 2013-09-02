using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoJournal : IEndpointModelBase
    {
        [ItemId]
        Guid JournalID { get; set; }

        DateTime JournalDate { get; set; }
        long JournalNumber { get; set; }

        [ItemUpdatedDate]
        DateTime CreatedDateUTC { get; set; }

        string Reference { get; set; }
        JournalLines JournalLines { get; set; }

        string ToString();
    }
}