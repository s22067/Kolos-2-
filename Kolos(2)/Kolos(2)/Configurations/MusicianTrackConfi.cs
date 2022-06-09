using Kolos_2_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Configurations
{
    public class MusicianTrackConfi
    {
        public void Configure(EntityTypeBuilder<MusicianTrack> builder)
        {
            builder.HasKey(e => e.IdMusician).HasName("IdMusician");
            builder.HasKey(e => e.IdTrack).HasName("IdTrack");

            var musician = new List<MusicianTrack>();


            musician.Add(new MusicianTrack
            {
                IdMusician = 1,
                IdTrack=1
            });
            builder.HasData(musician);
        }
    }
}
