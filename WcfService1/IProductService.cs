﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<Product> GetAll();
    }
}
