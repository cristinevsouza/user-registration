
namespace UserRegistration.Domain.User
{
	public interface IUserRepository
	{
		int Add(UserModel user);

		UserModel GetById(int id);

		void Update(UserModel user);
	}
}
