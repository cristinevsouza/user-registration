using UserRegistration.Domain.User;

namespace UserRegistration.Application
{
	public class UserService : IUserService
	{
		readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository) 
		{
			_userRepository = userRepository;
		}

		public int Add(UserModel user)
		{
			return _userRepository.Add(user);
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
