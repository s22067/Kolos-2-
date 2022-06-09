using Kolos_2_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Configurations
{
    public class MusicLabelConfi
    {
        public void Configure(EntityTypeBuilder<MusicLabel> builder)
        {
            builder.HasKey(e => e.IdMusicLabel).HasName("IdMusicLabel");
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

            var musician = new List<MusicLabel>();


            musician.Add(new MusicLabel
            {
                IdMusicLabel = 1,
                Name = "MegaCos"
            });
            builder.HasData(musician);
        }
    }
}
