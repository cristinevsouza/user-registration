
namespace UserRegistration.Domain.User
{
	public interface IUserService
	{
		int Add(UserModel user);

		UserModel GetById(int id);

		void Update(UserModel user);
	}
}
