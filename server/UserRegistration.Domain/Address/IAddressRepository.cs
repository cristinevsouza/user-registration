
namespace UserRegistration.Domain.Address
{
	public interface IAddressRepository
	{
		void AddUserAddress(AddressModel address, int userId);

		AddressModel? GetAddressByUserId(int userId);

		void UpdateUserAddress(AddressModel address, int userId);
	}
}
