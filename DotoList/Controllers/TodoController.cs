using Microsoft.AspNetCore.Mvc;
using TodoListCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly DataContext _context;

        public TodoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<TodoController>
        [HttpGet]
        public List<string> Get()
        {
            return _context.allTask;
        }

        [HttpGet("GetOneItem")]
        public string Get([FromQuery] int? index, string? name, string? level)
        {
            if(index > _context.allTask.Count - 1 || !index.HasValue)
            {
                return "אין כזאת משימה";
            }
            return _context.allTask[index.Value];
        }

        [HttpGet("{index}")]
        public string GetTask(int index)
        {
            if (index > _context.allTask.Count - 1)
            {
                return "אין כזאת משימה";
            }
            return _context.allTask[index];
        }

        [HttpGet("GetTask2/{index}/username/{name}")]
        public string GetTask2([FromRoute] string name,[FromRoute] int index)
        {
            return "Hello";
        }


        [HttpGet("GetComment/{name}")]
        public string GetComment([FromRoute] string name)
        {
            return "Hello";

        }
        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _context.allTask.Add(value);
        }
    }

}
