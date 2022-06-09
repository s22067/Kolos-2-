using DocumentFormat.OpenXml.Office2019.Presentation;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos_2_.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolos_2_.Configurations
{
    public class TrackConfi
    {
        public void Configure(EntityTypeBuilder<Models.Track> builder)
        {
            builder.HasKey(e => e.IdTrack).HasName("IdMusician");
            builder.Property(e => e.TrackName).UseIdentityColumn();

            builder.Property(e => e.Duration).HasMaxLength(100).IsRequired();
            builder.Property(e => e.IdMusicAlbum).HasMaxLength(100).IsRequired();

            var musician = new List<Models.Track>();

            musician.Add(new Models.Track
            {

                IdTrack = 1,
                TrackName = "Konrad",
                Duration = 10,
                IdMusicAlbum = 1
            });
            builder.HasData(musician);
        }
    }
}
