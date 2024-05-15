using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.celilcavus.Entity
{
    public class Authors:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }

        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Github { get; set; }

        public Posts Posts { get; set; }

        public string GetFullName() => string.Concat(Name, " ", LastName);
    }
}
