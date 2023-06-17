
namespace UserRegistration.Domain.Adress
{
	public interface IAdressRepository
	{
		string Add(AdressModel adress);

		AdressModel GetById(int id);

		void Update(AdressModel adress);
	}
}
