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

		public int AddUser(UserModel user)
		{
			return _userRepository.AddUser(user);
		}

		public UserModel? GetUserById(int id)
		{
			return _userRepository.GetUserById(id);
		}

		public void UpdateUser(UserModel user)
		{
			_userRepository.UpdateUser(user);
		}

		public List<UserModel> GetAllUsers()
		{
			return _userRepository.GetAllUsers();
		}
	}
}
