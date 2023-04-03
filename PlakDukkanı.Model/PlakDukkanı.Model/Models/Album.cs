using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanı.Model.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Artist_Group Artist_Group { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountRate { get; set; }
        public bool Discontinued { get; set; }
    }
}
