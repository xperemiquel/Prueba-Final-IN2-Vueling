using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Infrastructure
{
    public class AppContext : DbContext, IDbBase, IUnitOfWork
    {
        public AppContext() : base("DefaultConnection") { }
        public new IDbSet<T> Set<T>() where T : class
        {
            return Set<T>();
        }
    }
}

