using UserRegistration.Domain.User;
using UserRegistration.Domain.Adress;

namespace UserRegistration.Domain.Registration
{
	public class RegistrationModel
	{
		public UserModel User { get; set; }

        public AdressModel UserAdress { get; set; }
	}
}
