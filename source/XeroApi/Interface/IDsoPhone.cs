namespace XeroApi.Interface
{
    public interface IDsoPhone : IEndpointModelBase
    {
        string PhoneType { get; set; }
        string PhoneNumber { get; set; }
        string PhoneAreaCode { get; set; }
        string PhoneCountryCode { get; set; }

        string ToString();
    }
}