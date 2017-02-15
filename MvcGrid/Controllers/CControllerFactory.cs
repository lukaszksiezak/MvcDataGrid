using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using MvcDataGrid.Models;
using MvcDatagridSample.Models;

namespace MvcDataGrid.Controllers
{
    public class CControllerFactory : DefaultControllerFactory
    {
        public CControllerFactory(IControllerActivator controllerActivator) : base(controllerActivator)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Users>().As<IEntity>();
            builder.RegisterType<CrmDataService>().As<IDataProvider<IEntity>>();

        }
    }
}