using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class FRoutes
    {
        public int RouteFact_ID { get; set; }
        
        [Required(ErrorMessage = "Ruta no seleccionada")]
        public int RouteID { get; set; }
        public string RouteName { get; set; }
        
        [Required(ErrorMessage = "Responsable no seleccionada")]
        public int ResponsibleID { get; set; }
        public string ResponsibleName { get; set; }

        [Required(ErrorMessage = "Fecha vacia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Fecha vacia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DepartureDate { get; set; }
    }
}