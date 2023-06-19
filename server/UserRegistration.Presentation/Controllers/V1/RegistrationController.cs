using Microsoft.AspNetCore.Mvc;
using UserRegistration.Domain.Registration;
using UserRegistration.Presentation.Dtos;

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
        public IActionResult AddUserRegistration(RegistrationDto registrationDto)
        {
            _registrationService.AddUserRegistration(registrationDto.ToModel());
            return Ok();
        }

        [HttpGet("GetRegistrationByUserId")]
        public IActionResult GetRegistrationByUserId(int userId)
        {
            var registrationModel = _registrationService.GetUserRegistration(userId);
            return Ok(registrationModel);
        }

        [HttpPut("UpdateUserRegistration")]
        public IActionResult UpdateUserRegistration(RegistrationDto registrationDto)
        {
            _registrationService.UpdateUserRegistration(registrationDto.ToModel());
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
