using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewDemoProject.Models
{
    public class status
    {
        public string assignedto { get; set; }
        public string currstatus { get; set; }

        public List<status> statuses { get; set; }
    }
}