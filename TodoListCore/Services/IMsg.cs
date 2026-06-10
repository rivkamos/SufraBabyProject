namespace TodoListCore.Services
{
    public interface IMsg
    {
        string Login(string id);


        string Logout(string id);
    }
}
