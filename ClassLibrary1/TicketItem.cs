using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace Domain
{
    public class TicketItem : Identificable
    {
        public decimal Volume { get; set; }
        public virtual Product Product { get; set; }
        public virtual decimal Price { get; set; }
    }
}
