/*Se insertan las propiedades de la tabla de la base de datos, publicas o privadas y se define los metodos
a los que serán accesibles */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class ContactoModel
    {
        public int IdContact { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}