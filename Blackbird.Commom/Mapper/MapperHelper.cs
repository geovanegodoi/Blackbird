using System;
using System.Collections.Generic;
using Blackbird.Commom.ServiceLocation;

namespace Blackbird.Commom.Mapper
{
    public static class MapperHelper
    {
        private static object loker = new object();
        private static bool isAutoMapperInitialized = false;

        public static void InitiateAutoMapper()
        {
            InitiateAutoMapper(ServiceLocator.Current.GetAllInstances<IAutoMapperInitializer>());
        }

        public static void InitiateAutoMapper(IEnumerable<IAutoMapperInitializer> autoMapperInitializers)
        {
            lock (loker)
            {
                if (!isAutoMapperInitialized)
                {
                    AutoMapper.Mapper.Initialize(cfg =>
                    {
                        var config = new MapperConfiguration(cfg);

                        foreach (var item in autoMapperInitializers)
                        {
                            item.RegisterTypes(config);
                        }
                    });
                    isAutoMapperInitialized = true;
                }
            }
        }
    }
}
