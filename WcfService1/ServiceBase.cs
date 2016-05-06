using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfService1
{

    public class ServiceBase : IDisposable
    {
        readonly IUnitOfWork _unitOfWork;
        public ServiceBase(IUnitOfWork unitOfWork)
        {
            if (null != unitOfWork)
            _unitOfWork = unitOfWork;
        }

        protected int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
