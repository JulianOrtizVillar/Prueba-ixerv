using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginJulianOrtizV.Models
{
    public class UsuariosModel
    {
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre usuario")]
        public string UserName { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }



    }
}