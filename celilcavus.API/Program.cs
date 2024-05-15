using _02.celilcavus.DbContexts;
using _03.celilcavus.Models.HelperClass;
using _03.celilcavus.Models.Interfaces;
using _03.celilcavus.Models.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Abstractions;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;

namespace celilcavus.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<BilimzamaniContext>(x =>
            {
                x.UseSqlServer("Server=91.151.90.223;Database=celil_;User Id=celil_;Password=k&#EkYNthp8ex4v0;TrustServerCertificate=True;");
            });
          
            // Add services to the container.
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(x =>
            {
                x.ResolveConflictingActions(x => x.First());
            });


            builder.Services.AddScoped<IAuthorsServices,AuthorsRepository>();
            builder.Services.AddScoped<ICategoriesServices,CategoriesRepository>();
            builder.Services.AddScoped<IPostsServices,PostsRepository>();
            builder.Services.AddScoped<ImagesUpload, ImagesUpload>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
