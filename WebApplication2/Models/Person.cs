using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String BirthDate { get; set; }
        public int Age { get; set; }

    }
}
