using DotoList.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoListCore.Services;

namespace DotoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMsgController : ControllerBase
    {
        private readonly IMsg _msgService;

        public UserMsgController(IMsg service)
        {
            _msgService = service;
            //IMsg[] msg = new IMsg[2];
            //msg[0] = new SmsService();
            //msg[1] = new EmailService();

        }

        [HttpGet("MsgLogin")]
        public string MsgLogin(string id)
        {
            return _msgService.Login(id);
        }

        [HttpGet("MsgLogout")]
        public string MsgLogout(string id)
        {
            return _msgService.Logout(id);
        }
    }
}
