using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistration.Domain.Address;
using UserRegistration.Presentation.Dtos;

namespace UserRegistration.Presentation.Controllers.V1
{
	[ApiController]
	[Route("api/address/v1")]
	public class AddressControler : Controller
    {
        private readonly IZipCodeService _zipCodeService;
        public AddressControler(IZipCodeService zipCodeService)
        {
			_zipCodeService = zipCodeService;
		}

        [HttpGet("GetAddressByZipCode")]
		public async Task<ActionResult> GetAddressByZipCodeAsync(string zipCode)
        {
			var addressModel = await _zipCodeService.GetAddressByZipCodeAsync(zipCode);

			var addressDto = new AddressDto
			{
				ZipCode = addressModel.ZipCode.Replace("-", string.Empty),
				City = addressModel.City,
				State = addressModel.State,
				Neighborhood = addressModel.Neighborhood,
				Street = addressModel.Street
			};

			return Ok(addressDto);
		}
    }
}
