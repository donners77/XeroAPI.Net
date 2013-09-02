using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class CreditNote : EndpointModelBase, IDsoCreditNote
    {
        [ItemId]
        public Guid CreditNoteID { get; set; }

        [ItemNumber]
        public string CreditNoteNumber { get; set; }

        [ItemUpdatedDate]
        public DateTime? UpdatedDateUTC { get; set; }

        public string Type { get; set; }

        public string Reference { get; set; }
        
        public bool? SentToContact { get; set; }

        public decimal? AppliedAmount { get; set; }
        
        public decimal RemainingCredit { get; set; }

        public decimal? CurrencyRate { get; set; }

        public IDsoContact Contact { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? DueDate { get; set; }

        public virtual Guid? BrandingThemeID { get; set; }

        public virtual string Status { get; set; }

        public ELineAmountType LineAmountTypes { get; set; }

        public virtual IDsoLineItems LineItems { get; set; }

        public virtual decimal? SubTotal { get; set; }

        public virtual decimal? TotalTax { get; set; }

        public virtual decimal? Total { get; set; }

        public virtual string CurrencyCode { get; set; }

        public DateTime? FullyPaidOnDate { get; set; }
    }
}
