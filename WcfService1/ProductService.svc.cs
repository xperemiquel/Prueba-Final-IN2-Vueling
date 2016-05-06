using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    public class ProductService : ServiceBase, IProductService
    {
        readonly IRepositoryProduct _repository;
        readonly IUnitOfWork _unitOfWork;
        public ProductService(IRepositoryProduct repository, IUnitOfWork unitOfWork)
           : base(unitOfWork)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repositorio nulo");
            } 
            _repository = repository;

            if (null == unitOfWork)
            {
                throw new ArgumentNullException("unitOfWork nulo");
            }
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
