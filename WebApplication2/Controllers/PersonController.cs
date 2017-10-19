using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> Products = new List<Person>();

        //public PersonController()
        //{
        //    if (Person.Count() == 0)
        //    {
        //        Person p = new Person
        //        {
        //            FirstName = "Anuj",
        //            LastName = "Patel",
        //            BirthDate= "1/1/1996",
        //            Age = 21
        //        };

        //        Person.Add(p);
        //    }
        //}
        //public IActionResult ShowProduct(int? id)
        //{
        //    Person p;
        //    if (id == null)
        //    {
        //        p = new Product
        //        {
        //            FirstName = "Anuj",
        //            LastName = "Patel",
        //            BirthDate = "1/1/1996",
        //            Age = 21
        //        };
        //    }
        //    else
        //    {
        //        p = Products.Find(prod => prod.ProductID == id);
        //    }
        //    id = null;
        //    return View(p);
        //}

        public IActionResult PersonList()
        {
            return View(Person);
        }

        public IActionResult EnterPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterPerson(Person p)
        {
            if (ModelState.IsValid)
            {
                Person.Add(p);
                return View("ShowPerson", p);
            }
            else
            {
                return View();
            }
        }

    }
}