namespace DotoList.Models
{
    public class Doctor : Person, IActions
    {
        public string Licence { get; set; }
        public string GetName { get ; set; }

        public void Login()
        {
            Console.WriteLine("Doctor logged in");
        }

        public void Logout()
        {
             string message = "Doctor logged out";
            Console.WriteLine(message);
        }

        public string Print()
        {
            return $"Doctor name: {FirsrtName} {LastName}, BirthDate: {BirthDate}, Licence: {Licence}";
        }
    }
}
   