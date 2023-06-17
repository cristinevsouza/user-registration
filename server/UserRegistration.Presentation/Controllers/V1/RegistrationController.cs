using Microsoft.AspNetCore.Mvc;
using UserRegistration.Domain.Registration;

namespace UserRegistration.Presentation.Controllers.V1
{
    [ApiController]
    [Route("api/registration/v1")]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;
        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost("AddUserRegistration")]
        public IActionResult AddUserRegistration(RegistrationModel registration)
        {
            _registrationService.AddUserRegistration(registration);
            return Ok();
        }

        [HttpGet("GetRegistrationByUserId")]
        public IActionResult GetRegistrationByUserId(int userId)
        {
            var registrationModel = _registrationService.GetUserRegistration(userId);
            return Ok(registrationModel);
        }

        [HttpPut("UpdateUserRegistration")]
        public IActionResult UpdateUserRegistration(RegistrationModel registration)
        {
            _registrationService.UpdateUserRegistration(registration);
            return Ok();
        }

        [HttpGet("GetAllRegistrations")]
        public IActionResult GetAllRegistrations()
        {
            var registrations = _registrationService.GetAllUserRegistrations();

            return Ok(registrations);
        }
    }
}
