using System;
using System.Collections.Generic;
using Blackbird.Commom.ServiceLocation;
using Castle.Windsor;

namespace Blackbird.Commom.IoC
{
    public class IoCAdapter : ServiceLocatorImplBase
    {
        private readonly IWindsorContainer container;

        public IWindsorContainer Container => container;

        public static IoCAdapter Build()
        {
            return new IoCAdapter();
        }

        public IoCAdapter()
        {
            container = new WindsorContainer().Install(new IoCInstaller());
        }

        public IoCAdapter(IWindsorContainer container)
        {
            this.container = container;
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return (object[])container.ResolveAll(serviceType);
        }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            if (key != null)
                return container.Resolve(key, serviceType);

            return container.Resolve(serviceType);
        }

        public object GetService(Type serviceType)
        {
            return container.Resolve(serviceType);
        }
    }
}
