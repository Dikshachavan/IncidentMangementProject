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

        public string incident_description { get; set; }

        public string raised_by { get; set; }

        public DateTime? created_on { get; set; }

        public DateTime? altered_on { get; set; }

        public List<incidentlist> incidentarray { get; set; }

        

    }
}