using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mcptouch.Models
{
    public class MaintenanceAlertOverdue
    {
        public int JobID { get; set; }
        public string Nickname { get; set; }
        public string JobDescr { get; set; }
        public DateTime DateDueNext { get; set; }        
        public int MileageDueNext { get; set; }
        public int CurrentProjectedMiles { get; set; }
        public int MaintenanceID { get; set; }
        public int CarID { get; set; }
    }
}