
namespace UserRegistration.Domain.Address
{
	public interface IAddressService
	{
		void AddUserAddress(AddressModel address, int userId);

		AddressModel GetAddressByUserId(int id);

		void UpdateUserAddress(AddressModel address, int userId);
	}
}
