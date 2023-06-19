namespace UserRegistration.Domain.Address
{
	public interface IZipCodeService
	{
		Task<ZipCodeModel> GetAddressByZipCodeAsync(string zipCode);
	}
}
