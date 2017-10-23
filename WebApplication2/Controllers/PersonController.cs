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
        private static List<Person> Person = new List<Person>();

        public IActionResult Index()
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
                Person.Add((p));
                return View("ShowPerson", p);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ShowPerson(Person p)
        {
            return View(p);
        }


    }
}