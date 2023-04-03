using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanı.Model.Models
{
    public class Artist_Group
    {
        public int Artist_GroupId { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
        public override string ToString()
        {
            return Name;
        }
    }
}
