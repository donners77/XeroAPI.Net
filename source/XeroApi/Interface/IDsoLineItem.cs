namespace XeroApi.Interface
{
    public interface IDsoLineItem : IEndpointModelBase
    {
        string Description { get; set; }
        decimal? UnitAmount { get; set; }
        string TaxType { get; set; }
        decimal? TaxAmount { get; set; }
        decimal? LineAmount { get; set; }
        string AccountCode { get; set; }
        IDsoTrackingCategories Tracking { get; }
        string ItemCode { get; set; }
        decimal? Quantity { get; set; }


        string ToString();
    }
}