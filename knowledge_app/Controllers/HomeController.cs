using Microsoft.AspNetCore.Mvc;

namespace knowledge_app.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly KnowledgeTestDbContext db;

        public HomeController(KnowledgeTestDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IResult GetUser(int user_id)
        {
            try
            {
                User user = db.Users.SingleOrDefault(x => x.Id == user_id);
                return Results.Json(user);
            }
            catch (Exception ex)
            {
                return Results.NotFound(ex);
            }
        }

        [HttpGet]
        public IResult GetFaculties()
        {
            try
            {
                List<Faculty> faculties = db.Faculties.ToList();
                return Results.Json(faculties);
            }
            catch (Exception ex)
            {
                return Results.NotFound(ex);
            }
        }

        //получение количества отчетов определенного статуса на текущий семестр по всему университету
        [HttpGet]
        public IResult GetCountOfReportsByStatus(int status_id)
        {
            return Results.Ok(0);
        }

        //получение списка факультетов которые, сдали все отчеты
        [HttpGet]
        public IResult GetFacultiesFinished()
        {
            List<Faculty> faculties = new List<Faculty>();
            return Results.Json(faculties);
        }

        //получение списка факультетов которые, сдали все отчеты
        [HttpGet]
        public IResult GetFacultiesNotFinished()
        {
            List<Faculty> faculties = db.Faculties.ToList();    
            return Results.Json(faculties);
        }


    }
}
