using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Ticket")]
    public class Ticket : Identificable
    {
        public Ticket()
        {
            TicketItems = new HashSet<TicketItem>();
        }
        public DateTime PurchaseDate { get; set; }
        public virtual ICollection<TicketItem> TicketItems { get; set; }
    }
}
