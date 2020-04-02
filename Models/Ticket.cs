using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieConcrete.Models
{
    public enum TicketType
    {
        Standard,
        Vip
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public decimal Price { get; set; }
        public TicketType Type { get; set; }
        public virtual Event Event { get; set; }
    }
}
