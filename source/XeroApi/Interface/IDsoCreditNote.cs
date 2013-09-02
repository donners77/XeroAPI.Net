using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoCreditNote : IEndpointModelBase
    {
        [ItemId]
        Guid CreditNoteID { get; set; }

        [ItemNumber]
        string CreditNoteNumber { get; set; }

        [ItemUpdatedDate]
        DateTime? UpdatedDateUTC { get; set; }

        string Type { get; set; }
        string Reference { get; set; }
        bool? SentToContact { get; set; }
        decimal? AppliedAmount { get; set; }
        decimal RemainingCredit { get; set; }
        decimal? CurrencyRate { get; set; }
        IDsoContact Contact { get; set; }
        DateTime? Date { get; set; }
        DateTime? DueDate { get; set; }
        Guid? BrandingThemeID { get; set; }
        string Status { get; set; }
        ELineAmountType LineAmountTypes { get; set; }
        IDsoLineItems LineItems { get; set; }
        decimal? SubTotal { get; set; }
        decimal? TotalTax { get; set; }
        decimal? Total { get; set; }
        string CurrencyCode { get; set; }
        DateTime? FullyPaidOnDate { get; set; }
    }
}