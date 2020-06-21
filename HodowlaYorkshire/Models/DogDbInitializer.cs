using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HodowlaYorkshire.Models
{
    public class DogDbInitializer : DropCreateDatabaseIfModelChanges<DogContext>
    {
        protected override void Seed(DogContext context)
        {
            getBreeds().ForEach(b => context.Breeds.Add(b));
            getDogs().ForEach(d => context.Dogs.Add(d));
        }

        private List<Breed> getBreeds()
        {
            var breeds = new List<Breed>
            {
                new Breed { BreedId = 1, BreedName = "Shih Tzu" },
                new Breed { BreedId = 2, BreedName = "Yorkshire Terrier" },
                new Breed { BreedId = 3, BreedName = "Chihuahua" }
            };

            return breeds;
        }

        private List<Dog> getDogs()
        {
            var dogs = new List<Dog>
            {
                new Dog
                {
                    BreedId = 1,
                    DogId = 1,
                    Name = "ShihTzu1",
                    Description = "Pierwszy ShihTzu dodany do bazy danych",
                    PrimaryImagePath = "ShihTzu/Primary.jpg",
                    ImageFolderPath = "ShihTzu"
                },
                new Dog
                {
                    BreedId = 2,
                    DogId = 2,
                    Name = "York1",
                    Description = "Pierwszy york dodany do bazy danych",
                    PrimaryImagePath = "York/Primary.jpg",
                    ImageFolderPath = "York"
                },
                new Dog
                {
                    BreedId = 3,
                    DogId = 3,
                    Name = "Chihuahua1",
                    Description = "Pierwszy chihuahua dodany do bazy danych",
                    PrimaryImagePath = "Chihuahua/Primary.jpg",
                    ImageFolderPath = "Chihuahua"
                },
            };

            return dogs;
        }
    }
}