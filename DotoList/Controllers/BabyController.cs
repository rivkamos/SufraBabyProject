
using DotoList.models;
using DotoList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        private static List<Baby> babys = new List<Baby>();
        
        [HttpGet] // GET משמשת לקבלת מידע מהשרת
        public List<Baby> Get()
        {
            return babys;
        }

        [HttpGet("GetBaby")]
        public Baby GetBaby(int id)
        {
            //Baby baby = new Baby();
            //baby.printAddress();

            //Person person1 = new Baby();
            //Baby baby1 = (Baby)person1; // אפשר להמיר את person1 ל baby1 כי person1 הוא בעצם תינוק

            //Person person2 = new Doctor();


            Person[] people = new Person[2];
            people[0] = new Baby();
            people[1] = new Doctor();

            IActions[] actions = new IActions[2];
            actions[0] =new Baby();
            actions[1] = new Doctor();
            //actions[2] = new Person();

            callLogout(actions);
            //Doctor doctor = new Person();
            Print(people);
            return babys[id];
        }

        public void callLogout(IActions[] people)
        {
            foreach (IActions p in people)
            {
                p.Logout();
                p.Login();
            }
        }

        public void logout(Person[] people)
        {
            foreach (Person person in people)
            {
                if (person is Baby)
                {
                    ((Baby)person).Logout();
                }
                else if (person is Doctor)
                {
                    ((Doctor)person).Logout();
                }
            }
        }

        public void Print(Person[] people)
        {
            foreach (Person person in people)
            {
                if(person is Baby)
                {
                   // Baby baby = (Baby)person; // אפשר להמיר את person ל baby כי person הוא בעצם תינוק
                    Console.WriteLine($"This is a baby {((Baby)person).Vaccinations}");
                }
                else if (person is Doctor)
                {
                    Console.WriteLine("This is a doctor");
                }
            }
        }

        [HttpPost]
        public void Add([FromBody] Baby baby)
        { 
             babys.Add(baby);
        }
    }
}
