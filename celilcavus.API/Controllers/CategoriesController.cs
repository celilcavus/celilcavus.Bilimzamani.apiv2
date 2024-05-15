using _01.celilcavus.Entity;
using _03.celilcavus.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.API.Controllers
{
    [Route("/api/{Controller}")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesServices categoriesServices;

        public CategoriesController(ICategoriesServices categoriesServices)
        {
            this.categoriesServices = categoriesServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = categoriesServices.GetAll();
            return Ok(values);
        }

        [HttpPost]
       
        public IActionResult Index([FromForm] Categories categories)
        {
            categoriesServices.Add(categories);
            categoriesServices.SaveChanges();
            return Ok(categories);
        }

        [HttpDelete("{id}")]
       
        public IActionResult Delete([FromRoute] int id)
        {
            var values = categoriesServices.FindById(id);
            categoriesServices.Delete(values);
            categoriesServices.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var values = categoriesServices.FindById(id);
            return Ok(values);
        }
        
    }
}
