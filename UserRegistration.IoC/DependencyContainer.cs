using UserRegistration.Application;
using UserRegistration.Domain.Registration;
using UserRegistration.Domain.Adress;
using UserRegistration.Domain.User;
using UserRegistration.Infrastructure.Registration;
using UserRegistration.Infrastructure.Adress;
using UserRegistration.Infrastructure.Network;
using UserRegistration.Infrastructure.User;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UserRegistration.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IAdressRepository, AdressRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IAdressService, AdressService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IZipCodeService, ApiZipCodeService>();
			services.AddScoped<IRegistrationRepository, RegistrationRepository>();
			services.AddScoped<IRegistrationService, RegistrationService>();
		}
	}
}
