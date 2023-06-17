using Microsoft.EntityFrameworkCore;
using UserRegistration.Domain.User;
using UserRegistration.Infrastructure.Database;

namespace UserRegistration.Infrastructure.User
{
	public class UserRepository : IUserRepository
	{
		private readonly DataContext _context;

		public UserRepository(DataContext context)
		{
			_context = context;
		}

		public int AddUser(UserModel user)
		{
			var entity = new UserEntity
			{
				Cpf = user.Cpf,
				FirstName = user.FirstName,
				LastName = user.LastName,
				DateOfBirth = user.DateOfBirth,
				Email = user.Email,
				PhoneNumber = user.PhoneNumber
			};
			_context.Users.Add(entity);
			_context.SaveChanges();

			return entity.Id;
		}

		public UserModel? GetUserById(int id)
		{
			var entity = _context.Users.FirstOrDefault(x => x.Id == id);

			if (entity == null) return null;

			return new UserModel
			{
				Cpf = entity.Cpf,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				DateOfBirth = entity.DateOfBirth,
				Email = entity.Email,
				PhoneNumber = entity.PhoneNumber
			};
		}

		public void UpdateUser(UserModel user)
		{
			var userEntity = _context.Users.First(x => x.Id == user.Id);

			userEntity.Cpf = user.Cpf;
			userEntity.FirstName = user.FirstName;
			userEntity.LastName = user.LastName;
			userEntity.DateOfBirth = user.DateOfBirth;
			userEntity.Email = user.Email;
			userEntity.PhoneNumber = user.PhoneNumber;

			_context.SaveChanges();
		}

		public List<UserModel> GetAllUsers()
		{
			var usersEntities = _context.Users.ToList();

			var users = new List<UserModel>();

			usersEntities.ForEach(x => users.Add(new UserModel
			{
				Id = x.Id,
				Cpf = x.Cpf,
				FirstName = x.FirstName,
				LastName = x.LastName,
				DateOfBirth = x.DateOfBirth,
				Email = x.Email,
				PhoneNumber = x.PhoneNumber

			}));

			return users;
		}
	}
}
