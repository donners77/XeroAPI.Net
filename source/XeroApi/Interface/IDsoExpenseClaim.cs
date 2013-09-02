using System;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IDsoExpenseClaim : IEndpointModelBase
    {
        [ItemId]
        Guid ExpenseClaimID { get; set; }

        string Status { get; set; }
        DateTime Date { get; set; }
        IDsoUser User { get; set; }
        IDsoReceipts Receipts { get; set; }

        [ReadOnly]
        DateTime CreatedDateUTC { get; set; }

        [ReadOnly]
        DateTime UpdatedDateUTC { get; set; }

        [ReadOnly]
        decimal SubTotal { get; set; }

        [ReadOnly]
        decimal TotalTax { get; set; }

        [ReadOnly]
        decimal Total { get; set; }
    }
}