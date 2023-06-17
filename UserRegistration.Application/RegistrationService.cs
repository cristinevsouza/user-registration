
using UserRegistration.Domain.Address;
using UserRegistration.Domain.Registration;
using UserRegistration.Domain.User;

namespace UserRegistration.Application
{
	public class RegistrationService : IRegistrationService
	{
		private readonly IUserRepository _userRepository;
		private readonly IAddressRepository _addressRepository;

		public RegistrationService(IUserRepository userRepository, IAddressRepository addressRepository) 
		{
			_userRepository = userRepository;
			_addressRepository = addressRepository;
		}

		public void Add(RegistrationModel registration)
		{
			var id = _userRepository.Add(registration.User);

			//if (id > 0) { _addressRepository.Add(registration.UserAdress); }
		}

		public RegistrationModel Get(int userId, int adressId)
		{
			throw new NotImplementedException();
		}

		public void Update(RegistrationModel registration)
		{
			throw new NotImplementedException();
		}
	}
}
