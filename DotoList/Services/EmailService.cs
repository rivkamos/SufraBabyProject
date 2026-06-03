using DotoList.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace DotoList.Services
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
