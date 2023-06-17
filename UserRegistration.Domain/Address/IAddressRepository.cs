
namespace UserRegistration.Domain.Address
{
	public interface IAddressRepository
	{
		string Add(AddressModel address);

		AddressModel GetByUserId(int userId);

		void Update(AddressModel address);
	}
}
