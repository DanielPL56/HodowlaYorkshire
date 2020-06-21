using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace HodowlaYorkshire.Models
{
    public class Dog
    {
        [ScaffoldColumn(false)]
        public int DogId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(1000), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public double? Price { get; set; }

        public string PrimaryImagePath { get; set; }

        public string ImageFolderPath { get; set; }

        public int? BreedId { get; set; }

        public virtual Breed Breed { get; set; }
    }
}