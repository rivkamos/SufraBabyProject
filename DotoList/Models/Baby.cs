
using DotoList.Models;

namespace DotoList.models
{
    public class Baby : Person,IActions
    {
        public string[] Vaccinations { get; set; }

        public int MyProperty { get; set; }
        public string GetName { get ; set ; }

        public void Login()
        {
            string message = "Baby can't login";
            Console.WriteLine(message);
        }

        public void Logout()
        {
            string message = "Baby can't logout";
            Console.WriteLine(message);
        }

        public string Print()
        {
            return $"Baby name: {FirsrtName} {LastName}, BirthDate: {BirthDate}, Vaccinations: {string.Join(", ", Vaccinations)}";
        }
    }
}
