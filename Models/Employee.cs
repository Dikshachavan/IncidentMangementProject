using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewDemoProject.Models
{
    public class Employee
    {
        public string Email_ID { get; set; }
        public int Employee_ID { get; set; }
        public string Name { get; set; }
        public string Contact_Number { get; set; }
        public string Password { get; set; }
        public int Project_ID { get; set; }
    }
}