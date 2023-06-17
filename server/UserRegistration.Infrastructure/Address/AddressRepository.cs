using Microsoft.EntityFrameworkCore;
using System.Net;
using UserRegistration.Domain.Address;
using UserRegistration.Domain.User;
using UserRegistration.Infrastructure.Database;

namespace UserRegistration.Infrastructure.Address
{
	public class AddressRepository : IAddressRepository
	{
		private readonly DataContext _context;
		public AddressRepository(DataContext context)
		{
			_context = context;
		}

		public void AddUserAddress(AddressModel address, int userId)
		{
			var entity = new AddressEntity
			{
				ZipCode = address.ZipCode,
				State = address.State,
				City = address.City,
				Neighborhood = address.Neighborhood,
				Street = address.Street,
				Number = address.Number,
				Complement = address.Complement,
				Reference = address.Reference,
				UserId = userId
			};
			_context.Addresses.Add(entity);
			_context.SaveChanges();
		}

		public AddressModel? GetAddressByUserId(int userId)
		{
			var entity = _context.Addresses.FirstOrDefault(x => x.UserId == userId);

			if (entity == null) return null;

			return new AddressModel
			{
				ZipCode = entity.ZipCode,
				State = entity.State,
				City = entity.City,
				Neighborhood = entity.Neighborhood,
				Street = entity.Street,
				Number = entity.Number,
				Complement = entity.Complement,
				Reference = entity.Reference				
			};
		}

		public void UpdateUserAddress(AddressModel address, int userId)
		{
			var addressEntity = _context.Addresses.First(x => x.UserId == userId);

			addressEntity.ZipCode = address.ZipCode;
			addressEntity.State = address.State;
			addressEntity.City = address.City;
			addressEntity.Neighborhood = address.Neighborhood;
			addressEntity.Street = address.Street;
			addressEntity.Number = address.Number;
			addressEntity.Complement = address.Complement;
			addressEntity.Reference = address.Reference;
			
			_context.SaveChanges();
		}
	}
}