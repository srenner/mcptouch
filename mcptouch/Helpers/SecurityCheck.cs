using mcptouch.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace mcptouch.Helpers
{
    public static class SecurityCheck
    {


        public static bool UserOwnsCar(int userID, int carID)
        {
            try
            {
                string strQuery = "SELECT COUNT(*) AS Result FROM Cars WHERE UserID = @UserID AND CarID = @CarID";
                var db = new mcpnetEntities_dev();
                var parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("UserID", userID);
                parameters[1] = new SqlParameter("CarID", carID);
                var result = db.Database.SqlQuery<int>(strQuery, parameters).Single();
                db.Dispose();
                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}