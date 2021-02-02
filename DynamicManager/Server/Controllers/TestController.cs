using DynamicManager.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace DynamicManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;
        //private readonly IMapper _mapper;
        private readonly AppDbContext _db;

        public TestController(ILogger<TestController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet("test-db-connection")]
        public IActionResult TestDbConnection()
        {
            var form = _db.Forms.FirstOrDefault();
            form.Title += "X";
            _db.SaveChanges();

            return Json(new { message = "OK" });
        }
    }
}
