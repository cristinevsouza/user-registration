
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Net;
using UserRegistration.Domain.Address;
using UserRegistration.Domain.Registration;
using UserRegistration.Domain.User;

namespace UserRegistration.Application
{
	public class RegistrationService : IRegistrationService
	{
		private readonly IUserService _userService;
		private readonly IAddressService _addressService;
		private readonly string _ageValidationMessage;
		private readonly string _stateValidationMessage;

		public RegistrationService(
			IUserService userService,
			IAddressService addressService, 
			IConfiguration configuration) 
		{
			_userService = userService;
			_addressService = addressService;
			_ageValidationMessage = configuration.GetSection("Messages")["AgeValidation"].ToString();
			_stateValidationMessage = configuration.GetSection("Messages")["StateValidation"].ToString();
		}

		public void AddUserRegistration(RegistrationModel registration)
		{
			RegistrationValidation(registration);

			var id = _userService.AddUser(registration.User);
			_addressService.AddUserAddress(registration.UserAddress, id);
		}

		public RegistrationModel? GetUserRegistration(int userId)
		{
			var user = _userService.GetUserById(userId);

			if (user != null)
			{
				var address = _addressService.GetAddressByUserId(userId);
				return new RegistrationModel(user, address);
			}

			return null;
		}

		public void UpdateUserRegistration(RegistrationModel registration)
		{
			RegistrationValidation(registration);

			_userService.UpdateUser(registration.User);
			_addressService.UpdateUserAddress(registration.UserAddress, registration.User.Id);
		}

		public List<RegistrationModel> GetAllUserRegistrations()
		{
			var users = _userService.GetAllUsers();
			
			var registrations = new List<RegistrationModel>();

			foreach (var user in users)
			{
				var address = _addressService.GetAddressByUserId(user.Id);
				registrations.Add(new RegistrationModel(user, address));
			}

			return registrations;
		}

		private void RegistrationValidation(RegistrationModel registration)
		{
			if (!registration.User.IsAdult())
			{
				throw new ValidationException(_ageValidationMessage);
			}

			if (!registration.UserAddress.IsAmazonasState())
			{
				throw new ValidationException(_stateValidationMessage);
			}
		}
	}
}
