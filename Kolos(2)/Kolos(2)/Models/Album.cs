using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime s { get; set; }

        [ForeignKey("IdMusicLabel")]
        public int IdMusicLabel { get; set; }
        public DateTime PublishDate { get; internal set; }
        public ICollection<Track> Track { get; set; }
        public ICollection<MusicLabel> MusicLabel { get; set; }
       
    }
}
