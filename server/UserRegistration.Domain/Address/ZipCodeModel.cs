using System.Text.Json.Serialization;

namespace UserRegistration.Domain.Address
{
	public class ZipCodeModel
	{
		[JsonPropertyName("cep")]
		public string ZipCode { get; set; }
		[JsonPropertyName("uf")]
		public string State { get; set; }
		[JsonPropertyName("localidade")]
		public string City { get; set; }
		[JsonPropertyName("bairro")]
		public string Neighborhood { get; set; }
		[JsonPropertyName("logradouro")]
		public string Street { get; set; }
	}
}
