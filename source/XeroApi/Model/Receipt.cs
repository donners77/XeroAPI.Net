﻿using System;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public class Receipt : EndpointModelBase, IAttachmentParent, IDsoReceipt
    {
        [ItemId]
        public Guid ReceiptID { get; set; }

        [ReadOnly]
        public int? ReceiptNumber { get; set; }

        public string Status { get; set; }
        
        public string Url { get; set; }

        [ReadOnly]
        public string ExternalLinkProviderName { get; set; }
        
        public IDsoUser User { get; set; }
        
        public IDsoContact Contact { get; set; }
        
        public DateTime? Date { get; set; }

        [ReadOnly]
        public DateTime? CreatedDateUTC { get; set; }

        [ReadOnly]
        public DateTime? UpdatedDateUTC { get; set; }
        
        public string Reference { get; set; }
        
        public ELineAmountType LineAmountTypes { get; set; }

        public IDsoLineItems LineItems { get; set; }

        [ReadOnly]
        public decimal? SubTotal { get; set; }

        [ReadOnly]
        public decimal? TotalTax { get; set; }

        [ReadOnly]
        public decimal? Total { get; set; }

        [ReadOnly]
        public bool HasAttachments { get; set; }
    }
}
