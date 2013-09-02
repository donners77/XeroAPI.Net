namespace XeroApi.Interface
{
    public interface IDsoAddress : IEndpointModelBase
    {
        string AddressType { get; set; }
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        string City { get; set; }
        string Region { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
        string AttentionTo { get; set; }

        string ToString();
    }
}