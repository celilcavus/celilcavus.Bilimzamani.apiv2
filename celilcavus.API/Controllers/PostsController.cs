using _01.celilcavus.Entity;
using _03.celilcavus.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.API.Controllers
{
    [Route("/api/{Controller}")]
    public class PostsController : ControllerBase
    {
        private readonly IPostsServices postsServices;

        public PostsController(IPostsServices postsServices)
        {
            this.postsServices = postsServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = postsServices.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Post([FromForm] Posts posts)
        {
            postsServices.Add(posts);
            postsServices.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var values = postsServices.FindById(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var values = postsServices.FindById(id);
            postsServices.Delete(values);
            postsServices.SaveChanges();
            return Ok();
        }

    }
}
