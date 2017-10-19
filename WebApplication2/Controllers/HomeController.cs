using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Web Application 2 - Lab 5";
            DateTime today = DateTime.Now;
            //DateTime today = new DateTime(2017, 10, 12, 8, 30, 0);
            // DateTime.Now;

            int time = today.Hour;
            if (time < 12)
            {
                ViewData["Greeting"] = "Good Morning";
            }
            else if (time < 18)
            {
                ViewData["Greeting"] = "Good Afternoon";
            }
            else
            {
                ViewData["Greeting"] = "Good Evening";
            }

            int dayInYear = DateTime.IsLeapYear(today.Year) ? 366 : 365;
            int dayInYearLeft = dayInYear - today.DayOfYear;

            ViewData["Time"] = today.ToShortTimeString();
            ViewData["Date"] = today.ToShortDateString();
            ViewData["Days"] = dayInYearLeft;
            ViewData["Year"] = today.Year;
            return View();
        }

        public IActionResult SecondPage(int id)
        {
            String[] items = { "C#", "HTML5", "CSS3", "JavaScript", "Python", "C++" };
            ViewData["ID"] = id;
            return View(items);
        }
    }
}