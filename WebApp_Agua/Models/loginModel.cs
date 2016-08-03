using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp_Agua.Models
{
    public class loginModel
    {
        [Required(ErrorMessage = "Usuario Requerido", AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Contraseña Requerida", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
    }
}