using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class CBanks
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}