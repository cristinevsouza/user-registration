using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;
using UserRegistration.Domain.Address;
using UserRegistration.Domain.Registration;
using UserRegistration.Domain.User;

namespace UserRegistration.Presentation.Dtos
{
	public class RegistrationDto
	{
		public UserDto UserDto { get; set; }

		public AddressDto UserAddressDto { get; set; }

		public RegistrationDto(UserDto userDto, AddressDto userAddressDto)
		{
			UserDto = userDto;
			UserAddressDto = userAddressDto;
		}

		public RegistrationModel ToModel()
		{
			var user = new UserModel
			{
				Id = UserDto.Id,
				Cpf = UserDto.Cpf,
				FirstName = UserDto.FirstName,
				LastName = UserDto.LastName,
				DateOfBirth = UserDto.DateOfBirth,
				PhoneNumber = UserDto.PhoneNumber,
				Email = UserDto.Email,
			};
			var userAddress = new AddressModel
			{
				Id = UserAddressDto.Id,
				ZipCode = UserAddressDto.ZipCode,
				State = UserAddressDto.State,
				City = UserAddressDto.City,
				Neighborhood = UserAddressDto.Neighborhood,
				Street = UserAddressDto.Street,
				Number = UserAddressDto.Number,
				Complement = UserAddressDto.Complement,
				Reference = UserAddressDto.Reference
			};
			return new RegistrationModel(user, userAddress);			
		}
	}
}
