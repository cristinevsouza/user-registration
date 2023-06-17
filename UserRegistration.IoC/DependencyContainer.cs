using UserRegistration.Application;
using UserRegistration.Domain.Registration;
using UserRegistration.Domain.Address;
using UserRegistration.Domain.User;
using UserRegistration.Infrastructure.Registration;
using UserRegistration.Infrastructure.Address;
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
			services.AddScoped<IAddressRepository, AddressRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IAddressService, AddressService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IZipCodeService, ApiZipCodeService>();
			services.AddScoped<IRegistrationRepository, RegistrationRepository>();
			services.AddScoped<IRegistrationService, RegistrationService>();
		}
	}
}
