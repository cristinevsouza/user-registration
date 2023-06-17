
namespace UserRegistration.Domain.Registration
{
    public interface IRegistrationService
    {
        void Add(RegistrationModel registration);

        RegistrationModel Get(int userId, int adressId);

        void Update(RegistrationModel registration);
	}
}
