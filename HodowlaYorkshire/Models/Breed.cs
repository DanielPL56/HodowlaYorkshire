using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HodowlaYorkshire.Models
{
    public class Breed
    {
        [ScaffoldColumn(false)]
        public int BreedId { get; set; }

        [Required, StringLength(100)]
        public string BreedName { get; set; }

        public ICollection<Dog> Dogs { get; set; }
    }
}