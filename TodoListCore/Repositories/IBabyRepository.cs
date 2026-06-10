
using TodoListCore.Models;

namespace DotoList.Interfaces
{
    public interface IBabyRepository
    {
        public List<Baby> Get();

        public Baby GetBaby(int id);

        public void Add(Baby baby);

        public List<Baby> GetBabyByName(string str);
        public int Dup(int x, int y);
        void UpdateBaby(Baby baby);
    }
}
