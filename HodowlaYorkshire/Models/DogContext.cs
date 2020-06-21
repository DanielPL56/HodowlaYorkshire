using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HodowlaYorkshire.Models
{
    public class DogContext : DbContext
    {
        public DogContext() : base("DogDb") { }


        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}