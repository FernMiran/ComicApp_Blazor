using ComicApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicApp.Infrastructure.DomainSettings
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Username)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Password)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
