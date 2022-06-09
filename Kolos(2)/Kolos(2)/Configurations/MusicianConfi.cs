using Kolos_2_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Configurations
{
    public class MusicianConfi
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            builder.HasKey(e => e.IdMusician).HasName("IdMusician");
            builder.Property(e => e.FirstName).UseIdentityColumn();

            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Nickname).HasMaxLength(100).IsRequired();

            var musician = new List<Musician>();


            musician.Add(new Musician
            {

                IdMusician = 1,
                FirstName = "Konrad",
                LastName = "Pa",
                Nickname = "Rychu"
            });
            builder.HasData(musician);
        }
    }
}
