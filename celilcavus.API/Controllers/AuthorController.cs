using _01.celilcavus.Entity;
using _03.celilcavus.Models.HelperClass;
using _03.celilcavus.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.API.Controllers
{
    [Route("/api/{Controller}")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorsServices authorsServices;
        private readonly ImagesUpload upload;

        public AuthorController(IAuthorsServices authorsServices, ImagesUpload upload)
        {
            this.authorsServices = authorsServices;
            this.upload = upload;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = authorsServices.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Post([FromForm] Authors authors)
        {
            var name = upload.Upload(ImageType.Author, authors.Image);
            authors.ImageName = name;
            authorsServices.Add(authors);
            authorsServices.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var values = authorsServices.FindById(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var values = authorsServices.FindById(id);
            upload.DeleteImage(ImageType.Author,values.ImageName);
            authorsServices.Delete(values);
            authorsServices.SaveChanges();
            return Ok(values);
        }
    }
}
