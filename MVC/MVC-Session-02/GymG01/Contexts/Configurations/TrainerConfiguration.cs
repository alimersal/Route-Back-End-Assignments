using GymG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymG01.Contexts.Configurations
{
    public class TrainerConfiguration :GymUserConfigurations <Trainer> , IEntityTypeConfiguration<Trainer>
    {
     public new void Configure(EntityTypeBuilder<Trainer> builder)
      {
        builder.Property(X =>X.CreatedAt)
                .HasColumnName("HireDate")
                .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    

    }
}
