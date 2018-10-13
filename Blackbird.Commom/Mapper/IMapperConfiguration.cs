using System;
using AutoMapper;

namespace Blackbird.Commom.Mapper
{
    public interface IMapperConfiguration
    {
        IMapperConfigurationExpression Expression { get; set; }
    }

    public class MapperConfiguration : IMapperConfiguration
    {
        public IMapperConfigurationExpression Expression { get; set; }

        public MapperConfiguration(IMapperConfigurationExpression expression)
        {
            Expression = expression;
        }
    }
}
