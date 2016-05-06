using Autofac;
using Autofac.Integration.Wcf;
using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WcfService1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<TicketService>().As<ITicketService>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryTicket>().As<IRepositoryTicket>();

            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}