using DotoList.Interfaces;
using DotoList.Models;
using System.Threading.Tasks;
using TodoListCore.Models;

namespace TodoListServices.Services
{
    public class BabyService : IBabyRepository
    {
       private readonly IBabyRepository _babyRepository;

        public BabyService(IBabyRepository babyRepository)
        {
            _babyRepository = babyRepository;
            // _context = context;
        }

        public List<Baby> Get()
        {
            return _babyRepository.Get();
        }

        public Baby GetBaby(int id)
        {
        //    foreach (var w in_context.babys)
        //    {
        // if(w.Name == str)
        //    }

            return _babyRepository.GetBaby(id);
        }

        public void Add(Baby baby)
        {
            _babyRepository.Add(baby);
        }

        public List<Baby> GetBabyByName(string str)
        {
            return _babyRepository.GetBabyByName(str);

        }

        public void UpdateBaby(Baby baby)
        {
            _babyRepository.UpdateBaby(baby);

        }

        public int Dup(int x, int y)
        {
            return x / y;
        }
    }
}
