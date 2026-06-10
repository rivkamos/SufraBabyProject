using TodoListCore.Models;

namespace DotoList.Interfaces
{
    public interface IBabyService
    {
        public List<Baby> Get();

        public Baby GetBaby(int id);

        public void Add(Baby baby);

        public List<Baby> GetBabyByName(string str);
        public int Dup(int x, int y);
    }
}
