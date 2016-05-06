using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RepositoryTicket : RepositoryBase<Ticket>, IRepositoryTicket
    {
        public RepositoryTicket(IDbBase context) : base(context){}

        public Ticket Add(Ticket ticket)
        {
            return new Ticket();
        }
        public IEnumerable<Ticket> GetAll()
        {
            return Entity.Select(c => c).ToList();
        }
 
        public Ticket Get(int id)
        {
             return Entity.Find(id);
        }

        public Ticket Delete(Ticket ticket)
        {
            return ticket;
        }
    }
}
