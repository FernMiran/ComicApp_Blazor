using ComicApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Infrastructure.DomainSettings
{
    public class ComicCharacterEntityTypeConfiguration : IEntityTypeConfiguration<ComicCharacter>
    {
        public void Configure(EntityTypeBuilder<ComicCharacter> builder)
        {
            builder
                .HasKey(x => new { x.ComicId, x.CharacterId });

            builder
                .HasOne<Comic>(x => x.Comic)
                .WithMany(x => x.ComicCharacters)
                .HasForeignKey(x => x.ComicId);

            builder
                .HasOne<Character>(x => x.Character)
                .WithMany(x => x.ComicCharacters)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}
