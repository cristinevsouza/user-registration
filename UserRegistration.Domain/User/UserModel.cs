namespace UserRegistration.Domain.User
{
	public struct UserModel
	{
		public string Cpf { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public bool IsAdult()
		{
			DateTime currentDate = DateTime.Today;
			DateTime adulthoodDate = DateOfBirth.AddYears(18);

			return adulthoodDate <= currentDate;
		}
	}
}

