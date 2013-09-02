using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoJournalLine : IEndpointModelBase
    {
        Guid JournalLineID { get; set; }
        Guid AccountID { get; set; }
        string AccountCode { get; set; }
        string AccountType { get; set; }
        string AccountName { get; set; }
        string Description { get; set; }
        decimal NetAmount { get; set; }
        decimal GrossAmount { get; set; }
        decimal TaxAmount { get; set; }
        string TaxType { get; set; }
        string TaxName { get; set; }
        TrackingCategories TrackingCategories { get; set; }
    }
}