using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.celilcavus.Models.HelperClass
{
    public class ImagesUpload
    {
        public string Upload(ImageType type,IFormFile formFile)
        {
            try
            {
                var fileName = string.Concat(Guid.NewGuid().ToString(),".jpg");
                if (formFile is not null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{type}", fileName);
                    using var stream = new FileStream(path, FileMode.Create);
                    formFile.CopyTo(stream);
                }
                return fileName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                
            }
            return string.Empty;
        }


        public int DeleteImage(ImageType type,string imageName)
        {
            try
            {
                var filename = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{type}", imageName);
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();

            }
            return 0;
        }
    }

    public enum ImageType
    {
        Author,
        Post
    }
}
