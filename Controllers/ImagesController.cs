using System.Collections.Generic;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers
{
    [Route("api/[controller]")]
    public class ImagesController
    {
        private readonly IImageService _ImageService;

        public ImagesController(IImageService imageService)
        {
            this._ImageService = imageService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Image> Get()
        {
            return this._ImageService.GetImages();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Image Get(int id)
        {
            return this._ImageService.GetImage(id);
        }

        // GET api/values/5
        [HttpGet("{title}")]
        public Image Get(string title)
        {
            return this._ImageService.GetImageByTitle(title);
        }
    }
}