
namespace UserRegistration.Domain.Registration
{
    public interface IRegistrationService
    {
        void AddUserRegistration(RegistrationModel registration);

        RegistrationModel? GetUserRegistration(int userId);

        void UpdateUserRegistration(RegistrationModel registration);

        List<RegistrationModel> GetAllUserRegistrations();
	}
}
