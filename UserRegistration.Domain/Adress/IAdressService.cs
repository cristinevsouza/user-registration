
namespace UserRegistration.Domain.Adress
{
	public interface IAdressService
	{
		string Add(AdressModel adress);

		AdressModel GetById(int id);

		void Update(AdressModel adress);
	}
}
