using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Models
{
    public class MusicianTrack
    {
        [Key,ForeignKey("idMusician")]
        public int IdMusician { get; set; }

        [ForeignKey("IdTrack")]
        public int IdTrack { get; set; }
        public ICollection<Album> Album { get; set; }
      
    }
}
