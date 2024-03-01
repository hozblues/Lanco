using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class FForecast
    {
        public int Forecasts_ID { get; set; }

        [Required(ErrorMessage = "Factura no Ingresada")]
        public string Invoice { get; set; }
        
        [Required(ErrorMessage = "Fecha no Ingresada")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AgreedPaymentDate { get; set; }

        [Required(ErrorMessage = "Monto no Ingresada")]
        public decimal AgreedAmount { get; set; }

        [Required(ErrorMessage = "Obra no seleccionada")]
        public int ConstructionSiteID { get; set; }
        public string ConstructionSiteName { get; set; }

        [Required(ErrorMessage = "Ruta no seleccionada")]
        public int RouteID { get; set; }
        public string RouteName { get; set; }

        [Required(ErrorMessage = "Responsable no seleccionada")]
        public int ResponsibleID { get; set; }
        public string ResponsibleName { get; set; }
    }
}