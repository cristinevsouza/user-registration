using UserRegistration.Infrastructure.User;

namespace UserRegistration.Infrastructure.Adress
{
	public class AdressEntity
	{
        public int Id { get; set; }

        public string Cep { get; set; }

		public string UF { get; set; }

		public string Cidade { get; set; }

		public string Bairro { get; set; }

		public string Logradouro { get; set; }

		public string Numero { get; set; }

		public string Complemento { get; set; }

        public string Referencia { get; set; }

		public int UserId { get; set; }

		public UserEntity User { get; set; }
	}
}
