using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class AccessUser
    {
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
        public int[] RoleID { get; set; }
        public string[] RoleName { get; set; }
    }
}