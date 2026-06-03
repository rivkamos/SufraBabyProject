
namespace DotoList.models
{
    public class Baby
    {
        public int Id { get; set; }
        public int Id2 { get; set; }
        public string Name { get; set; }
        //public DateOnly BirthDate { get; set; }

        public int index2 { get; set; }
        public static int index;

        public Baby()
        {
            Id = index++;
            Id2 = index2++;
        }

        public void print()
        {

        }
    }
}
