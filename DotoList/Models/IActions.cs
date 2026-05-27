namespace DotoList.Models
{
    public interface IActions
    {
        public string Print();

        public void Login();
        public void Logout();
        public string GetName { get; set; }

    }
}
