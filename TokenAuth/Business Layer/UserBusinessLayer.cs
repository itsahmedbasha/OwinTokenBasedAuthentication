using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokenAuth.DataAccess_Layer;
using TokenAuth.Models;

namespace TokenAuth.Business_Layer
{
    public class UserBusinessLayer : IDisposable
    {

        public bool RegisterUser(User userModel)
        {

            using (UserDataAccessLayer userDL = new UserDataAccessLayer())
            {
                var responseModel = userDL.RegisterUser(userModel);
            }

            return true;
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