using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieConcrete.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public virtual City City { get; set; }
        public virtual Band Band { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public DateTime Date { get; set; }
    }
}
