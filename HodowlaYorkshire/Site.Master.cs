using HodowlaYorkshire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HodowlaYorkshire
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Breed> GetBreeds()
        {
            var db = new DogContext();
            var query = db.Breeds;
            return query;
        }
    }
}