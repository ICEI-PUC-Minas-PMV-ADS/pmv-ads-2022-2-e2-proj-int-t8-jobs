using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobs.Areas.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(32);
            builder.Property(u => u.LastName).HasMaxLength(32);
            builder.Property(u => u.UserBio).HasMaxLength(500);
            builder.Property(u => u.AddressLine).HasMaxLength(32);
            builder.Property(u => u.AdditionalAddress).HasMaxLength(32);
            builder.Property(u => u.ZipCode).HasMaxLength(8);
            builder.Property(u => u.City).HasMaxLength(32);
            builder.Property(u => u.Estate).HasMaxLength(32);
            builder.Property(u => u.AreaCode).HasMaxLength(3);
        }
    }
}