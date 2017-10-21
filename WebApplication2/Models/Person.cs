using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Input value between 2-20 characters long")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Input value between 2-20 characters long")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        //public int Age { get; set; }

        internal static void Add(Person p)
        {
            throw new NotImplementedException();
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int Age = now.Year - BirthDate.Year;
                if (now < BirthDate.AddYears(Age)) Age--;
                return Age;
            }
        }

    }
}

