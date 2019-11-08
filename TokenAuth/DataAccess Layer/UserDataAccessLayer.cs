using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TokenAuth.Models;

namespace TokenAuth.DataAccess_Layer
{
    public class UserDataAccessLayer : IDisposable
    {
        string connectionString = "server=192.168.0.205;database=LearnSQL;user=trainee;password=trainee";

        public bool RegisterUser(User userModel)
        {

            var response = true;

            // forming query for inserting data to table
            var registerQuery = "insert into sab_RegisteredUsers (UserName,UserPassword,FullName,EmailID,MobileNumber,GenderID)"
                                + "values ('" + userModel.UserName + "','" + userModel.UserPassword + "','"
                                + userModel.FullName + "','" + userModel.Email + "','" + userModel.MobileNumber + "'," + userModel.GenderID + ")";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(registerQuery, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                    finally
                    {

                    }
                }

                conn.Close();
            }


            return response;
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