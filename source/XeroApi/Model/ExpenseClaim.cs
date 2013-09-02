using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class ExpenseClaim : EndpointModelBase, IDsoExpenseClaim
    {
        [ItemId]
        public Guid ExpenseClaimID { get; set; }
        
        public string Status { get; set; }

        public DateTime Date { get; set; }

        public IDsoUser User { get; set; }
        
        public IDsoReceipts Receipts { get; set; }

        [ReadOnly]
        public DateTime CreatedDateUTC { get; set; }

        [ReadOnly]
        public DateTime UpdatedDateUTC { get; set; }

        [ReadOnly]
        public decimal SubTotal { get; set; }

        [ReadOnly]
        public decimal TotalTax { get; set; }

        [ReadOnly]
        public decimal Total { get; set; }
    }
}
