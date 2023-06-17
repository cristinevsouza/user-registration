using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/<UserController>/5
        [HttpGet("{id}")]
		//[Route("GetById")]
		public string GetById(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        //[Route("Add")]
        public void Add([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
		//[Route("Update")]
		public void Update(int id, [FromBody] string value)
        {

        }
    }
}
