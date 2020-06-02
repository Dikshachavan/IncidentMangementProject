using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewDemoProject.Models
{
    public class incidentlist
    {
        public int incidentID { get; set; }

        public string title { get; set; }

        public List<incidentlist> incidentarray { get; set; }
    }
}