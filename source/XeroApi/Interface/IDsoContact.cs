using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoContact : IEndpointModelBase
    {
        [ItemId]
        Guid ContactID { get; set; }

        [ItemNumber]
        string ContactNumber { get; set; }

        [ItemUpdatedDate]
        DateTime? UpdatedDateUTC { get; set; }

        string ContactStatus { get; set; }
        string Name { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string SkypeUserName { get; set; }
        string BankAccountDetails { get; set; }
        string TaxNumber { get; set; }
        string AccountsReceivableTaxType { get; set; }
        string AccountsPayableTaxType { get; set; }
        IDsoAddresses Addresses { get; set; }
        IDsoPhones Phones { get; set; }
        IDsoContactGroups ContactGroups { get; set; }

        [ReadOnly]
        bool IsSupplier { get; set; }

        [ReadOnly]
        bool IsCustomer { get; set; }

        string DefaultCurrency { get; set; }

        string ToString();
    }
}