using System;
using Blackbird.Commom.ServiceLocation;

namespace Blackbird.Commom.IoC
{
    public static class IoCHelper
    {
        public static IServiceLocator GetLocator()
        {
            return new IoCAdapter();
        }
    }
}
