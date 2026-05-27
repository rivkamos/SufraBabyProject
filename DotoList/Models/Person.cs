namespace DotoList.Models
{
    public class Person
    {
        private static int idCounter;
        private string Address { get; set; }
        public int Id { get; set; }
        public string FirsrtName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string FullName { get { return FirsrtName + LastName; } }

        public void printAddress()
        {
            Console.WriteLine(Address);
        }

        public Person()
        {
            Id = idCounter++;
        }

    }

}
