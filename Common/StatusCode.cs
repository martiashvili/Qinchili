namespace Common
{
    public enum StatusCode
    {
        Fail = 0,
        Success = 1,
        ProductWithTheSameNameAlreadyExists = 2,
        ProductNotFound = 3,
        CustomerWithTheSamePhoneNumberAlreadyExists = 4,
        CustomerNotFound = 5,
        DeliveryAddressAlreadyExists = 6,
        DeliveryAddressNotFound = 7
    }
}
