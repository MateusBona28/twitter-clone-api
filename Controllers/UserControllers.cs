using Microsoft.AspNetCore.Mvc;

namespace User.Controllers 
{
    [Route("api/[Controller]")]
    [ApiController]

    public class UserController : ControllerBase 
    {
        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok("nova rota");
        }
    }

}