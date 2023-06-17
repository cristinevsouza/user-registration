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

		public int Add(UserModel user)
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

			public UserModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(UserModel user)
		{
			throw new NotImplementedException();
		}
	}
}
