
namespace UserRegistration.Domain.User
{
	public interface IUserService
	{
		string Add(UserModel user);

		UserModel GetById(int id);

		void Update(UserModel user);
	}
}
