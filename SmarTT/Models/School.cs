﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SmarTT.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le nom doit être entre 5 et 100 caractère.", MinimumLength = 5)]
        [Display(Name = "Nom", Description = "Le nom de l'établissement")]
        public string Name { get; set; }

        public virtual List<Departement> Departements { get; set; }
    }
}