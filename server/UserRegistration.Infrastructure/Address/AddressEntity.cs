using UserRegistration.Infrastructure.User;

namespace UserRegistration.Infrastructure.Address
{
	public class AddressEntity
	{
        public int Id { get; set; }

        public string ZipCode { get; set; }

		public string State { get; set; }

		public string City { get; set; }

		public string Neighborhood { get; set; }

		public string Street { get; set; }

		public string Number { get; set; }

		public string Complement { get; set; }

        public string Reference { get; set; }

		public int UserId { get; set; }

		public UserEntity User { get; set; }
	}
}
