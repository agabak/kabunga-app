using System.Collections.Generic;
using System.Linq;
using Model;

namespace BusinessLogic.Services
{
    public interface IImageService
    {
        IEnumerable<Image> GetImages();
        Image GetImage(int id);
        Image GetImageByTitle(string title);
    }
    public class ImageService : IImageService
    {
        public IEnumerable<Image> GetImages()
        {
            return ImageList.Images();
        }
        public Image GetImage(int id)
        {
            return ImageList.Images()
                             .FirstOrDefault(x => x.Id == id);
        }
        public Image GetImageByTitle(string title)
        {
            return ImageList.Images()
                            .FirstOrDefault(x => x.Title == title);
        }
    }

    public static class ImageList
    {
        public static IList<Image> Images()
        {
            return new List<Image>
                            {
                                new Image
                                {
                                    Id = 1,
                                    Title = "Generation stonwall",
                                    Url = "http://mtomawedemo.azurewebsites.net/img/banner/banner2_001.jpg",
                                    IsForBaseGallery = false
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
                                new Image
                                {
                                    Id = 6,
                                    Title = "main-image",
                                    Url =  "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock.jpg",
                                    Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                    Route = "gallery",
                                    SubTitle ="Camping Site and Safari",
                                    IsForBaseGallery =  true
                                },
                                new Image
                                {
                                    Id = 7,
                                    Title = "main-image",
                                    Url =  "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock2.jpg",
                                    Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                    Route = "gallery",
                                    SubTitle ="Photo/Video shooting",
                                    IsForBaseGallery =  true
                                }
                                 ,
                                new Image
                                {
                                    Id = 8,
                                    Title = "main-image",
                                    Url =  "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock3.jpg",
                                    Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                    Route = "gallery",
                                    SubTitle ="Outdoor Events Venue",
                                    IsForBaseGallery =  true
                                },
                                new Image
                                    {
                                        Id = 9,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock5.jpg",
                                        Title = "main-image",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "gallery",
                                        SubTitle ="Bed and Breakfast",
                                        IsForBaseGallery  = true,
                                    },
                                    new Image
                                    {
                                        Id = 10,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock7.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 11,
                                        Url ="http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock8.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle =  "",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 12,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock9.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 13,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock10.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 14,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock11.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 15,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock12.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 16,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock13.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 17,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock14.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 18,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock15.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 19,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock16.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 20,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock17.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id =  21,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock19.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 22,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock20.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 23,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock21.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 24,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock22.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 25,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock23.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 26,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock24.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 27,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock25.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 28,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock25-2.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 29,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock26.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 30,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock28.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 31,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock40.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 32,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock30.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 33,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock31.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 34,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock32.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 35,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock33.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 36,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock34.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 37,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock35.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 38,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock36.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 39,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock38.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 40,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock41.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 41,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock42.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 42,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock43.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 43,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock46.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 44,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock47.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 45,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock49.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 46,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock50.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 47,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock51.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 48,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock52.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 49,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock53.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 50,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock54.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 51,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock55.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 52,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock56.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 53,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock59.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 54,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock60.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 55,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock61.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 56,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock62.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 57,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock70.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 58,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock71.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 59,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock72.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 60,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock73.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 61,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rock74.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 62,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomwe-rock37.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 63,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rockone.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    },
                                    new Image
                                    {
                                        Id = 64,
                                        Url = "http://mtomawedemo.azurewebsites.net/img/mtomawe/mtomawe-rockflower.jpg",
                                        Title = "Aliquam erat volutpat",
                                        Caption = "imperdiet imperdiet. Nullam ut ligula vitae arcu vulputate dictum ut quis elit.",
                                        Route = "",
                                        SubTitle ="",
                                        IsForBaseGallery  = false
                                    }
                            };
        }
    }
}
