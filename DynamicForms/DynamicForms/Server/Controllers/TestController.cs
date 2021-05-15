using DynamicForms.Database;
using DynamicForms.Shared.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicForms.Server.Controllers
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

        [HttpGet("check-api-connection")]
        public IActionResult CheckApiConnection()
        {
            return Ok(new { message = "Test połączenia zakończony pomyślnie" });
        }

        [HttpGet("check-db-connection")]
        public IActionResult CheckDbConnection()
        {
            var result = new List<object>();
            var entities = _db.GetType().GetProperties().Where(p => p.PropertyType.IsGenericType).Select(p => p.Name).ToList();

            foreach (var entity in entities)
            {
                try
                {
                    var records = AssemblyHelper.GetObjectPropertyValue<IEnumerable<object>>(_db, entity);
                    result.Add(new { entity, success = true, count = records.Count() });
                }
                catch (Exception ex)
                {
                    result.Add(new { entity, success = false, error = ex.Message });
                    _logger.LogError(ex, $"Wystąpił błąd podczas próby sprawdzenia tabeli [{entity}]");
                }
            }

            return Json(new
            {
                entitiesCount = result.Count,
                success = result.All(x => ((dynamic)x).success),
                entities = result
            });
        }
    }
}
