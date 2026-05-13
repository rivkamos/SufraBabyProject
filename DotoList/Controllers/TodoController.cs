using DotoList.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        

        // GET: api/<TodoController>
        [HttpGet]
        public List<string> Get()
        {
            return DataContext.allTask;
        }

        [HttpGet("GetOneItem")]
        public string Get([FromQuery] int? index, string? name, string? level)
        {
            if(index > DataContext.allTask.Count - 1 || !index.HasValue)
            {
                return "אין כזאת משימה";
            }
            return DataContext.allTask[index.Value];
        }

        [HttpGet("{index}")]
        public string GetTask(int index)
        {
            if (index > DataContext.allTask.Count - 1)
            {
                return "אין כזאת משימה";
            }
            return DataContext.allTask[index];
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
            DataContext.allTask.Add(value);
        }
    }

}
