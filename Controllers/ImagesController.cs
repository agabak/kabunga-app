using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace  Controllers 
{
    public class ImagesController
    {
         public IEnumerable<Image> Get()
         {
              var images = new List<Image>
                            {
                                new Image 
                                {
                                    Id = 1,
                                    Title = "Generation stonwall",
                                    Url = "http://mtomawedemo.azurewebsites.net/img/banner/banner2_001.jpg"
                                },
                                new Image 
                                {
                                    Id = 2,
                                    Title = "Garden ston",
                                    Url = "http://mtomawedemo.azurewebsites.net/img/banner/banner2_002.jpg"
                                },
                                new Image 
                                {
                                    Id = 3,
                                    Title = "just stone",
                                    Url = "http://mtomawedemo.azurewebsites.net/img/banner/banner2_003.jpg"
                                },
                                new Image 
                                {
                                    Id = 4,
                                    Title = "coconut trees",
                                    Url = "http://mtomawedemo.azurewebsites.net/img/banner/banner2_004.jpg"
                                },
                                 new Image 
                                {
                                    Id = 5,
                                    Title = "video photo",
                                    Url = "http://mtomawedemo.azurewebsites.net/img/banner/images.jpg"
                                },

                            };
               return  images.ToList();
         }
    }

}