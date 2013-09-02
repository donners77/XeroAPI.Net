using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class Contact : EndpointModelBase, IDsoContact
    {
        [ItemId]
        public Guid ContactID { get; set; }
        
        [ItemNumber]
        public string ContactNumber { get; set; }

        [ItemUpdatedDate]
        public DateTime? UpdatedDateUTC { get; set; }

        public string ContactStatus { get; set; }
        
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string EmailAddress { get; set; }
        
        public string SkypeUserName { get; set; }
        
        public string BankAccountDetails { get; set; }
        
        public string TaxNumber { get; set; }
        
        public string AccountsReceivableTaxType { get; set; }
        
        public string AccountsPayableTaxType { get; set; }
        
        public IDsoAddresses Addresses { get; set; }
        
        public IDsoPhones Phones { get; set; }
        
        public IDsoContactGroups ContactGroups { get; set; }
        
        [ReadOnly]
        public bool IsSupplier { get; set; }

        [ReadOnly]
        public bool IsCustomer { get; set; }
        
        public string DefaultCurrency { get;  set; }

        public override string ToString()
        {
            return string.Format("Contact:{0}", Name);
        }
    }
}