using UserRegistration.Domain.Address;

namespace UserRegistration.Application
{
	public class AddressService : IAddressService
	{
		private readonly IAddressRepository _addressRepository;

		public AddressService(IAddressRepository addressRepository) 
		{
			_addressRepository = addressRepository;
		}

		public void AddUserAddress(AddressModel address, int userId)
		{
			_addressRepository.AddUserAddress(address, userId);
		}

		public AddressModel GetAddressByUserId(int id)
		{
			var userAddress = _addressRepository.GetAddressByUserId(id);

			if (userAddress == null)
			{
				throw new InvalidOperationException("");
			}
			return userAddress.Value;
		}

		public void UpdateUserAddress(AddressModel address, int userId)
		{
			_addressRepository.UpdateUserAddress(address, userId);
		}
	}
}
