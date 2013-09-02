using XeroApi.Interface;

namespace XeroApi.Model
{
    public class LineItem : ModelBase, IDsoLineItem
    {
        private readonly TrackingCategories _tracking = new TrackingCategories();

        public string Description { get; set; }

        public decimal? UnitAmount { get; set; }

        public string TaxType { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? LineAmount { get; set; }

        public string AccountCode { get; set; }

        public IDsoTrackingCategories Tracking { get { return _tracking; } }

        public string ItemCode { get; set; }

        public decimal? Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("LineItem:{0}", Description ?? ItemCode);
        }
    }
}