using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mcptouch.Helpers
{
    public class ProjectDate
    {

        public static string GetProjectDateRange(int startYear = 2013)
        {
            if (DateTime.Now.Year > startYear)
            {
                return startYear.ToString() + " - " + DateTime.Now.Year.ToString();
            }
            else
            {
                return startYear.ToString();
            }
        }
    }
}