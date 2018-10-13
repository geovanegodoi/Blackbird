using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Blackbird.Commom.Mapper
{
    public abstract class AutoMapperInitializerBase : IAutoMapperInitializer
    {
        private readonly string defaultNamespace;

        protected AutoMapperInitializerBase(string defaultNamespace)
        {
            this.defaultNamespace = defaultNamespace;
        }

        public void RegisterTypes(IMapperConfiguration cfg)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().ToString().Contains(defaultNamespace)).ToList();
            var types = new List<Type>();

            foreach (var assembly in assemblies)
            {
                types.AddRange(assembly.GetTypes().Where(a => a.FullName.Contains($"{defaultNamespace}.Application") || 
                                                              a.FullName.Contains($"{defaultNamespace}.Domain")));
            }

            foreach (var toType in types)
            {
                if (!toType.FullName.Contains("<") && toType.Name.EndsWith("TO") && types.Where(a => a.Name == toType.Name.Substring(0, toType.Name.Length - 2)).Any())
                {
                    var domainType = types.FirstOrDefault(a => a.FullName == $"{defaultNamespace}.Domain.Entities.{toType.Name.Substring(0, toType.Name.Length - 2)}");
                    if (domainType != null)
                    {
                        cfg.Expression.CreateMap(toType, domainType); //.IncludeBase(toType.GetTypeInfo().BaseType, domainType.GetTypeInfo().BaseType);
                        cfg.Expression.CreateMap(domainType, toType); //.IncludeBase(domainType.GetTypeInfo().BaseType, toType.GetTypeInfo().BaseType);
                    }
                }
            }
            OverwriteSettings(cfg);
        }

        public abstract void OverwriteSettings(IMapperConfiguration cfg);
    }
}
