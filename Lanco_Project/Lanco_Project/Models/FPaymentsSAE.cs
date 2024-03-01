using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class FPaymentsSAE
    {
        public int PaymentSAE_ID { get; set; }

        [Required(ErrorMessage = "Cliente no seleccionada")]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Banco no seleccionada")]
        public int BankID { get; set; }
        public string BankName { get; set; }

        [Required(ErrorMessage = "Fecha no Ingresada")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Monto no ingresado")]
        public decimal  PaymentAmount { get; set; }

        [Required(ErrorMessage = "Moneda no seleccionada")]
        public int CurrencyID { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }

        [Required(ErrorMessage = "Ruta no seleccionada")]
        public int RouteID { get; set; }
        public string RouteName { get; set; }

        [Required(ErrorMessage = "Responsable no seleccionada")]
        public int ResponsibleID { get; set; }
        public string ResponsibleName { get; set; }
    }
}