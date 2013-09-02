using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoAccount : IEndpointModelBase
    {
        [ItemId]
        Guid AccountID { get; set; }

        string Code { get; set; }
        string Name { get; set; }
        string Status { get; set; }
        string Type { get; set; }
        string TaxType { get; set; }
        string Description { get; set; }
        string Class { get; set; }
        string SystemAccount { get; set; }
        bool? EnablePaymentsToAccount { get; set; }
        string BankAccountNumber { get; set; }
        string CurrencyCode { get; set; }
        string ReportingCode { get; set; }
        string ReportingCodeName { get; set; }
        bool ShowInExpenseClaims { get; set; }

        string ToString();
    }
}