using _01.celilcavus.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace _02.celilcavus.DbContexts.Configurations
{
    public class AuthorsConfigurations : IEntityTypeConfiguration<Authors>
    {
        public void Configure(EntityTypeBuilder<Authors> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();   

          
        }
    }
}
