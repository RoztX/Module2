using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Module2
{
    public class Config
    {
        public IContainer RegistrarDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OutputList>().As<IOutputList>();
            builder.RegisterType<SortList>().As<ISortList>();
            builder.RegisterType<Summarizing>().As<ISummarizing>();
            builder.RegisterType<GetFromConsole>().As<IGetFromConsole>();
            builder.RegisterType<Starter>();
            var cotainer = builder.Build();
            return cotainer;
        }
    }
}
