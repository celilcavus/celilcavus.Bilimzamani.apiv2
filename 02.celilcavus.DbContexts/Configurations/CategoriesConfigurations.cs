using _01.celilcavus.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace _02.celilcavus.DbContexts.Configurations
{
    public class CategoriesConfigurations : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
