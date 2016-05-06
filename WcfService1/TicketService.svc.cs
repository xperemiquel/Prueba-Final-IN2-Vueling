using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
     public class TicketService : ServiceBase, ITicketService
     {
        public IRepositoryTicket _repositoryTicket { get; set; }
        public TicketService(IRepositoryTicket repositoryTicket, IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            _repositoryTicket = repositoryTicket;
        }
         public Ticket Add(Ticket ticket)
        {
            foreach (var item in ticket.TicketItems)
            {
                item.Price = item.Product.Price;
            }
            var newTicket = _repositoryTicket.Add(ticket);
            SaveChanges();
            return newTicket;
        }

        public Ticket Update(int id, Ticket ticket)
        {
            var oldTicket = Get(id);
            if (null == oldTicket)
            {
                throw new NullReferenceException("ticket nulo");
            }
            oldTicket.TicketItems = ticket.TicketItems;
            SaveChanges();
            return oldTicket;
        }

        public Ticket Delete(int id)
        {
            var ticket = Get(id);
            _repositoryTicket.Delete(ticket);
            SaveChanges();
            return ticket;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _repositoryTicket.GetAll().ToList();
        }

        public Ticket Get(int id)
        {
            return _repositoryTicket.Get(id);
        }
    }
}

