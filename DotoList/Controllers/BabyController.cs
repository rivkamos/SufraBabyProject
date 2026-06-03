
using DotoList.Interfaces;
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
        private readonly IBabyService _babyService;

        public BabyController(IBabyService service)
        {
            _babyService = service;
        }

        [HttpGet] // GET משמשת לקבלת מידע מהשרת
        public ActionResult<List<Baby>> Get()
        {
            return _babyService.Get();
        }

        [HttpGet("GetBaby")]
        public ActionResult<Baby> GetBaby(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            return _babyService.GetBaby(id);
        }

        [HttpPost]
        public ActionResult Add([FromBody] Baby baby)
        {
            if(baby == null) {
                return NotFound();
            }


            _babyService.Add(baby);
            return Created();
        }

        [HttpGet("Dup")]
        public int Dup(int x , int y)
        {
            return _babyService.Dup(x,y);
        }
    }
}
