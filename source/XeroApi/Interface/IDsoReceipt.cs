using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoReceipt : IEndpointModelBase
    {
        [ItemId]
        Guid ReceiptID { get; set; }

        [ReadOnly]
        int? ReceiptNumber { get; set; }

        string Status { get; set; }
        string Url { get; set; }

        [ReadOnly]
        string ExternalLinkProviderName { get; set; }

        IDsoUser User { get; set; }
        IDsoContact Contact { get; set; }
        DateTime? Date { get; set; }

        [ReadOnly]
        DateTime? CreatedDateUTC { get; set; }

        [ReadOnly]
        DateTime? UpdatedDateUTC { get; set; }

        string Reference { get; set; }
        ELineAmountType LineAmountTypes { get; set; }
        IDsoLineItems LineItems { get; set; }

        [ReadOnly]
        decimal? SubTotal { get; set; }

        [ReadOnly]
        decimal? TotalTax { get; set; }

        [ReadOnly]
        decimal? Total { get; set; }

        [ReadOnly]
        bool HasAttachments { get; set; }
    }
}