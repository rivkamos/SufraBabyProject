using System.Reflection.Metadata.Ecma335;
using TodoListCore.Services;

namespace TodoListServices.Services
{
    public class EmailService : IMsg
    {
        public void print()
        {

        }
        public string Login(string id) => "email: user login";

        public string Logout(string id) => "email: user logout";
    }
}
