using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lanco_Project.Models
{
    public class Users
    {
        public int UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingresar el nombre o los nombres")]
        [StringLength(100)]
        public string UserFirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingresar los apellidos")]
        [StringLength(100)]
        public string UserLastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingresar correo electronico")]
        [RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$", ErrorMessage = "Error, el correo no es valido")]
        [StringLength(20)]
        public string UserEmail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Crear la contraseña de acceso")]
        [StringLength(20)]
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int RelationshipID { get; set; }
    }
}