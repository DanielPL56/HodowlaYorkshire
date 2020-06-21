using HodowlaYorkshire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HodowlaYorkshire
{
    public partial class DogList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Dog> GetDogs([QueryString("Id")] int? breedId)
        {
            var db = new DogContext();
            IQueryable<Dog> query = db.Dogs.Include("Breed");

            if(breedId.HasValue && breedId > 0)
            {
                query = query.Where(d => d.BreedId == breedId);
            }

            return query;
        }
    }
}