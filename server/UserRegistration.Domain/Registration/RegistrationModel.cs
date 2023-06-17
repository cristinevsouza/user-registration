using UserRegistration.Domain.User;
using UserRegistration.Domain.Address;

namespace UserRegistration.Domain.Registration
{
	public class RegistrationModel
	{
		public UserModel User { get; set; }

        public AddressModel UserAddress { get; set; }

        public RegistrationModel(UserModel user, AddressModel userAddress)
        {
            User = user;
            UserAddress = userAddress;
        }
    }
}
