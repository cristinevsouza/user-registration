
namespace UserRegistration.Domain.Registration
{
    public interface IRegistrationRepository
    {
        string Add(RegistrationModel registration);

        RegistrationModel Get(int userId, int adressId);
	}
}
