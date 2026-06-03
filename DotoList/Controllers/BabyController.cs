
using DotoList.models;
using DotoList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        
        
        [HttpGet] // GET משמשת לקבלת מידע מהשרת
        public ActionResult<List<Baby>> Get()
        {
            return DataContext.babys;
        }

        [HttpGet("GetBaby")]
        public ActionResult<Baby> GetBaby(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            return DataContext.babys[id];
        }

        [HttpPost]
        public ActionResult Add([FromBody] Baby baby)
        {
            if(baby == null) {
                return NotFound();
            }


            DataContext.babys.Add(baby);
            return Created();
        }

        [HttpGet("Dup")]
        public int Dup(int x , int y)
        {
            return x / y;
        }
    }
}
