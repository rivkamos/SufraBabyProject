using TodoListCore.Services;

namespace TodoListServices.Services
{
    public class SmsService : IMsg
    {
        public string Login(string id) => "Sms: user login";

        public string Logout(string id) => "Sms: user logout";
    }
}
