using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmarTT.Models
{
    public class Departement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le nom doit être entre 5 et 100 caractère.", MinimumLength = 5)]
        [Display(Name = "Nom", Description = "Le nom du département")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Etablissement", Description = "Le nom de l'établissement")]
        public virtual School School { get; set; }
    }
}