

using GymG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymG01.Contexts.Configurations
{
    public class GymUserConfigurations <T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);


            builder.Property(X => X.Phone)
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder.Property(X => X.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.ComplexProperty(X => X.Address);

            builder.HasIndex(X => X.Email).IsUnique();

            builder.HasIndex(X => X.Phone).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "Email Like '%@%.com'");
                T.HasCheckConstraint("GymUser_PhoneCheck", "LEN(Phone) = 11 AND Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '015%' OR Phone LIKE '012%'");

            });

        }
    }

}
