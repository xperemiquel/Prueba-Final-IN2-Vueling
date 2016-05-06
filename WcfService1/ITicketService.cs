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
    [ServiceContract]
    public interface ITicketService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Ticket Add(Ticket ticket);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        Ticket Get(int id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetAll", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Ticket> GetAll();

    }
}
