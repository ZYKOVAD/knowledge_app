using Microsoft.AspNetCore.Mvc;

namespace KnowledgeApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public HomeController(){}

        [HttpGet]
        public IResult Get()
        {
            return Results.Ok();
        }
    }
}
