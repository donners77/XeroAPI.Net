using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoPayment : IEndpointModelBase
    {
        [ItemId]
        Guid? PaymentID { get; set; }

        DateTime Date { get; set; }
        decimal Amount { get; set; }
        string Reference { get; set; }
        decimal? CurrencyRate { get; set; }
        string PaymentType { get; set; }
        string Status { get; set; }

        [ItemUpdatedDate]
        DateTime? UpdatedDateUTC { get; set; }

        IDsoAccount Account { get; set; }
        IDsoInvoice Invoice { get; set; }



    }
}