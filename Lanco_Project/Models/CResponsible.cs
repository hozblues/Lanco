using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class CResponsible
    {
        public int ResponsibleID { get; set; }
        public string ResponsibleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}