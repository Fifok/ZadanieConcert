using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieConcrete.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Voivodeship { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
