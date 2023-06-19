using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistration.Presentation.Dtos;

namespace UserRegistration.Presentation.Controllers.V1
{
	[ApiController]
	[Route("api/address/v1")]
	public class AddressControler : Controller
    {
		[HttpGet("GetAddressByZipCode")]
		public ActionResult GetAddressByZipCode(string zipCode)
        {
			return Ok(new AddressDto
            {
                ZipCode = zipCode,
                State = "AM",
                City = "Manaus",
                Neighborhood = "Bairro",
                Street = "Rua Liberdade"
            });
        }
    }
}
