namespace UserRegistration.Domain.Adress
{
	public interface IZipCodeService
	{
		string GetAddressByZipCode(string zipCode);
	}
}
