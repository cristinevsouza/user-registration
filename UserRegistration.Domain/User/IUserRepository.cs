
namespace UserRegistration.Domain.User
{
	public interface IUserRepository
	{
		string Add(UserModel user);

		UserModel GetById(int id);

		void Update(UserModel user);
	}
}
