using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class Payment : EndpointModelBase, IDsoPayment
    {
        [ItemId]
        public Guid? PaymentID { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Reference { get; set; }

        public decimal? CurrencyRate { get; set; }

        public string PaymentType { get; set; }

        public string Status { get; set; }

        [ItemUpdatedDate]
        public DateTime? UpdatedDateUTC { get; set; }

        public IDsoAccount Account { get; set; }

        public IDsoInvoice Invoice { get; set; }
    }
}