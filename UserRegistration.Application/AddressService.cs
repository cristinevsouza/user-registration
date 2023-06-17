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

		public string Add(AddressModel address)
		{
			throw new NotImplementedException();
		}

		public AddressModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(AddressModel address)
		{
			throw new NotImplementedException();
		}
	}
}
