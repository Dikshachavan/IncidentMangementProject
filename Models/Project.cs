using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Text;

namespace NewDemoProject.Models
{
    public class Project
    {
        public int Project_ID { get; set; }
        public string Project_Name { get; set; }
        public string Department_Name { get; set; }
        public string  Location { get; set; }
        public string Workstation_Number { get; set; }
        public string Extension_Number { get; set; }
    }
}