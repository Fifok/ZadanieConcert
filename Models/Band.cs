using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieConcrete.Models
{
    public class Band
    {
        public int BandId { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        //public virtual ICollection<Event> Events { get; set; }
    }
}
