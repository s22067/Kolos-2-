using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_2_.Models
{
    public class MusicLabel
    {
        [Key]
        public int IdMusicLabel { get; set; }
        public string Name { get; set; }

        public ICollection<Album> Album { get; set; }
    }
}
