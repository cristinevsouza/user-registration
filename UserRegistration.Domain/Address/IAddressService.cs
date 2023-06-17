
namespace UserRegistration.Domain.Address
{
	public interface IAddressService
	{
		string Add(AddressModel address);

		AddressModel GetById(int id);

		void Update(AddressModel address);
	}
}
