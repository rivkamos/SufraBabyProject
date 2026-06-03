using DotoList.Interfaces;
using DotoList.models;
using DotoList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotoList.Services
{
    public class BabyService : IBabyService
    {
       private readonly DataContext _context;

        public BabyService(DataContext context)
        {
            _context = context;
        }

        public List<Baby> Get()
        {
            return _context.babys;
        }

        public Baby GetBaby(int id)
        {
        //    foreach (var w in_context.babys)
        //    {
        // if(w.Name == str)
        //    }

            return _context.babys.FirstOrDefault(f => f.Id == id);
        }

        public void Add(Baby baby)
        {
           _context.babys.Add(baby);
        }

        public List<Baby> GetBabyByName(string str)
        {
            return _context.babys.Where(w => w.Name.Contains(str)).ToList();

        }

        public void UpdateBaby(Baby baby)
        {
            var currentBaby = _context.babys.FirstOrDefault(w => w.Id == baby.Id);
            
            if (currentBaby != null) {
                currentBaby = baby;
            }

        }

        public int Dup(int x, int y)
        {
            return x / y;
        }
    }
}
