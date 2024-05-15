using _01.celilcavus.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _02.celilcavus.DbContexts.Configurations
{
    public class PostsConfigurations : IEntityTypeConfiguration<Posts>
    {
        public void Configure(EntityTypeBuilder<Posts> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne<Authors>(x => x.Authors).WithOne(xx => xx.Posts).HasForeignKey<Posts>(x => x.AuthorId);
            builder.HasOne<Categories>(x => x.Categories).WithOne(xx => xx.Posts).HasForeignKey<Posts>(x => x.CategoriesId);
        }
    }
}
