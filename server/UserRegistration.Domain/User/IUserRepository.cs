
namespace UserRegistration.Domain.User
{
	public interface IUserRepository
	{
		int AddUser(UserModel user);

		UserModel? GetUserById(int id);

		void UpdateUser(UserModel user);

		List<UserModel> GetAllUsers();
	}
}
