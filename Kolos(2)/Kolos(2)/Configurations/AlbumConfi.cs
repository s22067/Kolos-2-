using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos_2_.Models;

namespace Kolos_2_.Configurations
{
    public class AlbumConfi
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.IdAlbum).HasName("IdAlbum");
            builder.Property(e => e.AlbumName).UseIdentityColumn();

            builder.Property(e => e.PublishDate).HasMaxLength(100).IsRequired();
            builder.Property(e => e.IdMusicLabel).HasMaxLength(100).IsRequired();

            var album = new List<Album>();


            album.Add(new Album
            {

                IdAlbum = 1,
                AlbumName = "CosAlbum",
                PublishDate= new DateTime(2007, 12,25),
                IdMusicLabel=1
            }) ;
            builder.HasData(album);
        }
    }
}
