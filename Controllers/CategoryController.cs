using api_web_inventory.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_web_inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IDbConnection _dbConnection;

        public CategoryController(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            string sqlQuery = "SELECT * FROM Categories";
            var categories = _dbConnection.Query<Category>(sqlQuery);
            return Ok(categories);
        }

    }
}
