using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01.celilcavus.Entity
{
    public class Posts : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public IFormFile Image1 { get; set; }
        public string ImageName1 { get; set; }

        [NotMapped]
        public IFormFile Image2 { get; set; }
        public string ImageName2 { get; set; }

        [NotMapped]
        public IFormFile Image3 { get; set; }
        public string ImageName3 { get; set; }

        [NotMapped]
        public IFormFile Image4 { get; set; }
        public string ImageName4 { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Contexts { get; set; }

        public int AuthorId { get; set; }
        public Authors Authors { get; set; }

        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
