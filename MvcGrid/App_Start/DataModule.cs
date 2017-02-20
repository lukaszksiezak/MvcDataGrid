using Autofac;
using MvcDataGrid.Models;
using MvcDatagridSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Start
{
    public class DataModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Users>().As<IEntity>();
            builder.RegisterType<CrmDataService>().As<IDataProvider<Users>>().InstancePerRequest();
            base.Load(builder);
        }
    }
}