using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class CRoutes
    {
        public int RouteId { get; set; }
        public string RouteName { get; set;}
        public bool IsActive { get; set;}
        public DateTime CreatedDate { get; set; }
    }
}