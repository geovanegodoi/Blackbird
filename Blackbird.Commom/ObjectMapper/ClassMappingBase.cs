using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Blackbird.Commom.ObjectMapper
{
    public abstract class ClassMappingBase : IClassMapping
    {
        public abstract void ApplyMapping(IMapperConfigurationExpression cfg);

        protected abstract void ApplyDefaultMapping(IMapperConfigurationExpression cfg);

        protected abstract void ApplyNonDefaultMapping(IMapperConfigurationExpression cfg);

        protected List<Type> WhoImplementsThis(Type type)
        {
            return AppDomain.CurrentDomain
                            .GetAssemblies()
                            .SelectMany(x => x.GetTypes())
                            .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                            //.Select(x => x.Name)
                            .ToList();
        }
    }
}
