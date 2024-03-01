using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class FFiles
    {
        public int Files_ID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string NumberFile { get; set; }
        public int ConstructionSiteID { get; set; }
        public string ConstructionSiteName { get; set; }
    }
}