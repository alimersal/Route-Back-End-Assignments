using GymG01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymG01.Contexts.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(E => E.Id);

            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
