using HodowlaYorkshire.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HodowlaYorkshire
{
    public partial class DogDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int? dogId = Convert.ToInt32(Request.QueryString["DogId"]);

            var db = new DogContext();
            IQueryable<Dog> query = db.Dogs;

            if(dogId.HasValue && dogId> 0)
            {
                Dog dog = query.Single(d => d.DogId == dogId);
                showAllImages(dog);
            }
        }

        public IQueryable<Dog> GetDog([QueryString("DogId")] int? dogId)
        {
            var db = new DogContext();
            IQueryable<Dog> query = db.Dogs;

            if(dogId.HasValue && dogId > 0)
            {
                query = query.Where(d => d.DogId == dogId);
                
                //showAllImages(query, dogId);
            }
            else
            {
                query = null;
            }

            return query;
        }

        private void showAllImages(Dog dog)
        {
            //var dog = query.Single(p => p.DogId == dogId);

            foreach (var strFileName in Directory.GetFiles(MapPath($"~/Images/{dog.ImageFolderPath}/")))
            {
                var imageButton = new ImageButton();
                var fileInfo = new FileInfo(strFileName);
                imageButton.ImageUrl = $"~/Images/{dog.ImageFolderPath}/" + fileInfo.Name;
                imageButton.Height = Unit.Pixel(250);
                imageButton.Width = Unit.Pixel(250);
                imageButton.Style.Add("padding", "5px");
                imageButton.Click += new ImageClickEventHandler(ImageButton_Click);

                ImagePanel.Controls.Add(imageButton);
            }
        }

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(((ImageButton)sender).ImageUrl);
        }

        protected void ImagesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DogDetails?DogId=2");
        }
    }
}