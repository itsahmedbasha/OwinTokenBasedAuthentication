using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuth.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string FullName { get; set; }

        public int GenderID { get; set; }

        public string Gender { get; set; }

        public bool InActive { get; set; }

    } 
}