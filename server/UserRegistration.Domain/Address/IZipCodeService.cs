namespace UserRegistration.Domain.Address
{
	public interface IZipCodeService
	{
		string GetAddressByZipCode(string zipCode);
	}
}
