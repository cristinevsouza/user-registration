using System.Net.Http.Json;
using UserRegistration.Domain.Address;

namespace UserRegistration.Infrastructure.Network
{
	public class ApiZipCodeService : IZipCodeService
	{
		private readonly string _viaCepUrl = "https://viacep.com.br/ws/{0}/json/";

		public async Task<ZipCodeModel> GetAddressByZipCodeAsync(string zipCode)
		{
			string uri = string.Format(_viaCepUrl, zipCode);
			ZipCodeModel jsonResponse;

			using (HttpClient httpClient = new())
			{
				httpClient.BaseAddress = new Uri(uri);
				jsonResponse = await httpClient.GetFromJsonAsync<ZipCodeModel>(uri);
			}

			return jsonResponse;
		}
	}
}
