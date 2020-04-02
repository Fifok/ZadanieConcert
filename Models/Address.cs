using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieConcrete.Models
{
    public class Address
    {
        public int BandId { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual Band Band { get; set; }
    }
}
