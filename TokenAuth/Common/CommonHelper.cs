using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuth.Common
{
    public enum Environment
    {
        Home = 1,
        Office = 2
    }

    public class CommonHelper : IDisposable
    {
        public string GetConnectionStringBasedOnEnvironment()
        {
            string connectionString = "server=192.168.0.205;database=LearnSQL;user=trainee;password=trainee";

            var environmentKey = System.Configuration.ConfigurationManager.AppSettings["Environment"];

            switch (Convert.ToInt32(environmentKey))
            {
                case (int)Environment.Home:
                    connectionString = "server=DESKTOP-S3RV3MH;database=learning;user=learning;password=learning";
                    break;

                case (int)Environment.Office:
                    connectionString = "server=192.168.0.205;database=LearnSQL;user=trainee;password=trainee";
                    break;

                default:
                    break;
            }

            return connectionString;
        }
        
        #region " ************ DISPOSING USED OBJECTS BLOCK********************* "
        // Dispose() calls Dispose(true)
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // The bulk of the clean-up code is implemented in Dispose(bool)
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
        }
        #endregion

    }

}