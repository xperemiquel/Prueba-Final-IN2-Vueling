using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RepositoryBase<T> where T : class
    {
        readonly IDbBase _contexto;
        public RepositoryBase(IDbBase contexto)
        {
            if (null == contexto)
            {
                throw new ArgumentNullException("contexto nulo");
            }
            _contexto = contexto;
        }

        protected IDbSet<T> Entity
        {
            get
            {
                return _contexto.Set<T>();
            }
        }
    }
}
