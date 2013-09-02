using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoInvoice : IEndpointModelBase
    {
        [ItemId]
        Guid InvoiceID { get; set; }

        [ItemNumber]
        string InvoiceNumber { get; set; }

        [ItemUpdatedDate]
        DateTime? UpdatedDateUTC { get; set; }

        string Type { get; set; }
        string Reference { get; set; }

        [ReadOnly]
        IDsoPayments Payments { get; set; }

        [ReadOnly]
        IDsoCreditNotes CreditNotes { get; set; }

        [ReadOnly]
        decimal? AmountDue { get; set; }

        [ReadOnly]
        decimal? AmountPaid { get; set; }

        [ReadOnly]
        decimal? AmountCredited { get; set; }

        string Url { get; set; }

        [ReadOnly]
        string ExternalLinkProviderName { get; set; }

        [ReadOnly]
        bool? SentToContact { get; set; }

        decimal? CurrencyRate { get; set; }
        IDsoContact Contact { get; set; }
        DateTime? Date { get; set; }
        DateTime? DueDate { get; set; }
        Guid? BrandingThemeID { get; set; }
        string Status { get; set; }
        ELineAmountType LineAmountTypes { get; set; }
        IDsoLineItems LineItems { get; set; }
        decimal? SubTotal { get; set; }
        decimal? TotalDiscount { get; set; }
        decimal? TotalTax { get; set; }
        decimal? Total { get; set; }
        string CurrencyCode { get; set; }

        [ReadOnly]
        DateTime? FullyPaidOnDate { get; set; }
        string ToString();
    }
}