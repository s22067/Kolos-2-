using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        public string TrackName { get; set; }

        public float Duration { get; set; }

        [ForeignKey("IdAlbum")]
        [Key]
        public int IdMusicAlbum { get; set; }
        public ICollection<MusicianTrack> MusicianTracks { get; set; }
        [ForeignKey("IdMusicAlbum")]
        public virtual Album Album { get; set; }
    }
}
