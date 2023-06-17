using Microsoft.AspNetCore.Mvc;
using UserRegistration.Domain.Registration;

namespace UserRegistration.Presentation
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistrationController : ControllerBase
	{
		private readonly IRegistrationService _registrationService;
		public RegistrationController(IRegistrationService registrationService)
		{
			_registrationService = registrationService;
		}
		
		[HttpGet("{id}")]
		//[Route("GetById")]
		public string GetById(int id)
		{
			return "value";
		}


		[HttpPost]
		//[Route("Add")]
		public void Add(RegistrationModel registration)
		{
			_registrationService.Add(registration);
		}

		[HttpPut("{id}")]
		//[Route("Update")]
		public void Update(int id, [FromBody] string value)
		{

		}
	}
}
